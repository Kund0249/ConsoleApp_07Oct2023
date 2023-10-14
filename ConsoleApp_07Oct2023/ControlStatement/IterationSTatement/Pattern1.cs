using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Oct2023.ControlStatement.IterationSTatement
{
    /*
        *
       ***
      *****
     *     *
      *****
       ***
        *
     */
    class Pattern1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Numbers of Line : ");
            int Line = Convert.ToInt32(Console.ReadLine());

            if (Line % 2 == 0)
            {
                Line++;
            }
            int Space = Line - 1;
            int Star = 1;

            for (int i = 1; i <= Line; i++)
            {
                for (int j = 1; j <= Space; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= Star; j++)
                {
                    if ((j == 1 || j == Star) && i == Line / 2 + 1)
                        Console.Write("*");
                    else if (i == Line / 2 + 1)
                        Console.Write(" ");
                    else
                        Console.Write("*");
                }

                Console.WriteLine();

                if (i <= Line / 2)
                {
                    Space--;
                    Star += 2;
                }
                else
                {
                    Space++;
                    Star -= 2;
                }

            }
        }
    }
}
