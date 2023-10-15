using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Oct2023.ControlStatement.JumpStatement
{
    class ContinueStatement
    {
        /*
         Step 1 : Excel file - 1000
         step 2 : Validate each row data
         step 3 : if valid the save into database
         
         */
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                //if(employeeid == null || employeeid == 0)
                //continue
                if (i >= 5 && i <= 8)
                    continue;

                Console.WriteLine(i);
            }
        }
    }
}
