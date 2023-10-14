using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Oct2023.ControlStatement.IterationSTatement
{
    class doWhileLoop_Demo
    {
        static void Main(string[] args)
        {

            char choice;

            do
            {
                Console.Write("Enter N1 : ");
                int N1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter N2 : ");
                int N2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("[Add-1 Sub-2 Mul-3 Div-4] : ");
                byte Op = Convert.ToByte(Console.ReadLine());

                switch (Op)
                {
                    case 1:
                        Console.WriteLine($"{N1} + {N2} = {N1 + N2}");
                        break;
                    case 2:
                        Console.WriteLine($"{N1} - {N2} = {N1 - N2}");
                        break;
                    case 3:
                        Console.WriteLine($"{N1} * {N2} = {N1 * N2}");
                        break;
                    case 4:
                        Console.WriteLine($"{N1} / {N2} = {N1 / N2}");
                        break;
                    default:
                        Console.WriteLine("Opps! you entered an invalid input!.");
                        break;
                }

                Console.Write("To continue press 'y' : ");
                choice = Console.ReadKey().KeyChar;
                choice = char.ToLower(choice);
                Console.WriteLine();
            } while (choice == 'y');

          
        }

    }
}
