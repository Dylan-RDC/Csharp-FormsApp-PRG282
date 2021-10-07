﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Project_Milestone2_PRG282.BusinessLayer;

namespace Project_Milestone2_PRG282.DataAccessLayer
{
    class DataHandler
    {
        static string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|StudentsDB.mdf;Integrated Security = True";
        SqlConnection sqlConnection;

        List<Student> stud_List = new List<Student>();

        public string Delete(int num) // Delete
        {
            sqlConnection = new SqlConnection(connectionString);


            try
            {
                sqlConnection.Open();

                string query3 = "delete from Students where StudentId= '" + num + "'";

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

                        stud_List.Add(new Student(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[4].ToString(), reader[5].ToString() , reader[5].ToString() , Convert.ToDateTime(reader[3])));
                    }
                }
            }

            return stud_List;
        }
    }
}