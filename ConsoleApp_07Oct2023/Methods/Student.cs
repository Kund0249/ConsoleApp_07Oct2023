using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Oct2023.Methods
{
    public class Student
    {
        //Static Member
        public static string SchoolName;

        //Instance Member
        public int Roll;
        public string Name;
        public int Age;

        public void CreateStudent(int RollNo, string StudentName, int StudentAge)
        {
            Roll = RollNo;
            Name = StudentName;
            Age = StudentAge;
        }
        public void GetStudent()
        {
            Console.WriteLine($"Roll No : {Roll} Name : {Name} Age : {Age}");
        }

     
    }
}
