using System;
using ConsoleApp_07Oct2023.Methods;



namespace ConsoleApp_07Oct2023
{
    class Program
    {
     
        public static void Main()
        {
              //Console.Write("Hello");
            //Crate and instance of class (to use the instance member of the class)
            MathCLient math = new MathCLient();
            int Value = 10;
            math.Increment(ref Value);
            Console.WriteLine("Value : " + Value);

            //Console.Write("Enter N1 : ");
            //int N1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter N2 : ");
            //int N2 = Convert.ToInt32(Console.ReadLine());

            //int Sum = math.Sum(N1,N2);

            //Console.WriteLine("Sum : " + Sum);

            //if (math.IsPrime(Sum))
            //{
            //    Console.WriteLine("Sum is a prime Number");
            //}
            //else
            //{
            //    Console.WriteLine("Sum is not a prime Number");
            //}

            //math.Message();
            //int rev = math.Reverse(Sum);

            //if(rev == Sum)
            //{
            //    Console.WriteLine("Sum is a Palindrome Number");
            //}
            //else
            //{
            //    Console.WriteLine("Sum is not a Palindrome Number");
            //}
        }
    }
}

