using System;
using System.Collections;


namespace ConsoleApp_07Oct2023.ArrayExamples
{
    class ArrayListDemo
    {
        static void Main(string[] args)
        {
            //int[] Numbers = new int[2];
            //Numbers[0] = 1;
            //Numbers[1] = 2;
            //Numbers[2] = 3;

            ArrayList list = new ArrayList();


            Console.Write("Enter Number of Iteams : ");
            int Items = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < Items; i++)
            {
                Console.Write("Enter Value " + (i + 1) + " : ");
                int Value = Convert.ToInt32(Console.ReadLine());
                list.Add(Value);
            }

            foreach(int n in list)
            {
                Console.WriteLine(n);
            }
        }
    }
}
