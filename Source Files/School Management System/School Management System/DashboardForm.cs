using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;



namespace School_Management_System
{
    public partial class DashboardForm : UserControl
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=C:\USERS\DINUSHKA_THARIDU-AS\SOURCE\REPOS\SCHOOL MANAGEMENT SYSTEM\SCHOOL MANAGEMENT SYSTEM\DATABASE\SCHOOL.MDF;Integrated Security=True";
        public DashboardForm()
        {
            InitializeComponent();
            UpdateStudentCount();
        }

        public void UpdateStudentCount()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string countQuery = "SELECT COUNT(*) FROM students";
                    using (SqlCommand command = new SqlCommand(countQuery, connection))
                    {
                        int studentCount = (int)command.ExecuteScalar();
                        label2.Text = studentCount.ToString(); // Update the label text with the student count
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void DashboardForm_Load(object sender, EventArgs e)
        {
            UpdateStudentCount();
        }
    }
}
