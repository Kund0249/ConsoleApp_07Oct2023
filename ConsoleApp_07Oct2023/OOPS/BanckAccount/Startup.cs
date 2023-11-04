using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp_07Oct2023.OOPS.Polymorphism;

namespace ConsoleApp_07Oct2023.OOPS.BanckAccount
{
    class Department 
    {
        public string DepartmentCode;
        public string DepartmentName;

        public override string ToString()
        {
            return string.Format("Department Code : {0} Department Name : {1}",DepartmentCode,DepartmentName);
        }
    }
    class Startup
    {
        static void Main(string[] args)
        {

            int N = 10;

            Department department = new Department()
            {
                DepartmentCode = "IT01",
                DepartmentName = "Information Technology - 1"
            };

            Console.WriteLine(department.ToString());
            

            //MathClient client = new MathClient();
            //var Res = client.Add(9223372036854775807, 20);

            //Console.WriteLine("Sum : " + Res);

            //Notifier notifier = new Notifier();

            //notifier.Notify(NotificationType.success);
            //notifier.Notify("Processing", "Your Request is processing");

            //MailService service = new MailService();
            //MailCilent client = new MailCilent();
            //client.SendEmail("abc@gmail.com", "xyz@gmail.com", "Test Mail", "Test message", "Best Regards");
        }
    }
}
