using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp_07Oct2023.ArrayExamples
{
    class PrimeNotPrime
    {
        public static bool Isprime(int n)
        {
            for (int i = 2; i < n / 2; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            Console.Write("Enter Number Of Values : ");
            int val = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < val; i++)
            {
                Console.Write($"Enter N{i + 1} : ");
                int number = Convert.ToInt32(Console.ReadLine());
                list.Add(number);
            }

            ArrayList PrimeNumbers = new ArrayList();
            ArrayList NotPrimeNumbers = new ArrayList();

            foreach (int item in list)
            {
                if (Isprime(item))
                    PrimeNumbers.Add(item);
                else
                    NotPrimeNumbers.Add(item);
            }

            //foreach (int item in list)
            //{
            //    bool IsPrime = true;

            //    for (int i = 2; i < item / 2; i++)
            //    {
            //        if (item % i == 0)
            //        {
            //            IsPrime = false;
            //            break;
            //        }
            //    }

            //    if (IsPrime)
            //        PrimeNumbers.Add(item);
            //    else
            //        NotPrimeNumbers.Add(item);
            //}

            Console.Write("Prime Numbers : [ ");
            foreach (var item in PrimeNumbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("]");

            Console.Write("Not Prime Numbers : [ ");
            foreach (var item in NotPrimeNumbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("]");

        }
    }
}
