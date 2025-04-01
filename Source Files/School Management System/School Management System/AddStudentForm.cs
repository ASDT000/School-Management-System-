using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class AddStudentForm : UserControl
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=C:\USERS\DINUSHKA_THARIDU-AS\SOURCE\REPOS\SCHOOL MANAGEMENT SYSTEM\SCHOOL MANAGEMENT SYSTEM\DATABASE\SCHOOL.MDF;Integrated Security=True";

        public AddStudentForm()
        {
            InitializeComponent();
            DisplayStudentData();
        }

        public void DisplayStudentData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM students";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        student_studentData.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(s_regNO.Text) || string.IsNullOrWhiteSpace(s_firstName.Text) || string.IsNullOrWhiteSpace(s_lastName.Text) || string.IsNullOrWhiteSpace(s_gender.Text) || string.IsNullOrWhiteSpace(s_email.Text) || string.IsNullOrWhiteSpace(s_mobilePhone.Text) || string.IsNullOrWhiteSpace(s_grade.Text) || string.IsNullOrWhiteSpace(s_address.Text) || string.IsNullOrWhiteSpace(s_parentName.Text) || string.IsNullOrWhiteSpace(s_Pnic.Text) || string.IsNullOrWhiteSpace(s_PcontactNo.Text) || string.IsNullOrWhiteSpace(s_homePhone.Text))
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string checkStudentID = "SELECT COUNT(*) FROM students WHERE s_regNO = @studentRg";
                        using (SqlCommand command = new SqlCommand(checkStudentID, connection))
                        {
                            command.Parameters.AddWithValue("@studentRg", s_regNO.Text.Trim());
                            int count = (int)command.ExecuteScalar();
                            if (count >= 1)
                            {
                                MessageBox.Show("Student with ID " + s_regNO.Text.Trim() + " already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO students (s_regNO, s_firstName, s_lastName, s_gender, s_address, s_email, s_mobilePhone, s_dob, s_homePhone, s_parentName, s_Pnic, s_PcontactNo, s_date_insert) VALUES (@studentRg, @studentFName, @studentLName, @studentGender, @studentAddress, @studentEmail, @studentPhone, @studentDOB, @studentHPhone, @studentPName, @studentPNic, @studentPContactno, @dateInsert)";
                                using (SqlCommand cmd = new SqlCommand(insertData, connection))
                                {
                                    cmd.Parameters.AddWithValue("@studentRg", s_regNO.Text.Trim());
                                    cmd.Parameters.AddWithValue("@studentFName", s_firstName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@studentLName", s_lastName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@studentGender", s_gender.Text.Trim());
                                    cmd.Parameters.AddWithValue("@studentAddress", s_address.Text.Trim());
                                    cmd.Parameters.AddWithValue("@studentEmail", s_email.Text.Trim());
                                    cmd.Parameters.AddWithValue("@studentPhone", s_mobilePhone.Text.Trim());
                                    cmd.Parameters.AddWithValue("@studentDOB", s_dob.Value);
                                    cmd.Parameters.AddWithValue("@studentHPhone", s_homePhone.Text.Trim());
                                    cmd.Parameters.AddWithValue("@studentPName", s_parentName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@studentPNic", s_Pnic.Text.Trim());
                                    cmd.Parameters.AddWithValue("@studentPContactno", s_PcontactNo.Text.Trim());
                                    cmd.Parameters.AddWithValue("@dateInsert", today);
                                    cmd.ExecuteNonQuery();
                                    DisplayStudentData();
                                    MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ClearFields();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearFields()
        {
            // Clear all textboxes
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
            }
        }

        private void student_studentData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Your existing code for populating textboxes with selected row data
            // Check if the clicked cell is not the header row
            if (e.RowIndex != -1)
            {
                // Get the selected row
                DataGridViewRow row = student_studentData.Rows[e.RowIndex];

                // Populate the text boxes and input boxes with the data from the selected row
                s_regNO.Text = row.Cells["s_regNO"].Value.ToString();
                s_firstName.Text = row.Cells["s_firstName"].Value.ToString();
                s_lastName.Text = row.Cells["s_lastName"].Value.ToString();
                s_gender.Text = row.Cells["s_gender"].Value.ToString();
                s_address.Text = row.Cells["s_address"].Value.ToString();
                s_dob.Value = Convert.ToDateTime(row.Cells["s_dob"].Value);
                s_email.Text = row.Cells["s_email"].Value.ToString();
                s_mobilePhone.Text = row.Cells["s_mobilePhone"].Value.ToString();
                s_homePhone.Text = row.Cells["s_homePhone"].Value.ToString();
                s_parentName.Text = row.Cells["s_parentName"].Value.ToString();
                s_Pnic.Text = row.Cells["s_Pnic"].Value.ToString();
                s_PcontactNo.Text = row.Cells["s_PcontactNo"].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Your existing code for updating a student record
            try
            {
                // Establish connection to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Define the SQL UPDATE query
                    string updateQuery = @"
                UPDATE students 
                SET 
                    s_firstName = @studentFName, 
                    s_lastName = @studentLName, 
                    s_gender = @studentGender, 
                    s_address = @studentAddress, 
                    s_email = @studentEmail, 
                    s_mobilePhone = @studentPhone, 
                    s_dob = @studentDOB, 
                    s_homePhone = @studentHPhone, 
                    s_parentName = @studentPName, 
                    s_Pnic = @studentPNic, 
                    s_PcontactNo = @studentPContactno 
                WHERE 
                    s_regNO = @studentRg";

                    // Create a command object
                    using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                    {
                        // Set parameter values with the modified data
                        cmd.Parameters.AddWithValue("@studentFName", s_firstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@studentLName", s_lastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@studentGender", s_gender.Text.Trim());
                        cmd.Parameters.AddWithValue("@studentAddress", s_address.Text.Trim());
                        cmd.Parameters.AddWithValue("@studentEmail", s_email.Text.Trim());
                        cmd.Parameters.AddWithValue("@studentPhone", s_mobilePhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@studentDOB", s_dob.Value);
                        cmd.Parameters.AddWithValue("@studentHPhone", s_homePhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@studentPName", s_parentName.Text.Trim());
                        cmd.Parameters.AddWithValue("@studentPNic", s_Pnic.Text.Trim());
                        cmd.Parameters.AddWithValue("@studentPContactno", s_PcontactNo.Text.Trim());
                        cmd.Parameters.AddWithValue("@studentRg", s_regNO.Text.Trim());

                        // Execute the UPDATE query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Check if any rows were affected
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Refresh the DataGridView to reflect the changes
                            DisplayStudentData();

                            // Clear the input fields
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("No record found with the provided Registration No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
            // Your existing painting logic here
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Your existing handling logic here
        }


        private void button4_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void s_regNO_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            // Call the ClearFields method to clear all input fields
            s_regNO.Text = "";
            s_firstName.Text = "";
            s_lastName.Text = "";
            s_gender.Text = "";
            s_email.Text = "";
            s_mobilePhone.Text = "";
            s_grade.Text = "";
            s_address.Text = "";
            s_parentName.Text = "";
            s_Pnic.Text = "";
            s_PcontactNo.Text = "";
            s_homePhone.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Check if any cell is selected
            if (student_studentData.SelectedCells.Count > 0)
            {
                // Ask for confirmation
                DialogResult result = MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Get the ID of the selected record
                    int selectedRowIndex = student_studentData.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = student_studentData.Rows[selectedRowIndex];
                    string studentRg = selectedRow.Cells["s_regNO"].Value.ToString(); // Assuming 's_regNO' is the name of the primary key column

                    try
                    {
                        // Delete the record from the database
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            string deleteQuery = "DELETE FROM students WHERE s_regNO = @studentRg";
                            using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                            {
                                cmd.Parameters.AddWithValue("@studentRg", studentRg);
                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    // Refresh the DataGridView
                                    DisplayStudentData();
                                }
                                else
                                {
                                    MessageBox.Show("No record found with the provided Registration No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a record to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}