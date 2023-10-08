using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Oct2023.ControlStatement.If_Demo
{
    class Program1
    {
        static void Main(string[] args)
        {
            //Console.Write("Please Eneter you Name :");
            //string Name = Console.ReadLine();

            //Console.WriteLine("Enter Age : ");
            //byte age = Convert.ToByte(Console.ReadLine());


            //if (age >= 18)
            //    Console.WriteLine($"Hi {Name}, you are elegible for the event!");
            //else
            //    Console.WriteLine($"Hi {Name} sorry!, you are not elegible for the event!");

            Console.Write("Enter N1 : ");
            int N1 = int.Parse(Console.ReadLine());

            Console.Write("Enter N2 : ");
            int N2 = Convert.ToInt32(Console.ReadLine());

            if (N1 > N2)
            {
                Console.WriteLine($"N1 : {N1}, is greater than N2 : {N2}");
            }
            else if (N2 > N1)
            {
                Console.WriteLine($"N2 : {N2}, is greater than N1 : {N1}");
            }
            else
            {
                Console.WriteLine($" N1 is equal to N2");
            }

        }
    }
}
