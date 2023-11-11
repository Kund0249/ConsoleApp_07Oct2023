using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Oct2023.GenericsExample
{
    static class Abc
    {
        //public static void Add(object V1, object V2)
        //{
        //    dynamic N1 = V1;
        //    dynamic N2 = V2;
        //    Console.WriteLine("Sum : " + (N1 + N2));
        //}

        public static void Add<T>(T V1, T V2)
        {
            dynamic N1 = V1;
            dynamic N2 = V2;
            Console.WriteLine("Sum : " + (N1 + N2));
        }

        public static void Compare<T>(T V1, T V2)
        {
            dynamic N1 = V1;
            dynamic N2 = V2;
            if(N1 == N2)
            {
                Console.WriteLine("Entered values are same : " + (N1, N2));
            }
            else
            {
                Console.WriteLine("Entered values are different : " + (N1, N2));
            }
            
        }

    }
    class Startup
    {
        static void Main(string[] args)
        {
            //int N1 = 10;
            //object V1 = N1; //Boxing

            //int N2 = (int)V1; //UnBoxing

            //Abc.Add(10.5F ,20);

            //Abc.Add<float>(10, 20.5F);

            //Abc.Compare(false, true);
        }
    }
}
