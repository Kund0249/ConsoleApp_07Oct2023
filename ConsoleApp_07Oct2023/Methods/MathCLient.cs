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
        public int Sum(int V1, int V2,int V3)
        {
            return (V1 + V2 + V3);
        }

        public int Sum(params int[] Values)
        {
            int Sum = 0;
            foreach (int V in Values)
            {
                Sum = Sum + V;
            }
            return Sum;
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

        public int AreaOfRectangle(int Length,int Height,bool PrintOutput = false)
        {
            int Area = Length * Height;
            if (PrintOutput)
            {
                Console.WriteLine("Length : " + Length);
                Console.WriteLine("Width : " + Height);
                Console.WriteLine("Area : " + Area);
            }
               
            return Area;
        }

        public void SendEmail(string From,string To,string SubjectLine,string MailBody,string Signature,string Attachements = null)
        {
            //if(Attachements != null)
            //send email with attchements
            //else
            //send email without attchements
        }
    }
}
