using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are You Sure You Want To LogOut?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                // Close the application
                new Form1().Show();
                this.Hide();

            }

        }

        private void dashboardForm1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = true;
            addStudentForm1.Visible = false;
            addTeachersForm1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            addStudentForm1.Visible = true;
            addTeachersForm1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            addStudentForm1.Visible = false;
            addTeachersForm1.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

            DialogResult check = MessageBox.Show("Are You Sure You Want To Exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                // Close the application
                Application.Exit();
            }

        }
    }
}
