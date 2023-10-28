using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Oct2023.Methods
{
    class TypesOfMethod
    {
        //Class Members
          // 1) Data/Field/Property
          // 2) Method/Function

        //Instance Method => Instance (Object)

        public void Message()
        {
            Console.WriteLine("Hello from Instance Method of class!");
        }

        //Static Method

        public static void StaticMessage()
        {
            Console.WriteLine("Hello from Static Method of class!");
        }

        public static void Main()
        {
            Student.SchoolName = "10+2 Scholl";


            Student S1 = new Student();
            S1.CreateStudent(1, "Sanjay", 28);

            Student S2 = new Student();
            S2.CreateStudent(2, "Ajay", 26);

           
            Student S3 = new Student();
            S3.CreateStudent(3, "Vijay", 22);

            Console.WriteLine($"-------------------{Student.SchoolName}----------------");
            S1.GetStudent();
            S2.GetStudent();
            S3.GetStudent();

        }
    }
}
