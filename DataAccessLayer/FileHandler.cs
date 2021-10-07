using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Milestone2_PRG282.BusinessLayer;
using System.IO;

namespace Project_Milestone2_PRG282.DataAccessLayer
{
    class FileHandler
    {
        string path = @"C:\Users\Dylan\Desktop\PRG282\PRG281_Project\Project_Rep\Project_Milestone2_PRG282" +  @"\AccountInfo.txt";
        //C:\Users\Dylan\Desktop\PRG282\PRG281_Project\Project_Rep\Project_Milestone2_PRG282
        public List<User> Read_Users()
        {
            List<User> users = new List<User>();

            //MessageBox.Show(System.AppDomain.CurrentDomain.BaseDirectory + @"\\AccountInfo.txt") ;

            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path) )
                {
                    string txt;
                    while ((txt = reader.ReadLine())!=null)
                    {;
                        users.Add(new User(txt.Substring(0, txt.IndexOf("#")), txt.Substring(txt.IndexOf("#")+1, txt.Length - txt.IndexOf("#")-1)));
                    }
                }
            }
            return users;
        }

        public string Add_User(User newUser)
        {
            if (File.Exists(path))
            {
                
                File.AppendAllText(path,string.Format("{0}#{1}\n",newUser.Name,newUser.Password));
                return "Succesfully added";
            }
            return "Failed to create";
        }


    }
}
