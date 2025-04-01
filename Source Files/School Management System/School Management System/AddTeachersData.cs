using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using Microsoft.Data.SqlClient;


namespace School_Management_System
{
    internal class AddTeachersData
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DINUSHKA_THARIDU-AS\Documents\School.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");
        public int ID { set; get; }
        public string TeacherID { set; get; }
        public string TeacherName { set; get; }
        public string TeacherGender{ set; get; }
        public string TeacherAddress{ set; get; }
        public string TeacherImage { set; get;}
        public string TeacherPhone { set; get; }
        public string TeacherEmail { set; get; }
        public string TeacherNIC { set; get; }
        public string DateInsert { set; get; }



        public List<AddTeachersData> teacherData()
        {
            List<AddTeachersData> listData = new List<AddTeachersData>();
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string sql = "SELECT * FROM teachers WHERE data_delete IS NULL";
                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            AddTeachersData addTD=new AddTeachersData();
                            addTD.ID = (int)reader["id"];
                            addTD.TeacherID = reader["teacher_id"].ToString();
                            addTD.TeacherName = reader["teacher_name"].ToString();
                            addTD.TeacherGender = reader["teacher_gender"].ToString();
                            addTD.TeacherAddress = reader["teacher_address"].ToString();
                            addTD.TeacherEmail = reader["teacher_email"].ToString();
                            addTD.TeacherPhone = reader["teacher_phone"].ToString();
                            addTD.TeacherNIC = reader["teacher_nic"].ToString();
                            addTD.DateInsert = reader["date_insert"].ToString();
                            addTD.TeacherImage= reader["teacher_image"].ToString();

                            listData.Add(addTD);
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error Connecting Database: " + ex);
                }
                finally 
                { 
                    connect.Close();
                }
            }
            return listData;
        }
    }
}
