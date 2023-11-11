using System;
using System.Collections;
using System.Collections.Generic;
using ConsoleApp_07Oct2023.OOPS.Encapsulation;


namespace ConsoleApp_07Oct2023.GenericsExample
{
    class ListDemo
    {
        static void Main(string[] args)
        {
            //ArrayList list = new ArrayList();

            List<Student> list = new List<Student>();

            list.Add(new Student() { StudentId = 1, Gender = "M", StudentName = "John" });
            list.Add(new Student() { StudentId = 2, Gender = "F", StudentName = "Peck Yan" });
            list.Add(new Student() { StudentId = 3, Gender = "M", StudentName = "Alex" });
            list.Add(new Student() { StudentId = 4, Gender = "F", StudentName = "Adeline" });
            //list.Add(1);
            //Student s = list.Find(x => x.StudentId == 3);
            //list.Remove(s);

            //list.RemoveAll(x => x.StudentId > 2);
            //list.RemoveRange(1, 2);

            //foreach (Student item in list)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            List<employee> employees = new List<employee>();

            employees.Add(new employee() { EmployeeId = 1, EmployeeName = "abc" });
            employees.Add(new employee() { EmployeeId = 2, EmployeeName = "abc" });
            employees.Add(new employee() { EmployeeId = 3, EmployeeName = "abc" });

            Console.WriteLine("Select 1 : to add employee");
            Console.WriteLine("Select 2 : to display information employee");
            Console.WriteLine("Select 3 : to Delete employee");

            int Value =  Convert.ToInt32(Console.ReadLine());
            switch (Value)
            {
                case 1:
                    Console.Write("enter employee ID : ");
                    int empId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("enter employee Name : ");
                    string empName = (Console.ReadLine());
                    employees.Add(new employee() { EmployeeId = empId, EmployeeName = empName });
                    Console.WriteLine("Employee is added successfully");
                    break;
                case 2:
                    foreach (employee item in employees)
                    {
                        Console.WriteLine(item.ToString());
                    }
                    break;
                case 3:
                    Console.Write("enter employee ID : ");
                    int empId1 = Convert.ToInt32(Console.ReadLine());
                    employee s = employees.Find(x => x.EmployeeId == empId1);
                    employees.Remove(s);
                    break;
                default:
                    break;
            }
        }
    }
}
