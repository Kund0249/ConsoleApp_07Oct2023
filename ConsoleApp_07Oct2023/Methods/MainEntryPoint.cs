using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Oct2023.Methods
{
    class MainEntryPoint
    {
        static void Main(string[] args)
        {
            MathCLient mathCLient = new MathCLient();

            //int[] Numbers = new int[5] { 10, 20, 30, 40, 50 };
            //int result = mathCLient.Sum(Numbers);

            //int result = mathCLient.Sum(10, 20, 30, 40, 50, 50);

            //Console.WriteLine("Sum : " + result);
            mathCLient.AreaOfRectangle(10, 20);

          

        }
    }
}
