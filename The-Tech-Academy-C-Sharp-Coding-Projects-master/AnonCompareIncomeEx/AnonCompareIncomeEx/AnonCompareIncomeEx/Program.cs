using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonCompareIncomeEx
{
    class Program
    {

        static void Main(string[] args)
        {
            //The program must start by printing “Anonymous Income Comparison Program” to the screen.
            //It must then print “Person 1” to the screen and get the following details:

            Console.WriteLine("Anonymous Income Comparison Program\n");

            Console.WriteLine("Person 1:\n");
            Console.Write("Enter the hourly rate for person 1: ");
            double hourlyRatePerson1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the hours worked per week for person 1: ");
            double hoursWorkedPerson1 = Convert.ToDouble(Console.ReadLine());
            double annualSalaryPerson1 = hourlyRatePerson1 * hoursWorkedPerson1 * 52;

            Console.WriteLine("\n\nPerson 2:\n");
            Console.Write("Enter the hourly rate for person 2: ");
            double hourlyRatePerson2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the hours worked per week for person 1: ");
            double hoursWorkedPerson2 = Convert.ToDouble(Console.ReadLine());
            double annualSalaryPerson2 = hourlyRatePerson2 * hoursWorkedPerson2 * 52;

            Console.WriteLine("\n\nAnnual salary of Person 1: \n$" + annualSalaryPerson1);
            Console.WriteLine("\nAnnual Salary of Person 2: \n$" + annualSalaryPerson2);
            
            bool per1SalaryMorePer2Salary = annualSalaryPerson1 > annualSalaryPerson2;
            Console.Write("\n\nDoes Person 1 make more money than Person 2? Answer: " + Convert.ToString(per1SalaryMorePer2Salary));

            Console.Read();

        }

    }
}
