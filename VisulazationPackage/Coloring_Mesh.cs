using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.OpenGl;
using Tao.Platform.Windows;
using System.Drawing.Drawing2D;
using Tao.FreeGlut;
using Visualization;

namespace VisulazationPackage
{
    class Coloring_Mesh
    {

        public void EdgeColoring(Mesh m, String data, int GridColor, double smin, double smax, bool CheckValue)
        {

            Gl.glClearColor(1, 1, 1, 1);

            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);

            double edge_avg, r, g, b, min, max;
            uint index = Convert.ToUInt32(m.VarToIndex[data]);
            m.GetMinMaxValues(index, out min, out  max);
            foreach (Zone z in m.Zones)
            {
                foreach (Face f in z.Faces)
                {
                    foreach (uint edgeIndex in f.Edges)
                    {
                        Edge e = z.Edges[edgeIndex];
                        double v1_data = z.Vertices[e.Start].Data[index];
                        double v2_data = z.Vertices[e.End].Data[index];
                        edge_avg = (v1_data + v2_data) / 2;
                        r = g = b = 0;
                     
                        
                          
                        Color_Functions.ValueToColor(edge_avg, smin, smax, GridColor, out r, out g, out b);
                            
                     
                       if(CheckValue) //To Drwa Values in Edges 
                       {
                        string TextShow = edge_avg.ToString();
                        int sz = TextShow.Length;
                        float xx = (float.Parse(z.Vertices[e.Start].Position.x.ToString()) + float.Parse(z.Vertices[e.End].Position.x.ToString())) / 2;
                        float yy = (float.Parse(z.Vertices[e.Start].Position.y.ToString()) + float.Parse(z.Vertices[e.End].Position.y.ToString())) / 2;
                       
                        Gl.glColor3d(0, 0, 0);
                        Gl.glRasterPos2d(xx, yy);
                        for (int k = 0; k < sz; k++)
                        {
                            Glut.glutBitmapCharacter(Glut.GLUT_BITMAP_HELVETICA_10, TextShow[k]);

                        }
                    }
                       
                        Gl.glBegin(Gl.GL_LINES);

                        Gl.glColor3d(r / 255, g / 255, b / 255);

                        z.Vertices[e.Start].Position.glTell();
                        z.Vertices[e.End].Position.glTell();
                        Gl.glEnd();

                        Gl.glFlush();

                    }


                }

            }

        }
        public void FaceColoring(Mesh m, String data, int GridColor, double smin, double smax, bool CheckValue)
        {
            Gl.glClearColor(1, 1, 1, 1);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            double face_avg = 0, r, g, b;
            uint index = Convert.ToUInt32(m.VarToIndex[data]);

            foreach (Zone z in m.Zones)
            {
                foreach (Face f in z.Faces)
                {

                    double v1_data = z.Vertices[f.Vertices[0]].Data[index];
                    double v2_data = z.Vertices[f.Vertices[1]].Data[index];
                    double v3_data = z.Vertices[f.Vertices[2]].Data[index];
                    face_avg = v1_data + v2_data + v3_data;
                    face_avg /= 3;
                    foreach (uint edgeIndex in f.Edges)
                    {
                        Edge e = z.Edges[edgeIndex];
                        r = g = b = 0;   
                        Color_Functions.ValueToColor(face_avg, smin, smax,GridColor, out r, out g, out b);
                        if (CheckValue) //To Drwa Values on Faces 
                        {
                            string TextShow = face_avg.ToString();
                            int sz = TextShow.Length;
                            float xx = (float.Parse(z.Vertices[f.Vertices[0]].Position.x.ToString()) + float.Parse(z.Vertices[f.Vertices[1]].Position.x.ToString()) + float.Parse(z.Vertices[f.Vertices[1]].Position.x.ToString()))/ 3;
                            float yy = (float.Parse(z.Vertices[f.Vertices[0]].Position.y.ToString()) + float.Parse(z.Vertices[f.Vertices[1]].Position.y.ToString()) + float.Parse(z.Vertices[f.Vertices[1]].Position.y.ToString())) / 3;

                            Gl.glColor3d(0, 0, 0);
                            Gl.glRasterPos2d(xx, yy);
                            for (int k = 0; k < sz; k++)
                            {
                                Glut.glutBitmapCharacter(Glut.GLUT_BITMAP_HELVETICA_10, TextShow[k]);

                            }
                        }

                        Gl.glBegin(Gl.GL_TRIANGLES);
                        Gl.glColor3d(r / 255, g / 255, b / 255);
                        z.Vertices[e.Start].Position.glTell();
                  
                    }
                    Gl.glEnd();
                    Gl.glFlush();
                }
            }
        }


    }
}
