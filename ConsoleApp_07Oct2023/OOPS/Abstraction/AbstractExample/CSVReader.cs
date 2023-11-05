using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Oct2023.OOPS.Abstraction.AbstractExample
{
    class CSVReader : FileReader
    {
        public override void Read(string FilePath)
        {
            throw new NotImplementedException();
        }
    }
}
