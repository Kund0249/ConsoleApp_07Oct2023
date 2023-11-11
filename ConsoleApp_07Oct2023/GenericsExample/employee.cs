using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Oct2023.GenericsExample
{
    class employee
    {

        private int _EmployeeId;
        private string _EmployeeName;
        //private string _Gender;

        public int EmployeeId
        {
            set
            {
                if (value > 0)
                    _EmployeeId = value;
                else
                    throw new Exception("employee Id must be greater than 0.");
            }
            get { return _EmployeeId; }
        }
        public String EmployeeName
        {
            get { return _EmployeeName; }
            set
            {
                if (!(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)))
                    _EmployeeName = value;
                else
                    throw new Exception("Employee Name is not valid.");

            }
        }



        public override string ToString()
        {
            return string.Format($"Employee Id : {EmployeeId}, Name : {EmployeeName} ");
        }

    }
}

