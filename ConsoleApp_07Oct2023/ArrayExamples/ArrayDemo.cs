using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Oct2023.ArrayExamples
{
    class ArrayDemo
    {
        static void Main(string[] args)
        {
            //    int N1 = 10;
            //    int N2 = 20;
            //    int N3 = 30;
            //    int N4 = 40;
            //    int N5 = 50;

            //int[] Numbers = new int[10] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 20 };

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}

            Console.Write("Enter Number of Iteams : ");
            int Items = Convert.ToInt32(Console.ReadLine());

            int[] Itesm = new int[Items];

            for (int i = 0; i < Itesm.Length; i++)
            {
                Console.Write($"Enter Price of Iteam {i + 1} : ");
                Itesm[i] = Convert.ToInt32(Console.ReadLine());
            }

            int Sum = 0;
            for (int i = 0; i < Itesm.Length; i++)
            {
                Sum = Sum + Itesm[i];
            }

            Console.WriteLine("Total Amount : " + Sum);
        }
    }
}
