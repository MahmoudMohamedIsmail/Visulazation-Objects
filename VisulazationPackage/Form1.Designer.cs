namespace VisulazationPackage
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.simpleOpenGlControl1 = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.Browse1 = new System.Windows.Forms.Button();
            this.Path = new System.Windows.Forms.TextBox();
            this.Load1 = new System.Windows.Forms.Button();
            this.DataName = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Edges_radio = new System.Windows.Forms.RadioButton();
            this.Faces_radio = new System.Windows.Forms.RadioButton();
            this.ColorGrid = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Smax_text = new System.Windows.Forms.TextBox();
            this.Smin_text = new System.Windows.Forms.TextBox();
            this.Panel_Grid = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.axis_t = new System.Windows.Forms.ComboBox();
            this.zoomout = new System.Windows.Forms.Button();
            this.zoomin = new System.Windows.Forms.Button();
            this.rotate_mesh = new System.Windows.Forms.Button();
            this.down_mesh = new System.Windows.Forms.Button();
            this.right_mesh = new System.Windows.Forms.Button();
            this.up_mesh = new System.Windows.Forms.Button();
            this.left_mesh = new System.Windows.Forms.Button();
            this.CheckValue = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleOpenGlControl1
            // 
            this.simpleOpenGlControl1.AccumBits = ((byte)(0));
            this.simpleOpenGlControl1.AutoCheckErrors = false;
            this.simpleOpenGlControl1.AutoFinish = false;
            this.simpleOpenGlControl1.AutoMakeCurrent = true;
            this.simpleOpenGlControl1.AutoSwapBuffers = true;
            this.simpleOpenGlControl1.BackColor = System.Drawing.Color.Black;
            this.simpleOpenGlControl1.ColorBits = ((byte)(32));
            this.simpleOpenGlControl1.DepthBits = ((byte)(16));
            this.simpleOpenGlControl1.Location = new System.Drawing.Point(3, 40);
            this.simpleOpenGlControl1.Name = "simpleOpenGlControl1";
            this.simpleOpenGlControl1.Size = new System.Drawing.Size(386, 348);
            this.simpleOpenGlControl1.StencilBits = ((byte)(0));
            this.simpleOpenGlControl1.TabIndex = 0;
            this.simpleOpenGlControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.simpleOpenGlControl1_Paint);
            // 
            // Browse1
            // 
            this.Browse1.Location = new System.Drawing.Point(3, 12);
            this.Browse1.Name = "Browse1";
            this.Browse1.Size = new System.Drawing.Size(75, 22);
            this.Browse1.TabIndex = 2;
            this.Browse1.Text = "Browse";
            this.Browse1.UseVisualStyleBackColor = true;
            this.Browse1.Click += new System.EventHandler(this.Browse1_Click);
            // 
            // Path
            // 
            this.Path.Location = new System.Drawing.Point(84, 14);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(224, 20);
            this.Path.TabIndex = 3;
            // 
            // Load1
            // 
            this.Load1.Location = new System.Drawing.Point(314, 14);
            this.Load1.Name = "Load1";
            this.Load1.Size = new System.Drawing.Size(75, 20);
            this.Load1.TabIndex = 4;
            this.Load1.Text = "Load";
            this.Load1.UseVisualStyleBackColor = true;
            this.Load1.Click += new System.EventHandler(this.Load1_Click);
            // 
            // DataName
            // 
            this.DataName.FormattingEnabled = true;
            this.DataName.Location = new System.Drawing.Point(6, 32);
            this.DataName.Name = "DataName";
            this.DataName.Size = new System.Drawing.Size(89, 21);
            this.DataName.TabIndex = 5;
            this.DataName.SelectedIndexChanged += new System.EventHandler(this.DataName_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CheckValue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Edges_radio);
            this.groupBox1.Controls.Add(this.Faces_radio);
            this.groupBox1.Controls.Add(this.DataName);
            this.groupBox1.Location = new System.Drawing.Point(395, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 110);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Data Name";
            // 
            // Edges_radio
            // 
            this.Edges_radio.AutoSize = true;
            this.Edges_radio.Location = new System.Drawing.Point(6, 82);
            this.Edges_radio.Name = "Edges_radio";
            this.Edges_radio.Size = new System.Drawing.Size(91, 17);
            this.Edges_radio.TabIndex = 7;
            this.Edges_radio.TabStop = true;
            this.Edges_radio.Text = "Edge Coloring";
            this.Edges_radio.UseVisualStyleBackColor = true;
            // 
            // Faces_radio
            // 
            this.Faces_radio.AutoSize = true;
            this.Faces_radio.Location = new System.Drawing.Point(5, 59);
            this.Faces_radio.Name = "Faces_radio";
            this.Faces_radio.Size = new System.Drawing.Size(90, 17);
            this.Faces_radio.TabIndex = 6;
            this.Faces_radio.TabStop = true;
            this.Faces_radio.Text = "Face Coloring";
            this.Faces_radio.UseVisualStyleBackColor = true;
            // 
            // ColorGrid
            // 
            this.ColorGrid.FormattingEnabled = true;
            this.ColorGrid.Items.AddRange(new object[] {
            "Discrete",
            "Continuous"});
            this.ColorGrid.Location = new System.Drawing.Point(6, 32);
            this.ColorGrid.Name = "ColorGrid";
            this.ColorGrid.Size = new System.Drawing.Size(88, 21);
            this.ColorGrid.TabIndex = 7;
            this.ColorGrid.SelectedIndexChanged += new System.EventHandler(this.ColorGrid_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ColorGrid";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Smax_text);
            this.groupBox2.Controls.Add(this.Smin_text);
            this.groupBox2.Controls.Add(this.Panel_Grid);
            this.groupBox2.Controls.Add(this.ColorGrid);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(395, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 112);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // Smax_text
            // 
            this.Smax_text.Location = new System.Drawing.Point(144, 56);
            this.Smax_text.Name = "Smax_text";
            this.Smax_text.Size = new System.Drawing.Size(49, 20);
            this.Smax_text.TabIndex = 11;
            // 
            // Smin_text
            // 
            this.Smin_text.Location = new System.Drawing.Point(6, 59);
            this.Smin_text.Name = "Smin_text";
            this.Smin_text.Size = new System.Drawing.Size(49, 20);
            this.Smin_text.TabIndex = 10;
            // 
            // Panel_Grid
            // 
            this.Panel_Grid.Location = new System.Drawing.Point(6, 85);
            this.Panel_Grid.Name = "Panel_Grid";
            this.Panel_Grid.Size = new System.Drawing.Size(187, 24);
            this.Panel_Grid.TabIndex = 9;
            this.Panel_Grid.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Grid_Paint);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.axis_t);
            this.groupBox3.Controls.Add(this.zoomout);
            this.groupBox3.Controls.Add(this.zoomin);
            this.groupBox3.Controls.Add(this.rotate_mesh);
            this.groupBox3.Controls.Add(this.down_mesh);
            this.groupBox3.Controls.Add(this.right_mesh);
            this.groupBox3.Controls.Add(this.up_mesh);
            this.groupBox3.Controls.Add(this.left_mesh);
            this.groupBox3.Location = new System.Drawing.Point(396, 240);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(198, 148);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transformations  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Axis";
            // 
            // axis_t
            // 
            this.axis_t.FormattingEnabled = true;
            this.axis_t.Items.AddRange(new object[] {
            "X",
            "Y",
            "Z"});
            this.axis_t.Location = new System.Drawing.Point(134, 48);
            this.axis_t.Name = "axis_t";
            this.axis_t.Size = new System.Drawing.Size(57, 21);
            this.axis_t.TabIndex = 11;
            // 
            // zoomout
            // 
            this.zoomout.Location = new System.Drawing.Point(66, 115);
            this.zoomout.Name = "zoomout";
            this.zoomout.Size = new System.Drawing.Size(55, 23);
            this.zoomout.TabIndex = 10;
            this.zoomout.Text = "ZoomO";
            this.zoomout.UseVisualStyleBackColor = true;
            this.zoomout.Click += new System.EventHandler(this.zoomout_Click);
            // 
            // zoomin
            // 
            this.zoomin.Location = new System.Drawing.Point(5, 115);
            this.zoomin.Name = "zoomin";
            this.zoomin.Size = new System.Drawing.Size(55, 23);
            this.zoomin.TabIndex = 8;
            this.zoomin.Text = "ZoomIN";
            this.zoomin.UseVisualStyleBackColor = true;
            this.zoomin.Click += new System.EventHandler(this.zoomin_Click);
            // 
            // rotate_mesh
            // 
            this.rotate_mesh.Location = new System.Drawing.Point(134, 115);
            this.rotate_mesh.Name = "rotate_mesh";
            this.rotate_mesh.Size = new System.Drawing.Size(55, 23);
            this.rotate_mesh.TabIndex = 9;
            this.rotate_mesh.Text = "Rotate";
            this.rotate_mesh.UseVisualStyleBackColor = true;
            this.rotate_mesh.Click += new System.EventHandler(this.rotate_mesh_Click);
            // 
            // down_mesh
            // 
            this.down_mesh.Location = new System.Drawing.Point(33, 77);
            this.down_mesh.Name = "down_mesh";
            this.down_mesh.Size = new System.Drawing.Size(54, 23);
            this.down_mesh.TabIndex = 6;
            this.down_mesh.Text = "DOWN";
            this.down_mesh.UseVisualStyleBackColor = true;
            this.down_mesh.Click += new System.EventHandler(this.down_mesh_Click);
            // 
            // right_mesh
            // 
            this.right_mesh.Location = new System.Drawing.Point(66, 48);
            this.right_mesh.Name = "right_mesh";
            this.right_mesh.Size = new System.Drawing.Size(54, 23);
            this.right_mesh.TabIndex = 7;
            this.right_mesh.Text = "RIGHT";
            this.right_mesh.UseVisualStyleBackColor = true;
            this.right_mesh.Click += new System.EventHandler(this.right_mesh_Click);
            // 
            // up_mesh
            // 
            this.up_mesh.Location = new System.Drawing.Point(33, 19);
            this.up_mesh.Name = "up_mesh";
            this.up_mesh.Size = new System.Drawing.Size(54, 23);
            this.up_mesh.TabIndex = 5;
            this.up_mesh.Text = "UP";
            this.up_mesh.UseVisualStyleBackColor = true;
            this.up_mesh.Click += new System.EventHandler(this.up_mesh_Click);
            // 
            // left_mesh
            // 
            this.left_mesh.Location = new System.Drawing.Point(5, 48);
            this.left_mesh.Name = "left_mesh";
            this.left_mesh.Size = new System.Drawing.Size(55, 23);
            this.left_mesh.TabIndex = 4;
            this.left_mesh.Text = "LEFT";
            this.left_mesh.UseVisualStyleBackColor = true;
            this.left_mesh.Click += new System.EventHandler(this.left_mesh_Click);
            // 
            // CheckValue
            // 
            this.CheckValue.AutoSize = true;
            this.CheckValue.Location = new System.Drawing.Point(101, 34);
            this.CheckValue.Name = "CheckValue";
            this.CheckValue.Size = new System.Drawing.Size(58, 17);
            this.CheckValue.TabIndex = 9;
            this.CheckValue.Text = "Values";
            this.CheckValue.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 397);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Load1);
            this.Controls.Add(this.Path);
            this.Controls.Add(this.Browse1);
            this.Controls.Add(this.simpleOpenGlControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl simpleOpenGlControl1;
        private System.Windows.Forms.Button Browse1;
        private System.Windows.Forms.TextBox Path;
        private System.Windows.Forms.Button Load1;
        private System.Windows.Forms.ComboBox DataName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Edges_radio;
        private System.Windows.Forms.RadioButton Faces_radio;
        private System.Windows.Forms.ComboBox ColorGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Smax_text;
        private System.Windows.Forms.TextBox Smin_text;
        private System.Windows.Forms.Panel Panel_Grid;
        private System.Windows.Forms.CheckBox CheckValue;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox axis_t;
        private System.Windows.Forms.Button zoomout;
        private System.Windows.Forms.Button zoomin;
        private System.Windows.Forms.Button rotate_mesh;
        private System.Windows.Forms.Button down_mesh;
        private System.Windows.Forms.Button right_mesh;
        private System.Windows.Forms.Button up_mesh;
        private System.Windows.Forms.Button left_mesh;
    }
}

