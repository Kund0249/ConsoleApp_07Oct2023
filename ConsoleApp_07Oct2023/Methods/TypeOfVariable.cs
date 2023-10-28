using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Oct2023.Methods
{
    /*
     1) Local Variable
     2) Instance
     3) Static
     4) Constant
     5) ReadOnly
     */
    class TypeOfVariable
    {
        public int N = 10;

        public const float PI = 3.14F;
        //instance readonly member
        public readonly float PI2;

        public TypeOfVariable(float Val)
        {
            PI2 = Val;
        }

        public void Fun1(int v)
        {
            int Val1 = 10;
        }
        static void Main(string[] args)
        {
            TypeOfVariable ob = new TypeOfVariable(3.12F);
            //ob.PI2 = 3.16F;

            Console.WriteLine(ob.N);
            Console.WriteLine("PI : " + PI);
            Console.WriteLine("PI2 : " + ob.PI2);
        }
    }
}
