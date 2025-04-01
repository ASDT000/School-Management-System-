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
using System.IO;
using System.Text.Json;

namespace School_Management_System
{
    public partial class AddTeachersForm : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DINUSHKA_THARIDU-AS\Documents\School.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");
        public AddTeachersForm()
        {
            InitializeComponent();
            teacherDisplayData();
        }
        private string imagePath;

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.jpg; *.png)|*.jpg;*.png";

            if (open.ShowDialog() == DialogResult.OK)
            {
                imagePath = open.FileName;

                teacher_image.ImageLocation = imagePath;
            }
        }
        public void teacherDisplayData()
        {
            AddTeachersData addTD = new AddTeachersData();

            teacher_gridData.DataSource = addTD.teacherData();
        }
        private void teacher_AddBtn_Click(object sender, EventArgs e)
        {
            if (teacher_id.Text == ""
                || teacher_name.Text == ""
                || teacher_nic.Text == ""
                || teacher_address.Text == ""
                || teacher_email.Text == ""
                || teacher_gender.Text == ""
                || teacher_phone.Text == ""
                || teacher_image == null
                || imagePath == null)
            {
                MessageBox.Show("Please Fill All the Blank Field", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        // Stop Duplicating data

                        String checkTeacherID = "SELECT COUNT(*) FROM teachers WHERE teacher_id=@teacherID";
                        using (SqlCommand checkTID = new SqlCommand(checkTeacherID, connect))
                        {
                            checkTID.Parameters.AddWithValue("@teacherID", teacher_id.Text.Trim());
                            int count = (int)checkTID.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show("teacher ID:  " + teacher_id.Text.Trim() + " is Already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO teachers " +
                            "(teacher_id,teacher_name,teacher_gender,teacher_address," +
                            "teacher_nic,teacher_email,teacher_image,teacher_phone,date_insert,)" +
                            "VALUES(@teacherID, @teacherName, @teacherGender, @teacherAddress," +
                            "@teacherNIC, @teacherEmail,@teacherImage,@teacherPhone, @dateInsert)";

                                // TO SAVE TO YOUR DIRECTORY
                                string path = Path.Combine(@"C:\Users\DINUSHKA_THARIDU-AS\source\repos\School Management System\School Management System\Teacher_Directory\", teacher_id.Text.Trim() + ".jpg");

                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(imagePath, path, true);



                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@teacherID", teacher_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacher_name", teacher_name.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacher_gender", teacher_gender.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacher_address", teacher_address.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacher_nic", teacher_nic.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacher_email", teacher_email.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacher_image", path);
                                    cmd.Parameters.AddWithValue("@teacher_phone", teacher_phone.Text.Trim());
                                    cmd.Parameters.AddWithValue("@dateInsert", today.ToString());

                                    cmd.ExecuteNonQuery();

                                    teacherDisplayData();

                                    MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearFields();


                                }


                            }

                        }



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Connecting Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }


        }
        public void clearFields()
        {
            teacher_id.Text = "";
            teacher_name.Text = "";
            teacher_gender.SelectedIndex = -1;
            teacher_address.Text = "";
            teacher_image.Image = null;
            teacher_phone.Text = "";
            teacher_email.Text = "";
            imagePath = "";
        }


        private void teacher_gridData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void teacher_UpdateBtn_Click(object sender, EventArgs e)
        {

        }

        private void teacher_ClearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void teacher_gridData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = teacher_gridData.Rows[e.RowIndex];
                teacher_id.Text = row.Cells[1].Value.ToString();
                teacher_name.Text = row.Cells[2].Value.ToString();
                teacher_gender.Text = row.Cells[3].Value.ToString();
                teacher_address.Text = row.Cells[4].Value.ToString();
                teacher_email.Text = row.Cells[5].Value.ToString();
                teacher_phone.Text = row.Cells[6].Value.ToString();
                teacher_nic.Text = row.Cells[7].Value.ToString();


                imagePath = row.Cells[8].Value.ToString();

                string imageData = row.Cells[5].Value.ToString();

                if (imageData != null && imageData.Length > 0)
                {
                    teacher_image.Image = Image.FromFile(imageData);
                }
                else
                {
                    teacher_image.Image = null;
                }



            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
