using ConsoleApp_07Oct2023.OOPS.Encapsulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Oct2023.GenericsExample
{
    class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if (x.StudentId == y.StudentId && x.StudentName.ToLower() == y.StudentName.ToLower())
                return true;

            return false;
        }

        public int GetHashCode(Student obj)
        {
            return obj.StudentId.GetHashCode() + obj.StudentName.ToLower().GetHashCode();
        }
    }
    class HashSetDemo
    {
        static void Main(string[] args)
        {
           // List<int> list = new List<int>();
            HashSet<Student> list = new HashSet<Student>(new StudentComparer());
            list.Add(new Student() { StudentId = 1, Gender = "M", StudentName = "John" });
            list.Add(new Student() { StudentId = 2, Gender = "F", StudentName = "Peck Yan" });
            list.Add(new Student() { StudentId = 3, Gender = "M", StudentName = "Alex" });
            list.Add(new Student() { StudentId = 4, Gender = "F", StudentName = "Adeline" });
            list.Add(new Student() { StudentId = 5, Gender = "F", StudentName = "adeline" });


            foreach (Student item in list)
            {
                Console.WriteLine(item.ToString());
            }

            //string N1 = "Ajay";
            //string N2 = "ajay";

            //Console.WriteLine("N1 Hashcode : " + N1.GetHashCode());
            //Console.WriteLine("N2 Hashcode : " + N2.GetHashCode());
        }
    }
}
