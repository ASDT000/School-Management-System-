using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
namespace School_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textUsername.Text == "Admin" && textpassword.Text == "Skills@123")
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login credentials, Please check Username And Password and Try again.");
                textUsername.Clear();
                textpassword.Clear();
                textUsername.Focus();


            }


        }

        private void label2_Click(object sender, EventArgs e)
        {
            textUsername.Clear();
            textpassword.Clear();
            textUsername.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                // Close the application
                Application.Exit();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textpassword.PasswordChar = '\0';
            }
            else
            {
                textpassword.PasswordChar = '*';
            }
        }
    }
}
