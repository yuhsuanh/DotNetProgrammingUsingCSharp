using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print information
            Console.WriteLine("Which city would you like to go?");
            Console.WriteLine("1.Barrie; 2.Toronto; 3.New York");
            //Get input from user
            var city = Console.ReadKey();


            //Instantiate ProcessStartInfo 
            System.Diagnostics.ProcessStartInfo processStartInfo = new System.Diagnostics.ProcessStartInfo();
            //Link  processStartInfo to this exe file path
            processStartInfo.FileName = @"C:\Users\happy\Documents\Visual Studio Projects\Comp1098Week2\ConsoleAppLab1\bin\Debug\ConsoleAppLab1.exe";
            //Put processStartInfo to System diagnostics
            System.Diagnostics.Process.Start(processStartInfo);
            Console.ReadKey();

        }
    }
}
