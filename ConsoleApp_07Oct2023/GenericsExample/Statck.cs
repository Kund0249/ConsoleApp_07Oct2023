using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Oct2023.GenericsExample
{
    class Statck
    {
        static void Main(string[] args)
        {
            Stack<int> TokenQueue = new Stack<int>();
            TokenQueue.Push(1);
            TokenQueue.Push(2);
            TokenQueue.Push(3);
            TokenQueue.Push(4);

            foreach (int item in TokenQueue)
            {
                Console.WriteLine(item);
            }


            do
            {
                Console.Write("Enter Token : ");
                int Token = Convert.ToInt32(Console.ReadLine());

                if (Token == TokenQueue.Peek())
                {
                    Console.WriteLine("Service Completed!");
                    TokenQueue.Pop();
                }
                else
                {
                    Console.WriteLine("Invalid or not ready for service.");
                }

            } while (TokenQueue.Count() > 0);
        }
    }
}
