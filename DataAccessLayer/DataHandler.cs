using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Project_Milestone2_PRG282.BusinessLayer;
using System.IO;
using System.Windows.Forms;

namespace Project_Milestone2_PRG282.DataAccessLayer
{
    class DataHandler
    {
        //Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=D:\BC\SECONDYEAR\PRG282\PROJECTS\BIN\DEBUG\STUDENTSDB.MDF;Integrated Security=True
        static string Path = $"{ Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName}";
        static string connectionString = $"Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename={Path}\\StudentsDB.mdf;Integrated Security = True";
        SqlConnection sqlConnection;

        List<Student> stud_List = new List<Student>();
        public string insertStudent(string FirstName, string LastName, DateTime DOB, string Phone, string Address, string Gender,byte[] Image)
        {
            sqlConnection = new SqlConnection(connectionString);
            if (sqlConnection.State != ConnectionState.Open)
                sqlConnection.Open();
            string query = $"INSERT INTO Students(FirstName,LastName,DOB,Phone,Address,Gender,StudentImage) " +
            $"SELECT  '{FirstName}','{LastName}','{DOB:yyyy-MM-dd}','{Phone}','{Address}','{Gender}',@Image";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@Image", Image);
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
        public string UpdateStudent(string studNumber,string FirstName, string LastName, DateTime DOB, string Phone, string Address, string Gender, byte[] image)
        {
            sqlConnection = new SqlConnection(connectionString);
            if (sqlConnection.State != ConnectionState.Open)
                sqlConnection.Open();
          
            string query = $"UPDATE Students " +
            $"SET  FirstName = '{FirstName}',LastName = '{LastName}',DOB = '{DOB:yyyy-MM-dd}',Phone ='{Phone}',Address = '{Address}',Gender = '{Gender}', StudentImage = @Image WHERE StudentNo = {studNumber}";
            Clipboard.SetText(query);
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@Image",image);
            try
            {
                int rows = cmd.ExecuteNonQuery();
                if (rows != 0)
                {
                    return "Success";
                }
            }
            catch (Exception error)
            {
                return error.Message;
                return "Update failed";
            }
            return "Update fails";
        }
        public string DeleteModule(string ModuleCode) // Delete
        {
            sqlConnection = new SqlConnection(connectionString);
            try
            {
                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand("sp_DeleteModule", sqlConnection); //changed to use stored procedure which removes all related fields from joining table

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ModuleCode", ModuleCode);
                cmd.ExecuteNonQuery();
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

        public string Delete(int num) // Delete
        {
            sqlConnection = new SqlConnection(connectionString);
            try
            {
                sqlConnection.Open();

               /* string query3 = "DELETE from Students where StudentNo= '" + num + "'";

                SqlCommand command = new SqlCommand(query3, sqlConnection);
                command.ExecuteNonQuery();*/

                SqlCommand cmd = new SqlCommand("sp_deletestud",sqlConnection); //changed to use stored procedure which removes all related fields from joining table

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StudentNo",num);
                cmd.ExecuteNonQuery();
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
            List<Student>  students= new List<Student>();
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
                   
                        students.Add(new Student(reader[0].ToString(),reader[1].ToString(), reader[2].ToString(), reader[4].ToString(), reader[5].ToString() , reader[6].ToString() , Convert.ToDateTime(reader[3]),(byte[])reader[7]));
                    }
                }
            }

            stud_List = students;
            return stud_List;
        }

        public string addStudentModules(int studID,List<string> moduleID)//for adding modules for a student
        {
            try
            {
                using (sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();


                    foreach (var item in moduleID)
                    {
                        string query = string.Format("INSERT INTO StudentModules(StudentNo,ModuleCode) VALUES({0},'{1}')", studID, item);

                        using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                    return "Successful";
                }
            }
            catch (Exception)
            {

                return "Failed";
            }
        }
        public bool UpdateStudentModule(int studID, List<string> moduleID)
        {
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                string SQL = $"DELETE FROM StudentModules WHERE StudentNo = {studID}";
                using (SqlCommand myCom = new SqlCommand(SQL, sqlConnection))
                    myCom.ExecuteNonQuery();
                sqlConnection.Close();
                return (addStudentModules(studID, moduleID) == "Successful");
            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }

        public string addNewModules(string ModCode, string ModName , string ModDescription , string ModLink)//for adding modules for a student
        {
            //if (ModCode.Any(Char.IsWhiteSpace))
            //{

            //}
            


            try
            {
                using (sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    string queryInsertModule = "INSERT INTO Modules(ModuleCode, ModuleName , ModuleDescription , Links) " +
                        "VALUES(" + "'" + ModCode + "' , '" + ModName + "' , '" + ModDescription + "' , '" + ModLink + "')";
                    SqlCommand cmd = new SqlCommand(queryInsertModule, sqlConnection);

                    cmd.ExecuteNonQuery();
                    return "Successfully added new module!";
                }
            }
            catch (Exception)
            {
                return "Failed to insert new module!";
            }
        }

        public List<Module> FilterModules(string StudNum)
        {
            List<Module> module_codes = new List<Module>();
            using (sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                string queryFilter = "SELECT m.ModuleCode FROM Modules as m " +
                                "JOIN StudentModules as s on m.ModuleCode = s.ModuleCode " +
                                "JOIN Students as stud on stud.StudentNo = s.StudentNo " +
                                "WHERE stud.StudentNo = " + "'" +StudNum +"'";

                SqlCommand cmd = new SqlCommand(queryFilter, sqlConnection);


                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        module_codes.Add(new Module(reader[0].ToString()));
                    }
                }

            }
            return module_codes;
        }


        public List<Module> ReadModules()
        {
            try
            {
                List<Module> modules = new List<Module>();
                using (sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    string query = "SELECT * FROM Modules";

                    SqlCommand cmd = new SqlCommand(query, sqlConnection);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            modules.Add(new Module(reader["ModuleCode"].ToString(),reader["ModuleName"].ToString(),reader["ModuleDescription"].ToString(),reader["Links"].ToString()));
                        }
                    }

                }
                return modules;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string Search_Students(string num)
        {
            string Name = null;
            foreach (Student stud in stud_List)
            {
                if (stud.StudNumber == num)
                {
                    Name = stud.StudName;
                }
            }

            return (Name == null) ? "1" : Name;
        }
    }
}
