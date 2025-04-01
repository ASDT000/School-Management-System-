namespace School_Management_System
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            label1 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            dashboardForm1 = new DashboardForm();
            addStudentForm1 = new AddStudentForm();
            addTeachersForm1 = new AddTeachersForm();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1024, 25);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(3, 6);
            label2.Name = "label2";
            label2.Size = new Size(257, 16);
            label2.TabIndex = 0;
            label2.Text = "School Management System  |  Main Form";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel2.Location = new Point(0, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(224, 621);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 588);
            label3.Name = "label3";
            label3.Size = new Size(68, 16);
            label3.TabIndex = 6;
            label3.Text = " LOG OUT";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Benguiat Bk BT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 132);
            label1.Name = "label1";
            label1.Size = new Size(196, 23);
            label1.TabIndex = 5;
            label1.Text = "Skills International";
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.Red;
            button4.FlatAppearance.MouseOverBackColor = Color.Red;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(12, 562);
            button4.Name = "button4";
            button4.Size = new Size(46, 51);
            button4.TabIndex = 4;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.MouseDownBackColor = Color.Blue;
            button3.FlatAppearance.MouseOverBackColor = Color.Blue;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(12, 313);
            button3.Name = "button3";
            button3.Size = new Size(200, 40);
            button3.TabIndex = 3;
            button3.Text = "Add Teacher";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.MouseDownBackColor = Color.Blue;
            button2.FlatAppearance.MouseOverBackColor = Color.Blue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(12, 252);
            button2.Name = "button2";
            button2.Size = new Size(200, 40);
            button2.TabIndex = 2;
            button2.Text = "Add Student";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.MouseDownBackColor = Color.Blue;
            button1.FlatAppearance.MouseOverBackColor = Color.Blue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(12, 193);
            button1.Name = "button1";
            button1.Size = new Size(200, 40);
            button1.TabIndex = 1;
            button1.Text = "DashBoard";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(60, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(dashboardForm1);
            panel3.Controls.Add(addStudentForm1);
            panel3.Controls.Add(addTeachersForm1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(224, 25);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 621);
            panel3.TabIndex = 2;
            // 
            // dashboardForm1
            // 
            dashboardForm1.Location = new Point(-1, -4);
            dashboardForm1.Name = "dashboardForm1";
            dashboardForm1.Size = new Size(800, 621);
            dashboardForm1.TabIndex = 2;
            // 
            // addStudentForm1
            // 
            addStudentForm1.Location = new Point(-4, -4);
            addStudentForm1.Name = "addStudentForm1";
            addStudentForm1.Size = new Size(800, 621);
            addStudentForm1.TabIndex = 1;
            // 
            // addTeachersForm1
            // 
            addTeachersForm1.Location = new Point(-1, -4);
            addTeachersForm1.Name = "addTeachersForm1";
            addTeachersForm1.Size = new Size(800, 621);
            addTeachersForm1.TabIndex = 0;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(993, 4);
            label4.Name = "label4";
            label4.Size = new Size(19, 18);
            label4.TabIndex = 1;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1024, 646);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button3;
        private Button button2;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel3;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private AddTeachersForm addTeachersForm1;
        private AddStudentForm addStudentForm1;
        private DashboardForm dashboardForm1;
        private Label label4;
    }
}