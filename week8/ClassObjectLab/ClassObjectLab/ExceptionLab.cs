using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectLab
{
    class ExceptionLab
    {
        public void TestThrow()
        {
            CustomException ex =
                new CustomException("Custom exception in TestThrow()");
            throw ex;
        }

        public void TestCatch()
        {
             

            try
            {
                TestThrow();
            }
            catch (CustomException ex)
            {
                System.Console.WriteLine(ex.ToString());
                throw  ;
            }
        }

        public void TestThrowNull()
        {

            string s = Console.ReadLine();
            try
            { 
                int i = int.Parse(s);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("You need to enter a value");
            }
            catch (FormatException)
            {
                Console.WriteLine("{0} is not a valid number. Please try again", s);
            }

        }

        public void Testfinally()
        {
           
                string s = Console.ReadLine();
                try
                {
                    int i = int.Parse(s);
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("You need to enter a value");
                }
                catch (FormatException)
                {
                    Console.WriteLine("{0} is not a valid number. try again", s );
                }
                finally
                {
                    Console.WriteLine("Program complete.");
                } 
            
        }

        public void TestNoFinally()
        {
            string s = Console.ReadLine();
            try
            {
                int i = int.Parse(s);
                if (i == 0) Environment.FailFast
                       ("Special number entered");
            }
            finally
            {
                Console.WriteLine("Program complete.");
            }
            Console.ReadLine();

        }


        /// <summary>
        /// They both rethrow the current exception object, but “throw e;” resets parameters on it like the Exception.StackWalk property.
        /// </summary>
        public void TestThrowE()
        {
            try
            {
                TestCatch();
            }
            catch (CustomException ex)
            {
                System.Console.WriteLine(ex.ToString());
                throw ex;
                //throw;
            }
        }
    }

    class CustomException : Exception
    {
        public CustomException(string message)
        {

        }
    }
    



}
