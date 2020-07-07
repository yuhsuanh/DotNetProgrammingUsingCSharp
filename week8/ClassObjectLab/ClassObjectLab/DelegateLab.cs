using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectLab
{
    // Declaration
    public delegate void SimpleDelegate();
    class DelegateLab
    { 
            public static void MyFunc()
            {
                Console.WriteLine("I was called by delegate ...");
            }
        public static void MyFunc2()
        {
            Console.WriteLine("2 . I was called by delegate ...");
        }

        public static void DelegateTest()
            {
                // Instantiation
                SimpleDelegate simpleDelegate = new SimpleDelegate(MyFunc);
           // MyFunc();
                simpleDelegate += MyFunc;
            simpleDelegate += MyFunc2; 

            // Invocation
            simpleDelegate();
            }
    }

    public class MyClass
    {
        // Declare no return type.
        public delegate void LogHandler(string message);
        // Check for it is pointing to a function .
        public void Process(LogHandler logHandler)
        {
            if (logHandler != null) logHandler("Process() begin");
            if (logHandler != null) logHandler("Process() end");
        }
    }

    // Test Application to use the defined Delegate
    public class TestApplication
    {
        static void Logger(string s)
        {
            Console.WriteLine(s);
        }

        public static void DelegateChecking()
        {
            MyClass myClass = new MyClass();

            // Crate an instance of the delegate.
            MyClass.LogHandler myLogger = new MyClass.LogHandler(Logger);
            //Test with the next line
            // myLogger -= Logger;
            myClass.Process(myLogger);
        }
    }


    public class FileLogger
    {
        FileStream fileStream;
        StreamWriter streamWriter;
        // Constructor
        public FileLogger(string filename)
        {
            fileStream = new FileStream(filename, FileMode.Create);
            streamWriter = new StreamWriter(fileStream);
        }
        // Member Function which is used in the Delegate
        public void Logger(string s)
        {
            streamWriter.WriteLine(s);
        }
        public void Close()
        {
            streamWriter.Close();
            fileStream.Close();
        }
    }
    public class TestApplicationFileLogger
    {
        public static void DelegateChecking( )
        {
            FileLogger fl = new FileLogger("process.log");
            MyClass myClass = new MyClass();
            MyClass.LogHandler myLogger = new MyClass.LogHandler(fl.Logger);

            
            myClass.Process(myLogger);
            fl.Close();
        }
    }




}
