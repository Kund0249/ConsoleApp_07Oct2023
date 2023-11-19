using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Oct2023.DelegateExample
{
    public delegate void MyDel();
    public delegate bool CustomeDel(int n);
    class Abc
    {
        public void Method1()
        {
            Console.WriteLine("Method1 Invoked of class Abc");
        }

        public void Method2()
        {
            Console.WriteLine("Method2 Invoked of class Abc");
        }

        public void PrintNumber(CustomeDel del)
        {
            List<int> list = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10,11,12,13,14,15
            };

            foreach (int item in list)
            {
                if (del.Invoke(item))
                    Console.WriteLine(item);
            }
        }
    }

    class PQR
    {
        public void Method1()
        {
            Console.WriteLine("Method1 Invoked of class PQR");
        }

    }
    class DelegateDemo
    {

        //public static bool PrimeLogic(int n)
        //{
        //    //if (n > 10)
        //    //    return true;
        //    //return false;

        //    for (int i = 2; i <= n / 2; i++)
        //    {
        //        if (n % i == 0)
        //            return false;
        //    }

        //    return true;
        //}

        //public static bool EvenLogic(int n)
        //{
        //    if (n % 2 == 0)
        //        return true;
        //    return false;
        //}
        static void Main(string[] args)
        {
            Abc abc = new Abc();
            //CustomeDel PrimeDel = new CustomeDel(PrimeLogic);
            //Console.WriteLine("All Prime Numbers");
            //abc.PrintNumber(PrimeDel);

            //Console.WriteLine("All Even Numbers");
            //CustomeDel EvenDel = new CustomeDel(EvenLogic);
            //abc.PrintNumber(EvenDel);

            Console.WriteLine("All Gereater then 10");
            abc.PrintNumber(x => x > 10);
            Console.WriteLine("All Even Number");
            abc.PrintNumber(x => x % 2 == 0);

            Console.WriteLine("All Odd Number");
            abc.PrintNumber(x => x % 2 != 0);

            //abc.Method2();

            PQR pqr = new PQR();
            //pqr.Method1();

            //MyDel del = new MyDel(abc.Method1);
            //del += abc.Method2;
            //del += pqr.Method1;

            //del.Invoke();

        }
    }
}
