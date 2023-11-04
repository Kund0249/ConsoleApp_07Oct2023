using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Oct2023.OOPS.Polymorphism
{
    public enum NotificationType
    {
        success,
        error,
        warrning,
        information
    }
    class Notifier
    {
        public void Notify(NotificationType notificationType)
        {
            switch (notificationType)
            {

                case NotificationType.success:
                    Console.WriteLine("Success : " + "This is a success message!");
                    break;
                case NotificationType.error:
                    Console.WriteLine("Error : " + "This is a Error message!");
                    break;
                case NotificationType.warrning:
                    Console.WriteLine("Warning : " + "This is a Watrning message!");
                    break;
                case NotificationType.information:
                    Console.WriteLine("Info : " + "This is a Info message!");
                    break;
                default:
                    break;
            }
        }

        public void Notify(string Title,string Message,string color = null)
        {
            Console.WriteLine(Title + " : " + Message);
        }
    }
}
