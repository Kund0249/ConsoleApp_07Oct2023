using System;

namespace ConsoleApp_07Oct2023
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Enter your name : ");
            string Name = System.Console.ReadLine();
            //Name = "Abc";

            Console.Write("Enter your Age : ");
            int Age = Convert.ToInt32(System.Console.ReadLine());
            //Console.WriteLine("Hello " + Name + ", Good After noon!, you are " + Age + " years old.");
            // Console.WriteLine("Hello {0}, Good After noon!. you are {1} years old",Name,Age);
            Console.WriteLine($"Hello {Name}, Good After noon!. you are {Age} years old");

        }
    }
}

