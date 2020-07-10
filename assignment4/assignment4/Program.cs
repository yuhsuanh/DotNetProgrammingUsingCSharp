using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            string json = @"{
                                'name': 'Yu-Hsuan Huang',
                                'email': '200443723@student.georgianc.on.ca',
                                'address': '1 Georgian Drive, Barrie, ON'
                            }";

            YuHsuanHuangJson yuHsuanHuangJson = new YuHsuanHuangJson(json);
            Student student = yuHsuanHuangJson.JSONDeserialization();

            Console.WriteLine("Name: " + student.name);
            Console.WriteLine("Email: " + student.email);
            Console.WriteLine("Address: " + student.address);
            Console.ReadLine();

        }
    }
}
