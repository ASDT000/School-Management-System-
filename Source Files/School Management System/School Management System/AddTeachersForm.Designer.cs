namespace School_Management_System
{
    partial class AddTeachersForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel2 = new Panel();
            teacher_nic = new TextBox();
            teacher_phone = new TextBox();
            button5 = new Button();
            panel3 = new Panel();
            teacher_image = new PictureBox();
            teacher_DeleteBtn = new Button();
            teacher_ClearBtn = new Button();
            teacher_UpdateBtn = new Button();
            teacher_AddBtn = new Button();
            label12 = new Label();
            label9 = new Label();
            teacher_email = new TextBox();
            label8 = new Label();
            teacher_address = new TextBox();
            label6 = new Label();
            teacher_gender = new ComboBox();
            label5 = new Label();
            teacher_name = new TextBox();
            label3 = new Label();
            teacher_id = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            teacher_gridData = new DataGridView();
            label1 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)teacher_image).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)teacher_gridData).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(teacher_nic);
            panel2.Controls.Add(teacher_phone);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(teacher_DeleteBtn);
            panel2.Controls.Add(teacher_ClearBtn);
            panel2.Controls.Add(teacher_UpdateBtn);
            panel2.Controls.Add(teacher_AddBtn);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(teacher_email);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(teacher_address);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(teacher_gender);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(teacher_name);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(teacher_id);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 244);
            panel2.Name = "panel2";
            panel2.Size = new Size(772, 359);
            panel2.TabIndex = 3;
            // 
            // teacher_nic
            // 
            teacher_nic.Location = new Point(407, 139);
            teacher_nic.Name = "teacher_nic";
            teacher_nic.Size = new Size(145, 23);
            teacher_nic.TabIndex = 31;
            // 
            // teacher_phone
            // 
            teacher_phone.Location = new Point(110, 175);
            teacher_phone.Name = "teacher_phone";
            teacher_phone.Size = new Size(145, 23);
            teacher_phone.TabIndex = 30;
            // 
            // button5
            // 
            button5.BackColor = Color.DodgerBlue;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.Blue;
            button5.FlatAppearance.MouseOverBackColor = Color.Blue;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(666, 123);
            button5.Name = "button5";
            button5.Size = new Size(87, 30);
            button5.TabIndex = 29;
            button5.Text = "Insert";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(teacher_image);
            panel3.Location = new Point(666, 21);
            panel3.Name = "panel3";
            panel3.Size = new Size(87, 101);
            panel3.TabIndex = 28;
            // 
            // teacher_image
            // 
            teacher_image.BackColor = Color.DarkGray;
            teacher_image.Location = new Point(0, 0);
            teacher_image.Name = "teacher_image";
            teacher_image.Size = new Size(87, 101);
            teacher_image.SizeMode = PictureBoxSizeMode.StretchImage;
            teacher_image.TabIndex = 30;
            teacher_image.TabStop = false;
            // 
            // teacher_DeleteBtn
            // 
            teacher_DeleteBtn.BackColor = Color.DodgerBlue;
            teacher_DeleteBtn.FlatAppearance.BorderSize = 0;
            teacher_DeleteBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 192);
            teacher_DeleteBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            teacher_DeleteBtn.FlatStyle = FlatStyle.Flat;
            teacher_DeleteBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teacher_DeleteBtn.ForeColor = Color.White;
            teacher_DeleteBtn.Location = new Point(534, 310);
            teacher_DeleteBtn.Name = "teacher_DeleteBtn";
            teacher_DeleteBtn.Size = new Size(100, 30);
            teacher_DeleteBtn.TabIndex = 27;
            teacher_DeleteBtn.Text = "Delete";
            teacher_DeleteBtn.UseVisualStyleBackColor = false;
            // 
            // teacher_ClearBtn
            // 
            teacher_ClearBtn.BackColor = Color.DodgerBlue;
            teacher_ClearBtn.FlatAppearance.BorderSize = 0;
            teacher_ClearBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 192);
            teacher_ClearBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            teacher_ClearBtn.FlatStyle = FlatStyle.Flat;
            teacher_ClearBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teacher_ClearBtn.ForeColor = Color.White;
            teacher_ClearBtn.Location = new Point(415, 310);
            teacher_ClearBtn.Name = "teacher_ClearBtn";
            teacher_ClearBtn.Size = new Size(100, 30);
            teacher_ClearBtn.TabIndex = 26;
            teacher_ClearBtn.Text = "Clear";
            teacher_ClearBtn.UseVisualStyleBackColor = false;
            teacher_ClearBtn.Click += teacher_ClearBtn_Click;
            // 
            // teacher_UpdateBtn
            // 
            teacher_UpdateBtn.BackColor = Color.DodgerBlue;
            teacher_UpdateBtn.FlatAppearance.BorderSize = 0;
            teacher_UpdateBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 192);
            teacher_UpdateBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            teacher_UpdateBtn.FlatStyle = FlatStyle.Flat;
            teacher_UpdateBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teacher_UpdateBtn.ForeColor = Color.White;
            teacher_UpdateBtn.Location = new Point(295, 310);
            teacher_UpdateBtn.Name = "teacher_UpdateBtn";
            teacher_UpdateBtn.Size = new Size(100, 30);
            teacher_UpdateBtn.TabIndex = 25;
            teacher_UpdateBtn.Text = "Update";
            teacher_UpdateBtn.UseVisualStyleBackColor = false;
            teacher_UpdateBtn.Click += teacher_UpdateBtn_Click;
            // 
            // teacher_AddBtn
            // 
            teacher_AddBtn.BackColor = Color.DodgerBlue;
            teacher_AddBtn.FlatAppearance.BorderSize = 0;
            teacher_AddBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 192);
            teacher_AddBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            teacher_AddBtn.FlatStyle = FlatStyle.Flat;
            teacher_AddBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teacher_AddBtn.ForeColor = Color.White;
            teacher_AddBtn.Location = new Point(176, 310);
            teacher_AddBtn.Name = "teacher_AddBtn";
            teacher_AddBtn.Size = new Size(100, 30);
            teacher_AddBtn.TabIndex = 24;
            teacher_AddBtn.Text = "Add";
            teacher_AddBtn.UseVisualStyleBackColor = false;
            teacher_AddBtn.Click += teacher_AddBtn_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(347, 142);
            label12.Name = "label12";
            label12.Size = new Size(54, 15);
            label12.TabIndex = 20;
            label12.Text = "NIC NO :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 178);
            label9.Name = "label9";
            label9.Size = new Size(87, 15);
            label9.TabIndex = 14;
            label9.Text = "Mobile Phone :";
            // 
            // teacher_email
            // 
            teacher_email.Location = new Point(110, 137);
            teacher_email.Name = "teacher_email";
            teacher_email.Size = new Size(145, 23);
            teacher_email.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(62, 140);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 12;
            label8.Text = "Email :";
            // 
            // teacher_address
            // 
            teacher_address.Location = new Point(407, 21);
            teacher_address.Multiline = true;
            teacher_address.Name = "teacher_address";
            teacher_address.Size = new Size(150, 101);
            teacher_address.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(346, 26);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 8;
            label6.Text = "Address :";
            // 
            // teacher_gender
            // 
            teacher_gender.FormattingEnabled = true;
            teacher_gender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            teacher_gender.Location = new Point(110, 99);
            teacher_gender.Name = "teacher_gender";
            teacher_gender.Size = new Size(145, 23);
            teacher_gender.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 102);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 6;
            label5.Text = "Gender :";
            // 
            // teacher_name
            // 
            teacher_name.Location = new Point(110, 60);
            teacher_name.Name = "teacher_name";
            teacher_name.Size = new Size(214, 23);
            teacher_name.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 63);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "Full Name :";
            // 
            // teacher_id
            // 
            teacher_id.Location = new Point(110, 19);
            teacher_id.Name = "teacher_id";
            teacher_id.Size = new Size(102, 23);
            teacher_id.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 24);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 0;
            label2.Text = "Teacher ID :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(teacher_gridData);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(772, 226);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // teacher_gridData
            // 
            teacher_gridData.AllowUserToAddRows = false;
            teacher_gridData.AllowUserToDeleteRows = false;
            teacher_gridData.AllowUserToResizeColumns = false;
            teacher_gridData.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(5, 0, 5, 0);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            teacher_gridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            teacher_gridData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            teacher_gridData.EnableHeadersVisualStyles = false;
            teacher_gridData.Location = new Point(12, 32);
            teacher_gridData.Name = "teacher_gridData";
            teacher_gridData.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            teacher_gridData.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            teacher_gridData.RowHeadersVisible = false;
            teacher_gridData.Size = new Size(741, 179);
            teacher_gridData.TabIndex = 1;
            teacher_gridData.CellClick += teacher_gridData_CellClick;
            teacher_gridData.CellContentClick += teacher_gridData_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 0;
            label1.Text = "Teacher's Data";
            // 
            // AddTeachersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AddTeachersForm";
            Size = new Size(800, 621);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)teacher_image).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)teacher_gridData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button teacher_DeleteBtn;
        private Button teacher_ClearBtn;
        private Button teacher_UpdateBtn;
        private Button teacher_AddBtn;
        private TextBox textBox9;
        private Label label12;
        private TextBox textBox7;
        private Label label10;
        private TextBox textBox6;
        private Label label9;
        private TextBox teacher_email;
        private Label label8;
        private TextBox teacher_address;
        private Label label6;
        private ComboBox teacher_gender;
        private Label label5;
        private TextBox teacher_name;
        private Label label3;
        private TextBox teacher_id;
        private Label label2;
        private Panel panel1;
        private DataGridView teacher_gridData;
        private Label label1;
        private Button button5;
        private Panel panel3;
        private PictureBox teacher_image;
        private TextBox teacher_nic;
        private TextBox teacher_phone;
    }
}
