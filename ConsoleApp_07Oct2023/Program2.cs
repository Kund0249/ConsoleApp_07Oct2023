using System;

namespace ConsoleApp_07Oct2023
{
    class Program2
    {
        public static void Main()
        {
            Console.Write("Enter N1 : ");
            int N1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter N2 : ");
            int N2 = Convert.ToInt32(Console.ReadLine());

            int Sum = N1 + N2;

            Console.WriteLine($"{N1} + {N2} = {Sum}");
        }
    }
    
}
