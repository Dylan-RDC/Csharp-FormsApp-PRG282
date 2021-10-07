using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Milestone2_PRG282.BusinessLayer
{
    class Student:IComparable<Student>
    {
        public Student()
        {
            //empty constructor
        }


        string studNumber, studName, studSurname, phone, address, gender;
        DateTime dateOfbirth;

        public Student(string studNumber, string studName, string studSurname, string phone, string address, string gender, DateTime dateOfbirth)
        {
            this.StudNumber = studNumber;
            this.StudName = studName;
            this.StudSurname = studSurname;
            this.Phone = phone;
            this.Address = address;
            this.Gender = gender;
            this.DateOfbirth = dateOfbirth;
        }

        public string StudNumber { get => studNumber; set => studNumber = value; }
        public string StudName { get => studName; set => studName = value; }
        public string StudSurname { get => studSurname; set => studSurname = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public string Gender { get => gender; set => gender = value; }
        public DateTime DateOfbirth { get => dateOfbirth; set => dateOfbirth = value; }

        public int CompareTo(Student other)
        {
            return this.StudName.CompareTo(other.StudName);
        }
        
    }

}
