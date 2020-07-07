using System;

namespace ClassObjectLab
{
    class Program
    {
        static void Main(string[] args)
        { 

            #region delegateLab
            DelegateLab.DelegateTest();

            TestApplication.DelegateChecking();

            TestApplicationFileLogger.DelegateChecking();

            ClockTest.RunClock();

            #endregion 




            Play play = new Play(); 

            ClassA classA = new ClassA();
            classA.PrintTime();

            int i = 3;
            int j = 3;
            int k;
            classA.printNumber(i, ref j, out k);
            Console.Read();

            Employee.NumberOfEmployees = 107;
            Employee e1 = new Employee();
            e1.Name = "Claude Vige";
            e1.ShowDailyActivity(date: DateTime.Now, area: "Barrie");

            System.Console.WriteLine("Employee number: {0}", Employee.Counter);
            System.Console.WriteLine("Employee name: {0}", e1.Name);

            ExceptionLab exLab = new ExceptionLab();
            // exLab.TestThrow();
            try
            {
                exLab.TestCatch();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //exLab.TestThrowNull();
            exLab.Testfinally();
            //exLab.TestNoFinally();
            exLab.TestThrowE();

            Message msg = new Message();
            Console.WriteLine(msg.ToString());

            EmailMessage emailMsg =
                new EmailMessage();
            Console.WriteLine(emailMsg.ToString());

            SMS sms = new SMS();
            sms.Send();
            Console.WriteLine(sms.ToString());

            //instant an abstract class

            //ShapesClass sC = new ShapesClass(5);
            ShapesClass sC = new Square(5);
            sC.ResetWidth();
            Console.WriteLine(sC.width);

            //An interface can't be instantiated directly.

            IMessage iM = new Message();
            // ShapesClass s = new ShapesClass();

        }
    }

    public class Employee
    {
        public static int NumberOfEmployees;
        private static int counter;
        private string name;

        // A read-write instance property:
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // A read-only static property:
        public static int Counter
        {
            get { return counter; }
        }

        // A Constructor:
        public Employee()
        {
            // Calculate the employee's number:
            counter = ++counter + NumberOfEmployees;
        }

        public void ShowDailyActivity(string area, DateTime date)
        {
            Console.WriteLine(area + " ON " + date);
        }
    }
}
