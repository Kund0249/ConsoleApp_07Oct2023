using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp_07Oct2023.ControlStatement.IterationSTatement
{
    class ForLoopDemo
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N1 : ");
            int Number = Convert.ToInt32(Console.ReadLine());

            bool IsPrime = true;

            for (int i = 2; i < Number/2; i++)
            {
                Thread.Sleep(1000);
                if (Number % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }

            if (IsPrime)
                Console.WriteLine("prime");
            else
                Console.WriteLine("Not Prime");
        }
    }
}
