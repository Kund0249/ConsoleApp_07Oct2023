using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Oct2023.OOPS.Polymorphism
{
    public enum MailResponse
    {
        success,
        Failure
    }
    class MailService
    {
        public virtual MailResponse SendEmail(string from,string To,string subject,string message,string signature)
        {
            //code to send an email
            Console.WriteLine("Mail Sent From : {0}  To : {1}",from,To);
            return MailResponse.success;
        }
    }
}
