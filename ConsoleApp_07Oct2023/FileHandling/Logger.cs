using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp_07Oct2023.FileHandling
{

    //Foleder : ErrorLog
    //File : Log_19112023
    class Logger
    {
        static void Main(string[] args)
        {
            string DirectoryPath = @"C:\Users\Admin\Desktop\Tets";
            string filePath = "Log";

            filePath = Path.Combine(DirectoryPath, filePath+"_"+ DateTime.Now.ToString("ddMMyyyy")+".txt");

            Console.WriteLine(filePath);
            //Console.WriteLine(DateTime.Now);
            //Console.WriteLine(DateTime.Now.ToShortDateString());
            //Console.WriteLine(DateTime.Now.ToLongDateString());
            //Console.WriteLine(DateTime.Now.ToString("ddMMyyyy"));

            if (File.Exists(filePath))
            {
                //StreamWriter sw = new StreamWriter(filePath,true);
                //sw.WriteLine("This is some text");
                //sw.Close();
                //Console.WriteLine("Writing compelted!");

                //StreamReader SR = new StreamReader(filePath);
                
                //Console.WriteLine(SR.ReadToEnd());
                
                
            }

            //if (Directory.Exists(DirectoryPath))
            //{
            //    filePath = Path.Combine(DirectoryPath, filePath);
            //    if (File.Exists(filePath))
            //    {
            //        File.Delete(filePath);
            //        Console.WriteLine("File Deleted : " + Path.GetFileName(filePath));
            //    }
            //    //string[] files = Directory.GetFiles(DirectoryPath);
            //    //Console.WriteLine($"---------{Path.GetDirectoryName(DirectoryPath)}------------");
            //    //foreach (var item in files)
            //    //{
            //    //    Console.WriteLine(Path.GetFileName(item));
            //    //}
            //    //Console.WriteLine("------------End-------------");
            //}

            //if (Directory.Exists(DirectoryPath))
            //{
            //    Console.WriteLine("Test Directory available");

            //    filePath = Path.Combine(DirectoryPath, filePath);
               
            //    if (File.Exists(filePath))
            //    {
            //        Console.WriteLine("File available");
            //    }
            //    else
            //    {
            //        Console.WriteLine("File Not Available");
            //        File.Create(filePath);
            //        Console.WriteLine("File Created");
            //    }
                   
            //}
            //else
            //{
            //    Console.WriteLine("Test Directory not available");
            //    Directory.CreateDirectory(DirectoryPath);
            //    Console.WriteLine("Directory Created : " + DirectoryPath);
            //}

          
        }
    }
}
