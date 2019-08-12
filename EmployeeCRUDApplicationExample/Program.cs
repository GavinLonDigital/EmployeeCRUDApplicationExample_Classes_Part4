using EmployeeComponent;
using EmployeeComponent.Data;
using EmployeeComponent.Views;
using System;
using System.Globalization;

namespace EmployeeCRUDApplicationExample
{
    class Program
    {

        static void Main(string[] args)
        {

            bool endApplication = false;

            Employees employees = new Employees();

            EmployeeRecordsView employeeRecordsView = EmployeeObjectFactory.EmployeeRecordsViewObject(employees);


            while (!endApplication)
            {
                Console.Clear();

                Console.WriteLine(EmployeeCommonOutputText.GetApplicationHeading());

                employeeRecordsView.RunRecordsView();

                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine(EmployeeCommonOutputText.GetInstructions());

                ConsoleKey instructionKey = Console.ReadKey().Key;

                switch (instructionKey)
                {
                    case ConsoleKey.C:
                        EmployeeCreateView employeeCreateView = EmployeeObjectFactory.EmployeeCreateViewObject(employees);
                        employeeCreateView.RunCreateView();
                        break;
                    case ConsoleKey.R:
                        EmployeeReadView employeeReadView = EmployeeObjectFactory.EmployeeReadViewObject(employees);
                        employeeReadView.RunReadView();
                        break;
                    case ConsoleKey.U:
                        Console.Clear();
                        Console.WriteLine("Update functionality not yet implemented.");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D:
                        Console.Clear();
                        Console.WriteLine("Delete functionality not yet implemented.");
                        Console.ReadKey();
                        break;
                    default:

                        endApplication = true;
                        break;
                }
            }



            Console.ReadKey();

        }
    }
}
