using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectLab
{
    class ClassA
    {
        /// <summary>
        /// Print time on screen
        /// </summary>
        public void PrintTime()
        {
            Console.WriteLine(DateTime.Now);  
        }

        public void printNumber(int i,ref int j,out int k)
        {
            i++;
            Console.WriteLine(i);
            j++;
            Console.WriteLine(j); 
            k = 2;
            Console.WriteLine(k);
        }
    }
}
