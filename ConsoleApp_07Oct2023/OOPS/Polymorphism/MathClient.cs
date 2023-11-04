using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Oct2023.OOPS.Polymorphism
{
    class MathClient
    {

        public void Message(string message,int n)
        {
           
        }

        public int Message(string message,float n)
        {
            return 0;
        }

        public int Message(float n, string message)
        {
            return 0;
        }

        public int Add(int V1,int V2)
        {
            return (V1 + V2);
        }

        public float Add(int V1, float V2)
        {
            return (V1 + V2);
        }

        public float Add(float V1, int V2)
        {
            return (V1 + V2);
        }

        //public long Add(long V1, int V2)
        //{
        //    return (V1 + V2);
        //}
    }
}
