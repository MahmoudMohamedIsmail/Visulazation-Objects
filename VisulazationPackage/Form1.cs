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
    public partial class Form1 : Form
    {
        Load_Mesh loadMesh = new Load_Mesh();
        Mesh mesh;
        Coloring_Mesh ColorMesh = new Coloring_Mesh();
        double Smax=0, Smin=0;
        Point3 p1 = new Point3(100, 100, 100), p2 = new Point3(0, 0, 0);
        public Form1()
        {
            InitializeComponent();
            InitGraphics();
        }
        public void InitGraphics()
        {
            simpleOpenGlControl1.InitializeContexts();
            simpleOpenGlControl1.Paint += new PaintEventHandler(simpleOpenGlControl1_Paint);
            Glut.glutInit();
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluOrtho2D(-1, 2, -1, 2);

        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {

            String data = DataName.Text.ToString(); 
            if (data.Length > 0 && Edges_radio.Checked)
            {
               
                ColorMesh.EdgeColoring(mesh, data, ColorGrid.SelectedIndex, Smin, Smax,CheckValue.Checked);
              
                
            }
            else if (data.Length > 0 && Faces_radio.Checked)
            {
                ColorMesh.FaceColoring(mesh, data, ColorGrid.SelectedIndex, Smin, Smax, CheckValue.Checked);

            }
            else if (Path.Text != "")
            {
                mesh = new Mesh(Path.Text);
              loadMesh.mesh_drwa(mesh,out p1,out p2);
                 DataName.Items.Clear();
                foreach (String str in mesh.VarToIndex.Keys)
                {
                        DataName.Items.Add(str);
                }
            }
            simpleOpenGlControl1.Invalidate();
        }

        private void Browse1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Browse";
            //fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "Text Files|*.dat";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                Path.Text = fdlg.FileName;
            }
        }

        private void Load1_Click(object sender, EventArgs e)
        {
            simpleOpenGlControl1.Invalidate();
        }

        private void DataName_SelectedIndexChanged(object sender, EventArgs e)
        {

            String data = DataName.Text.ToString();
            uint index = Convert.ToUInt32(mesh.VarToIndex[data]);
            mesh.GetMinMaxValues(index, out Smin, out Smax);
            Smax_text.Text = Smax.ToString();
            Smin_text.Text = Smin.ToString();
            simpleOpenGlControl1.Invalidate();
        }

        private void Panel_Grid_Paint(object sender, PaintEventArgs e)
        {
            if (ColorGrid.SelectedIndex == 0)
            {
                Color_Functions.createDiscreteColors(Panel_Grid);
            }
            else if (ColorGrid.SelectedIndex == 1)
            {
                Rectangle rect = this.ClientRectangle;
                Color_Functions.createContinuousColors(e, rect);
            }
        }

        private void ColorGrid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ColorGrid.SelectedIndex == 0)
            {
                Panel_Grid.Invalidate();
            }
            else if (ColorGrid.SelectedIndex == 1)
            {
                Panel_Grid.Invalidate();
            }
        }

        private void up_mesh_Click(object sender, EventArgs e)
        {

            Gl.glTranslatef(0, .2f, 0);
            simpleOpenGlControl1.Invalidate();
        }

        private void down_mesh_Click(object sender, EventArgs e)
        {
            Gl.glTranslatef(0, -.2f, 0);
            simpleOpenGlControl1.Invalidate();
        }

        private void right_mesh_Click(object sender, EventArgs e)
        {
            Gl.glTranslatef(.2f, 0, 0);
            simpleOpenGlControl1.Invalidate();
        }

        private void left_mesh_Click(object sender, EventArgs e)
        {

            Gl.glTranslatef(-0.2f, 0, 0);
            simpleOpenGlControl1.Invalidate();
        }

        private void zoomin_Click(object sender, EventArgs e)
        {

            float x = float.Parse(((p1.x + p2.x) / 2).ToString());
            float y = float.Parse(((p1.y + p2.y) / 2).ToString());
            float z = float.Parse(((p1.z + p2.z) / 2).ToString());
            Gl.glTranslatef(x, y, z);
            Gl.glScalef(1.1f, 1.1f, 0);
            Gl.glTranslatef(-x, -y, -z);

            simpleOpenGlControl1.Invalidate();
        }

        private void zoomout_Click(object sender, EventArgs e)
        {
            float x = float.Parse(((p1.x + p2.x) / 2).ToString());
            float y = float.Parse(((p1.y + p2.y) / 2).ToString());
            float z = float.Parse(((p1.z + p2.z) / 2).ToString());
            Gl.glTranslatef(x, y, z);
            Gl.glScalef(0.9f, 0.9f, 0);
            Gl.glTranslatef(-x, -y, -z);
            simpleOpenGlControl1.Invalidate();
        }

        private void rotate_mesh_Click(object sender, EventArgs e)
        {

            float x = float.Parse(((p1.x + p2.x) / 2).ToString());
            float y = float.Parse(((p1.y + p2.y) / 2).ToString());
            float z = float.Parse(((p1.z + p2.z) / 2).ToString());

            if (axis_t.SelectedIndex == 0)
            {
                Gl.glTranslatef(x, y, z);
                Gl.glRotatef(10, 1, 0, 0);
                Gl.glTranslatef(-x, -y, -z);


            }
            else if (axis_t.SelectedIndex == 1)
            {
                Gl.glTranslatef(x, y, z);
                Gl.glRotatef(10, 0, 1, 0);
                Gl.glTranslatef(-x, -y, -z);
            }
            else if (axis_t.SelectedIndex == 2)
            {
                Gl.glTranslatef(x, y, z);
                Gl.glRotatef(10, 0, 0, 1);
                Gl.glTranslatef(-x, -y, -z);
            }
            simpleOpenGlControl1.Invalidate();
        }
    }
}
