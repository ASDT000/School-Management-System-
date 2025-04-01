using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace School_Management_System
{
    class AddStudentData
    {
        private readonly SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=""C:\USERS\DINUSHKA_THARIDU-AS\SOURCE\REPOS\SCHOOL MANAGEMENT SYSTEM\SCHOOL MANAGEMENT SYSTEM\DATABASE\SCHOOL.MDF"";Integrated Security=True");

        public string? StudentRg { get; set; }
        public string? StudentFName { get; set; }
        public string? StudentLName { get; set; }
        public string? StudentGender { get; set; }
        public string? StudentAddress { get; set; }
        public string? StudentDOB { get; set; }
        public string? StudentEmail { get; set; }
        public string? StudentPhone { get; set; }
        public string? StudentHPhone { get; set; }
        public string? StudentPName { get; set; }
        public string? StudentPNic { get; set; }
        public string? StudentPContactno { get; set; }
        public DateTime? DateInsert { get; set; }

        public List<AddStudentData> StudentData()
        {
            List<AddStudentData> listData = new List<AddStudentData>();

            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }

                DateTime today = DateTime.Today;
                string sql = "SELECT * FROM students WHERE date_insert = @dateInsert AND date_delete IS NULL";

                using (SqlCommand cmd = new SqlCommand(sql, connect))
                {
                    cmd.Parameters.AddWithValue("@dateInsert", today);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        AddStudentData addSD = new AddStudentData();

                        string? dateString = reader["date_insert"]?.ToString();
                        if (dateString != null)
                        {
                            try
                            {
                                addSD.DateInsert = DateTime.Parse(dateString, CultureInfo.InvariantCulture);
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Failed to parse date format: " + dateString);
                                // Log the error or handle it differently (e.g., set a default value)
                            }
                        }

                        addSD.StudentRg = reader["s_regNO"]?.ToString();
                        addSD.StudentFName = reader["s_firstName"]?.ToString();

                        listData.Add(addSD);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }

            return listData;
        }

    }
}