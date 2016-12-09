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
    class Load_Mesh
    {
        
       // Point3 p1 = new Point3(100, 100, 100), p2 = new Point3(0, 0, 0);
        public void mesh_drwa(Mesh new_mesh,out Point3 p1,out Point3 p2)
        {
            p1 = new Point3(100, 100, 100); p2 = new Point3(0, 0, 0);
            Gl.glClearColor(1, 1, 1, 1);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            foreach (Zone z in new_mesh.Zones)
            {

                z.GetMinMaxVertices(p1, p2);
                foreach (Face f in z.Faces)
                {
                    Gl.glBegin(Gl.GL_LINES);
                    foreach (uint ee in f.Edges)
                    {
                        Edge _edge = z.Edges[ee];
                        Gl.glColor3d(0, 0, 1);
                        z.Vertices[_edge.Start].Position.glTell();
                        z.Vertices[_edge.End].Position.glTell();

                    }
                    Gl.glEnd();
                    Gl.glFlush();
                }

            }

        }


    }
}
