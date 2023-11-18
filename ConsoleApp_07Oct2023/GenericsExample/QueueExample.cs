using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Oct2023.GenericsExample
{
    class QueueExample
    {
        static void Main(string[] args)
        {
            Queue<int> TokenQueue = new Queue<int>();
            TokenQueue.Enqueue(1);
            TokenQueue.Enqueue(2);
            TokenQueue.Enqueue(3);
            TokenQueue.Enqueue(4);


            do
            {
                Console.Write("Enter Token : ");
                int Token = Convert.ToInt32(Console.ReadLine());

                if(Token == TokenQueue.Peek())
                {
                    Console.WriteLine("Service Completed!");
                    TokenQueue.Dequeue();
                }
                else
                {
                    Console.WriteLine("Invalid or not ready for service.");
                }

            } while (TokenQueue.Count() > 0);

        }
    }
}
