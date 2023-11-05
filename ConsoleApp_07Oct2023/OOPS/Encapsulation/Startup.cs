using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace ConsoleApp_07Oct2023.OOPS.Encapsulation
{
    class A
    {
        public int N1;
        protected int N2;
    }

    class B : EmployeeRepository
    {
        static void Main(string[] args)
        {
            B obj = new B();
            obj.ab = 10;
        }
    }
    class Startup 
    {
        static void Main(string[] args)
        {


            Student S1 = new Student();
            //S1.StudentId = -10;
            //S1.SetId(-10);
            //Console.WriteLine("Student Id : " + S1.GetId());
            S1.StudentId = 10;
            S1.StudentName = "John";
            S1.Gender = "M";
            Console.WriteLine("Student Id : " + S1.StudentId);
            Console.WriteLine("Student Name : " + S1.StudentName);

            IEmployeeRepository repository = new EmployeeRepository();

            repository.Save();

           
        }
    }
}
