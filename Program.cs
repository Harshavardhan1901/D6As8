using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salary Calculation System");
            Console.WriteLine("========================");

            Console.WriteLine("Choose Employee Type:");
            Console.WriteLine("1. HR");
            Console.WriteLine("2. Admin");
            Console.WriteLine("3. Software Developer");
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                CalculateHrSalary();
            }
            else if (choice == 2)
            {
                CalculateAdminSalary();
            }
            else if (choice == 3)
            {
                CalculateSoftwareDeveloperSalary();
            }
            else
            {
                Console.WriteLine("Invalid choice!");
            }
            Console.ReadKey();
        }

        static void CalculateHrSalary()
        {
            Console.Write("Enter working hours: ");
            int workingHours = int.Parse(Console.ReadLine());

            Console.Write("Enter number of working days: ");
            int numWorkingDays = int.Parse(Console.ReadLine());

            int salary = workingHours * numWorkingDays * 100 + 3000;
            Console.WriteLine("Monthly Salary: $" + salary);
            Console.ReadKey();
        }

        static void CalculateAdminSalary()
        {
            Console.Write("Enter working hours: ");
            int workingHours = int.Parse(Console.ReadLine());

            Console.Write("Enter number of working days: ");
            int numWorkingDays = int.Parse(Console.ReadLine());

            Console.Write("Enter number of project handles: ");
            int projectHandles = int.Parse(Console.ReadLine());

            int salary = workingHours * numWorkingDays * 100 + projectHandles * 3000;
            Console.WriteLine("Monthly Salary: $" + salary);
            Console.ReadKey();
        }
        

        static void CalculateSoftwareDeveloperSalary()
        {
            Console.Write("Enter working hours: ");
            int workingHours = int.Parse(Console.ReadLine());

            Console.Write("Enter number of working days: ");
            int numWorkingDays = int.Parse(Console.ReadLine());

            Console.Write("Enter number of project handles: ");
            int projectHandles = int.Parse(Console.ReadLine());

            Console.Write("Enter number of extras: ");
            int extras = int.Parse(Console.ReadLine());

            int salary = workingHours * numWorkingDays * 100 + projectHandles * 3000 + extras * 2000;
            Console.WriteLine("Monthly Salary: $" + salary);
            Console.ReadKey();
        }
    }
}
