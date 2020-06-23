using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppStringReverseClass;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleAppStringReverseClass.StringReverseYu_HsuanHuang stringLab = new ConsoleAppStringReverseClass.StringReverseYu_HsuanHuang();
            stringLab.OriginalString = Console.ReadLine();
            Console.WriteLine(stringLab.StringReverse());
        }
    }
}
