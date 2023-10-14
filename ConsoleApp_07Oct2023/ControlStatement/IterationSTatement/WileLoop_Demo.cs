using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Oct2023.ControlStatement.IterationSTatement
{
    class WileLoop_Demo
    {
        static void Main(string[] args)
        {
            int N = 1234;
            int rem = 0;
            int rev = 0;//432*10 + 1 = 4321

            while(N > 0)
            {
                rem = N % 10;
                rev = rev * 10 + rem;
                N = N / 10;
            }

            Console.WriteLine($"Reverse : {rev}");
        }

    }
}
