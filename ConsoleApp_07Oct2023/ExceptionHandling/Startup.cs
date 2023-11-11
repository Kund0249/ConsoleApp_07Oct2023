using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Oct2023.ExceptionHandling
{
    class Startup
    {
        static void Main(string[] args)
        {
            try
            {
                //Console.Write("N1 : ");
                //int N1 = Convert.ToInt32(Console.ReadLine());
                //Console.Write("N1 : ");
                //int N2 = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Processing..");
                //int Res = N1 ;
                //Console.WriteLine("Completed!");
                //Console.WriteLine("Res : " + Res);
                // Console.WriteLine("Program Finish.");

                //--------------------------------------------

                bool IsValidInput = false;
                Console.Write("N1 : ");
                int N1 = 0;

                while (!IsValidInput)
                {
                    try
                    {
                        N1 = Convert.ToInt32(Console.ReadLine());
                        IsValidInput = true;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Please enter valid input.");
                        Console.Write("N1 : ");
                        IsValidInput = false;
                    }
                }

                Methods.MathCLient Client = new Methods.MathCLient();

                
                if (Client.IsPrime(N1))
                {
                    Console.WriteLine("{0} is prime number",N1);
                }
                else
                {
                    Console.WriteLine("{0} is not a prime number", N1);
                }
                
            }
            
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid input value");
                
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Please enter the value betwee 0 to {0}", int.MaxValue);
            }
            catch (Exception ex)
            {
                //throw;
                Console.WriteLine("There is some proble occur, system currently not able to process your request. please try latter!");
            }
            finally
            {
                Console.WriteLine("Program Finish.");
            }

        }
    }
}
