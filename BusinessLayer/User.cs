using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Milestone2_PRG282.BusinessLayer
{
    class User : IComparable
    {

        string name;
        string password;

        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }

        User() { }
        public User(string name, string password)
        {
            this.Name = name;
            this.Password = password;
        }

        public int CompareTo(object obj)
        {
            User current = obj as User;
            return this.Name.CompareTo(current.Name);
        }
    }
}
