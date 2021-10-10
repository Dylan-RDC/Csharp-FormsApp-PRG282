using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Milestone2_PRG282.DataAccessLayer;

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

        public Student(string studNum,string studName, string studSurname, string phone, string address, string gender, DateTime dateOfbirth,byte[] imagePath)
        {
            this.StudNumber = studNum;
            this.StudName = studName;
            this.StudSurname = studSurname;
            this.Phone = phone;
            this.Address = address;
            this.Gender = gender;
            this.DateOfbirth = dateOfbirth;
            this.ImageData = imagePath;
        }

        public string StudNumber { get => studNumber; set => studNumber = value; }
        public string StudName { get => studName; set => studName = value; }
        public string StudSurname { get => studSurname; set => studSurname = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public string Gender { get => gender; set => gender = value; }
        public byte[] ImageData { get; set; }

        public DateTime DateOfbirth { get => dateOfbirth; set => dateOfbirth = value; }

        public string insertToDB()
        {
            DataHandler dh = new DataHandler();
            return dh.insertStudent(StudName, StudSurname, DateOfbirth, Phone, Address, Gender, ImageData);
        }
        public string UpdateInDB()
        {
            DataHandler dh = new DataHandler();

            return dh.UpdateStudent(StudNumber,StudName, StudSurname, DateOfbirth, Phone, Address, Gender,ImageData);
        }
        public int CompareTo(Student other)
        {
            return this.StudName.CompareTo(other.StudName);
        }
        
        public string toString()
        {
            return $"Student number: {studNumber}\tName: {studName}\tSurname: {studSurname}\tPhone number: {Phone}\tAddress: {address}\tGender: {Gender}\tDate of Birth: {dateOfbirth}";
        }
    }

}
