using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Milestone2_PRG282.DataAccessLayer;

namespace Project_Milestone2_PRG282.BusinessLayer
{
    class FileMethods
    {

        public List<User> Read()
        {
            return new FileHandler().Read_Users();

        }

        DataHandler dh = new DataHandler();

        public string ValidateLoginInputs(string username,string password)//validate log in attempt info
        {
            try
            {
                if (username == "" || password == "")
                {
                    throw new Exception("Please ensure both password and username are entered");
                }
                if (username.Any(Char.IsWhiteSpace))
                {
                    throw new Exception("Username cannot contain spaces");
                }
                if (username.Any(Char.IsPunctuation))
                {
                    throw new Exception("Username can only contain numbers and letters");
                }
                return "G";

                

            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string ValidateNewLogin(string username, string password)//validate new user info
        {
            FileHandler fh = new FileHandler();

            try
            {
                if (username == "" || password == "")
                {
                    throw new Exception("Please ensure both password and username are entered");
                }
                if (username.Length<3)
                {
                    throw new Exception("Username must be more than 3 characters long");
                }
                if (username.Any(Char.IsWhiteSpace))
                {
                    throw new Exception("Username cannot contain spaces");
                }
                if (username.Any(Char.IsPunctuation))
                {
                    throw new Exception("Username can only contain numbers and letters");
                }

                if (password.Any(Char.IsWhiteSpace))
                {
                    throw new Exception("Password cannot contain spaces");
                }

                if (password.Length < 13)
                {
                    throw new Exception("Password must be atleast 13 characters long");
                }
                if (password.Contains('#'))
                {
                    throw new Exception("Password cannot contain a '#'");
                }
                if (password.Any(Char.IsUpper) && password.Any(Char.IsLower) && password.Any(Char.IsPunctuation) && password.Any(Char.IsNumber))
                {

                }
                else throw new Exception("Password must contain atleast 1 lower and upper case letter, a symbol and a number");

                foreach (var item in fh.Read_Users())
                {
                    if (item.Name == username)
                    {
                        throw new Exception("Username already exists");
                    }
                }

                return "G";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

        public bool CheckCredentials(string username,string password)
        {
            FileHandler fh = new FileHandler();
            List<User> users = fh.Read_Users();

            foreach (var item in users)
            {
                if (item.Name.CompareTo(username)==0)
                {
                    if (item.Password.CompareTo(password)==0)
                    {
                        return true;
                    }
                }
               

            }
            return false;
        }

        public string Add_User(User newUser)
        {
            FileHandler fh = new FileHandler();

            return fh.Add_User(newUser);
        }

        public List<Student> getStudent()
        {
            return dh.getStudent();
        }

        public List<Module> ReadModules()
        {
            return dh.ReadModules();
        }

        public bool ValidateStudentInsertInfo(string Name,string Surname,string Phone,string Address, int GenderIndex,DateTime DOB) {

            if (Name.Length > 0 && Name.Length < 31)
                if (Surname.Length > 0 && Surname.Length < 31)
                    if (Phone != "" && Phone.All(char.IsDigit) && Phone.Length == 10)
                        if (Address.Length > 0 && Address.Length < 41)
                            if (GenderIndex < 3 && GenderIndex > -1)
                                if (DOB.AddYears(18) <= DateTime.Now)
                                    return true;
            return false;
        }

        public bool ValidateModuleInfo(string mCode, string mName, string mDescription, string mLink)
        {
            if (mCode.Any(Char.IsWhiteSpace)|| mLink.Any(Char.IsWhiteSpace))
            {
                return false;
            }
            if (mCode.Any(Char.IsPunctuation) || mName.Any(Char.IsPunctuation) || mDescription.Any(Char.IsPunctuation))
            {
                return false;
            }
            if (mLink.Contains("https://")==false)
            {
                if (mLink.Contains("www.") == false)
                {
                    if (mLink.Contains("http://") == false)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                return true;
            }
            return true;

        }

        public string UpdateModule(string oldMCode, string MCode, string Mname, string MDescription, string MLink)
        {
            DataHandler dh = new DataHandler();
            return dh.UpdateModule(oldMCode, MCode, Mname, MDescription, MLink);
            
        }

    }
}
