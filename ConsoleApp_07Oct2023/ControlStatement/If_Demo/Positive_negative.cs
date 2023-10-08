using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Oct2023.ControlStatement.If_Demo
{
    class Positive_negative
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an number");
            int n1 = Convert.ToInt32(Console.ReadLine());

            if (n1 > 0)
            {
                if (n1 % 2 == 0)
                {
                    Console.WriteLine($"Number{n1} is positive and even");
                }
                else
                {
                    Console.WriteLine($"Number {n1} is positive and odd");
                }
            }
            else if (n1 < 0)
            {
                 Console.WriteLine($"Number{n1} is negative and you cannot proceed further");
            }
            else
            {
                Console.WriteLine($"number {n1} is zero");

            }
            
        }
    }
    
}
