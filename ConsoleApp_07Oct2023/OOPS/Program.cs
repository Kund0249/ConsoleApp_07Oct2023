using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Oct2023.OOPS
{
    //user define datatype - ref type
    class Employee
    {
        public int EmpCode;
        public string Name;
        public byte Age; 
        public float Salary;
        public static int EmployeeSeed;
        public Employee()
        {
            Console.WriteLine("Default Constructor Invoked");
            EmpCode = EmployeeSeed++;
            Name = "NA";
            Age = 0;
            Salary = 0.1F;
        }
        public Employee(string Name,byte Age,float Salary)
        {
            Console.WriteLine("Parameterized Constructor Invoked");
            EmpCode = EmployeeSeed++;
            this.Name = Name;
            this.Age = Age;
            this.Salary = Salary;
        }
        public Employee(Employee employee)
        {
            Console.WriteLine("Copy Constructor Invoked");
            EmpCode = EmployeeSeed++;
            this.Name = employee.Name;
            this.Age = employee.Age;
            this.Salary = employee.Salary;
        }
        static Employee()
        {
            Console.WriteLine("Static Constructor Invoked");
            EmployeeSeed = 101;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("John", 27, 25000F);

            Employee e2 = new Employee();

            Employee e3 = new Employee(e1);
            // Employee e3 = e1;
            //e1.EmpCode = 5;


            //Console.WriteLine($"EmpCode {e1.EmpCode} Name : {e1.Name} Age {e1.Age} Salary : {e1.Salary}");
            //Console.WriteLine($"EmpCode {e2.EmpCode} Name : {e2.Name} Age {e2.Age} Salary : {e2.Salary}");
            //Console.WriteLine($"EmpCode {e3.EmpCode} Name : {e3.Name} Age {e3.Age} Salary : {e3.Salary}");

        }
    }
}
