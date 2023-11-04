using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Oct2023.OOPS.Polymorphism
{
    class MailCilent : MailService
    {
        public override MailResponse SendEmail(string from, string To, string subject, string message, string signature)
        {
            MailResponse response = base.SendEmail(from, To, subject, message, signature);
            //log code
            Console.WriteLine("Message is logged into DB.");
            return response;
        }
    }
}
