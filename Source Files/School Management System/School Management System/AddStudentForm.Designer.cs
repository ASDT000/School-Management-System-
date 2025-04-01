namespace School_Management_System
{
    partial class AddStudentForm


    {

        // AddStudentForm.Designer.cs

        // Add this region at the beginning of the file
        #region Designer generated code

        // Full code provided in the previous message goes here

        #endregion

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
            panel2 = new Panel();
            s_dob = new DateTimePicker();
            label14 = new Label();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            s_PcontactNo = new TextBox();
            label13 = new Label();
            s_Pnic = new TextBox();
            label12 = new Label();
            s_parentName = new TextBox();
            label11 = new Label();
            s_homePhone = new TextBox();
            label10 = new Label();
            s_mobilePhone = new TextBox();
            label9 = new Label();
            s_email = new TextBox();
            label8 = new Label();
            s_grade = new ComboBox();
            label7 = new Label();
            s_address = new TextBox();
            label6 = new Label();
            s_gender = new ComboBox();
            label5 = new Label();
            s_lastName = new TextBox();
            label4 = new Label();
            s_firstName = new TextBox();
            label3 = new Label();
            s_regNO = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            student_studentData = new DataGridView();
            label1 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)student_studentData).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(s_dob);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(s_PcontactNo);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(s_Pnic);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(s_parentName);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(s_homePhone);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(s_mobilePhone);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(s_email);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(s_grade);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(s_address);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(s_gender);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(s_lastName);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(s_firstName);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(s_regNO);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 232);
            panel2.Name = "panel2";
            panel2.Size = new Size(774, 376);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // s_dob
            // 
            s_dob.Location = new Point(110, 288);
            s_dob.Name = "s_dob";
            s_dob.Size = new Size(145, 23);
            s_dob.TabIndex = 30;
            s_dob.Value = new DateTime(2024, 3, 24, 0, 0, 0, 0);
            s_dob.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(23, 293);
            label14.Name = "label14";
            label14.Size = new Size(81, 15);
            label14.TabIndex = 28;
            label14.Text = "Date Of Birth :";
            // 
            // button3
            // 
            button3.BackColor = Color.DodgerBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 192);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(539, 327);
            button3.Name = "button3";
            button3.Size = new Size(100, 30);
            button3.TabIndex = 27;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DodgerBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 192);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(420, 327);
            button4.Name = "button4";
            button4.Size = new Size(100, 30);
            button4.TabIndex = 26;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.DodgerBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 192);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(300, 327);
            button2.Name = "button2";
            button2.Size = new Size(100, 30);
            button2.TabIndex = 25;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 192);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(181, 327);
            button1.Name = "button1";
            button1.Size = new Size(100, 30);
            button1.TabIndex = 24;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // s_PcontactNo
            // 
            s_PcontactNo.Location = new Point(362, 209);
            s_PcontactNo.Name = "s_PcontactNo";
            s_PcontactNo.Size = new Size(145, 23);
            s_PcontactNo.TabIndex = 23;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(280, 212);
            label13.Name = "label13";
            label13.Size = new Size(76, 15);
            label13.TabIndex = 22;
            label13.Text = "Contact NO :";
            // 
            // s_Pnic
            // 
            s_Pnic.Location = new Point(362, 167);
            s_Pnic.Name = "s_Pnic";
            s_Pnic.Size = new Size(145, 23);
            s_Pnic.TabIndex = 21;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(302, 170);
            label12.Name = "label12";
            label12.Size = new Size(54, 15);
            label12.TabIndex = 20;
            label12.Text = "NIC NO :";
            // 
            // s_parentName
            // 
            s_parentName.Location = new Point(362, 131);
            s_parentName.Name = "s_parentName";
            s_parentName.Size = new Size(145, 23);
            s_parentName.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(274, 134);
            label11.Name = "label11";
            label11.Size = new Size(82, 15);
            label11.TabIndex = 18;
            label11.Text = "Parent Name :";
            // 
            // s_homePhone
            // 
            s_homePhone.Location = new Point(362, 245);
            s_homePhone.Name = "s_homePhone";
            s_homePhone.Size = new Size(145, 23);
            s_homePhone.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(274, 248);
            label10.Name = "label10";
            label10.Size = new Size(83, 15);
            label10.TabIndex = 16;
            label10.Text = "Home TP NO :";
            // 
            // s_mobilePhone
            // 
            s_mobilePhone.Location = new Point(110, 212);
            s_mobilePhone.Name = "s_mobilePhone";
            s_mobilePhone.Size = new Size(145, 23);
            s_mobilePhone.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 215);
            label9.Name = "label9";
            label9.Size = new Size(87, 15);
            label9.TabIndex = 14;
            label9.Text = "Mobile Phone :";
            // 
            // s_email
            // 
            s_email.Location = new Point(110, 174);
            s_email.Name = "s_email";
            s_email.Size = new Size(145, 23);
            s_email.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(62, 177);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 12;
            label8.Text = "Email :";
            // 
            // s_grade
            // 
            s_grade.FormattingEnabled = true;
            s_grade.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13" });
            s_grade.Location = new Point(110, 250);
            s_grade.Name = "s_grade";
            s_grade.Size = new Size(145, 23);
            s_grade.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(53, 253);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 10;
            label7.Text = "Grade :";
            // 
            // s_address
            // 
            s_address.Location = new Point(362, 13);
            s_address.Multiline = true;
            s_address.Name = "s_address";
            s_address.Size = new Size(150, 101);
            s_address.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(296, 18);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 8;
            label6.Text = "Address :";
            // 
            // s_gender
            // 
            s_gender.FormattingEnabled = true;
            s_gender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            s_gender.Location = new Point(110, 136);
            s_gender.Name = "s_gender";
            s_gender.Size = new Size(145, 23);
            s_gender.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 139);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 6;
            label5.Text = "Gender :";
            // 
            // s_lastName
            // 
            s_lastName.Location = new Point(110, 96);
            s_lastName.Name = "s_lastName";
            s_lastName.Size = new Size(145, 23);
            s_lastName.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 99);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 4;
            label4.Text = "Last Name :";
            // 
            // s_firstName
            // 
            s_firstName.Location = new Point(110, 54);
            s_firstName.Name = "s_firstName";
            s_firstName.Size = new Size(145, 23);
            s_firstName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 57);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 2;
            label3.Text = "First Name :";
            // 
            // s_regNO
            // 
            s_regNO.Location = new Point(110, 13);
            s_regNO.Name = "s_regNO";
            s_regNO.Size = new Size(102, 23);
            s_regNO.TabIndex = 1;
            s_regNO.TextChanged += s_regNO_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 16);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 0;
            label2.Text = "Registration No :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(student_studentData);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(774, 214);
            panel1.TabIndex = 2;
            // 
            // student_studentData
            // 
            student_studentData.AllowUserToAddRows = false;
            student_studentData.AllowUserToDeleteRows = false;
            student_studentData.BackgroundColor = Color.Silver;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            student_studentData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            student_studentData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            student_studentData.EnableHeadersVisualStyles = false;
            student_studentData.Location = new Point(12, 32);
            student_studentData.Name = "student_studentData";
            student_studentData.ReadOnly = true;
            student_studentData.RowHeadersVisible = false;
            student_studentData.Size = new Size(747, 167);
            student_studentData.TabIndex = 1;
            student_studentData.CellClick += student_studentData_CellClick;
            student_studentData.CellContentClick += student_studentData_CellClick;
            student_studentData.VisibleChanged += dateTimePicker1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 0;
            label1.Text = "Student Data";
            // 
            // AddStudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AddStudentForm";
            Size = new Size(800, 621);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)student_studentData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button button3;
        private Button button4;
        private Button button2;
        private Button button1;
        private TextBox s_PcontactNo;
        private Label label13;
        private TextBox s_Pnic;
        private Label label12;
        private TextBox s_parentName;
        private Label label11;
        private TextBox s_homePhone;
        private Label label10;
        private TextBox s_mobilePhone;
        private Label label9;
        private TextBox s_email;
        private Label label8;
        private ComboBox s_grade;
        private Label label7;
        private TextBox s_address;
        private Label label6;
        private ComboBox s_gender;
        private Label label5;
        private TextBox s_lastName;
        private Label label4;
        private TextBox s_firstName;
        private Label label3;
        private TextBox s_regNO;
        private Label label2;
        private Panel panel1;
        private DataGridView student_studentData;
        private Label label1;
        private Label label14;
        private DateTimePicker s_dob;
    }
}

