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
    public partial class AddStudentsForm : Form
    {
        public AddStudentsForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void displayStudentData()
        {
            AddStudentData adData = new AddStudentData();

            // Call the correct method StudentData() instead of studentData()
            student_studentData.DataSource = adData.StudentData();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
