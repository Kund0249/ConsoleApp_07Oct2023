using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Oct2023.Methods
{
    public class MathCLient
    {
        //access-specifiers return-type name([parameters])
        public void Message(string From,String To,string Body,string Subject,string Signature)
        {
            //send email
            Console.WriteLine("Hello from Math Client Service!");
        }
        public int Reverse(int V)
        {
            int Rev = 0;
            int rem = 0;
            while (V > 0)
            {
                rem = V % 10;
                Rev = Rev * 10 + rem;
                V = V / 10;
            }
            return Rev;
        }
        public int Sum(int V1, int V2)
        {
            return (V1 + V2);
        }
        public bool IsPrime(int V)
        {
            for (int i = 2; i < V / 2; i++)
            {
                if (V % i == 0)
                    return false;
            }
            return true;
        }

        public void Increment(ref int Value)
        {
            Value += 5;
        }
    }
}
