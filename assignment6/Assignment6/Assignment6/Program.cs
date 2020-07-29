using Assignment6.model;
using Assignment6.Service;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            string option = "";
            do
            {
                Console.WriteLine("===== Student Management Tool =====");
                Console.WriteLine("Option: 1)Display 2)Insert 3)Update 4)Delete -1)Exit ?");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        displayFunction();
                        break;
                    case "2":
                        insertFunction();
                        break;
                    case "3":
                        updateFunction();
                        break;
                    case "4":
                        deleteStudent();
                        break;
                    case "-1":
                        Console.WriteLine("Thank you for your use!");
                        break;
                    default:
                        Console.WriteLine("No this option...");
                        break;
                }

                Console.WriteLine();
            } while (option != "-1");
        }

        static void displayFunction()
        {
            Console.WriteLine("Displaay option: 1)All 2)Search 3)Number of Student?");
            string displayOption = Console.ReadLine();
            if (displayOption == "1")
            {
                Console.WriteLine("ID | First Name | Last Name | Phone");
                Console.Write(DBService.getStudents());
            }
            else if (displayOption == "2")
            {
                Console.Write("ID: ");
                string idStr = Console.ReadLine();
                int id = 0;
                if (int.TryParse(idStr, out id))
                {
                    Console.Write(DBService.getStudentByID(id));
                }
            }
            else if (displayOption == "3")
            {
                Console.WriteLine("There are {0} student(s).", DBService.geNumberOfStudent());
            }
            else
            {
                Console.WriteLine("You entered the invalid value!!!");
            }
        }

        static void insertFunction()
        {
            Console.WriteLine("Please enter new student information:");
            Console.Write("First name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Phone: ");
            string phone = Console.ReadLine();

            Student student = new Student();
            student.firstName = firstName;
            student.lastName = lastName;
            student.phone = phone;

            DBService.insertStudent(student);
        }

        static void updateFunction()
        {
            Console.WriteLine("Please enter the student ID you want to \"UPDATE\":");

            Console.Write("ID: ");
            string idStr = Console.ReadLine();

            int id = 0;
            if (int.TryParse(idStr, out id))
            {
                Console.Write("First name: ");
                string firstName = Console.ReadLine();
                Console.Write("Last name: ");
                string lastName = Console.ReadLine();
                Console.Write("Phone: ");
                string phone = Console.ReadLine();

                Student student = new Student();
                student.id = id;
                student.firstName = firstName;
                student.lastName = lastName;
                student.phone = phone;

                DBService.updateStudent(student);
            }
            else
            {
                Console.WriteLine("Please enter correct ID value.");
            }
        }

        static void deleteStudent()
        {
            Console.WriteLine("Please enter the student ID you want to \"DELETE\":");

            Console.Write("ID: ");
            string idStr = Console.ReadLine();

            int id = 0;
            if (int.TryParse(idStr, out id))
            {
                DBService.deleteStudent(id);
            }
            else
            {
                Console.WriteLine("Please enter correct ID value.");
            }
        }
    }
}
