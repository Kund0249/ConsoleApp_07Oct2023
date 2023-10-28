using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Oct2023.ArrayExamples
{
    class MulDimArray
    {
        //10    20
        //30    40
        static void Main(string[] args)
        {
            // int[] array = new int[5] { 1,2,3,4,5};
            int[,] _2Array = new int[2, 2];

            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write($" Array[{row},{col}] :");
                    _2Array[row, col] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            //{
            //    {10,20 },
            //    {30,40 },
            //    {50,60}
            //};
            //_2Array[0, 0] = 10;
            //_2Array[0, 1] = 20;
            //_2Array[1, 0] = 30;
            //_2Array[1, 1] = 40;


            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    //Console.Write($"{_2Array[row, col]}" + "\t");
                    Console.Write($"{_2Array[col, row]}" + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
