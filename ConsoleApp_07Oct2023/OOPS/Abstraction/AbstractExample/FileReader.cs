using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Oct2023.OOPS.Abstraction.AbstractExample
{
   abstract class FileReader
    {
        public string FileName { get; set; }

        public long ContentLength { get; set; }
        public string FileType { get; set; }

        public abstract void Read(string FilePath);
       
    }
}
