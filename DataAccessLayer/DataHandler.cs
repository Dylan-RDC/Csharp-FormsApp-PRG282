using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Project_Milestone2_PRG282.BusinessLayer;
using System.IO;

namespace Project_Milestone2_PRG282.DataAccessLayer
{
    class DataHandler
    {
        //Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=D:\BC\SECONDYEAR\PRG282\PROJECTS\BIN\DEBUG\STUDENTSDB.MDF;Integrated Security=True
        static string Path = $"{ Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName}";
        static string connectionString = $"Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename={Path}\\StudentsDB.mdf;Integrated Security = True";
        SqlConnection sqlConnection;

        List<Student> stud_List = new List<Student>();
        public string insertStudent(string FirstName, string LastName, DateTime DOB, string Phone, string Address, string Gender,string StudentImagePath)
        {
            sqlConnection = new SqlConnection(connectionString);
            if (sqlConnection.State != ConnectionState.Open)
                sqlConnection.Open();
            string query = $"INSERT INTO Students(FirstName,LastName,DOB,Phone,Address,Gender,StudentImage) " +
            $"SELECT  '{FirstName}','{LastName}','{DOB}','{Phone}','{Address}','{Gender}',StudentImage FROM OPENROWSET(BULK N'{StudentImagePath}', SINGLE_BLOB)AS ImageSource(StudentImage)";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            try
            {
                int rows = cmd.ExecuteNonQuery();
                if(rows != 0)
                {
                    return "Success";
                }
            }
            catch (Exception)
            {

                return "Insert failed";
            }
            return "Insert failed";
        }
        public string Delete(int num) // Delete
        {
            sqlConnection = new SqlConnection(connectionString);
            try
            {
                sqlConnection.Open();

                string query3 = "DELETE from Students where StudentNo= '" + num + "'";

                SqlCommand command = new SqlCommand(query3, sqlConnection);
                command.ExecuteNonQuery();
            }

            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
            return "Successfully Deleted";
        }

        public List<Student> getStudent()
        {
            Student student = new Student();
            sqlConnection = new SqlConnection(connectionString);
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
                string qyery1 = "Select * from Students";

                SqlCommand cmd = new SqlCommand(qyery1, sqlConnection);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        stud_List.Add(new Student(reader[0].ToString(),reader[1].ToString(), reader[2].ToString(), reader[4].ToString(), reader[5].ToString() , reader[5].ToString() , Convert.ToDateTime(reader[3]),reader[6].ToString()));
                    }
                }
            }

            return stud_List;
        }
    }
}
