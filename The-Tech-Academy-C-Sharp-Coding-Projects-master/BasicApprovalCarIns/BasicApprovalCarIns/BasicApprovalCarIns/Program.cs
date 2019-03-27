using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicApprovalCarIns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Approval Progam\n");

            Console.Write("What is your age? ");
            int currentAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nHave you ever had a DUI? Please enter \"True\" or \"False\": ");
            bool receivedDUI = Convert.ToBoolean(Console.ReadLine());

            Console.Write("\nHow many speeding tickets do you have? ");
            int howManySpeedTix = Convert.ToInt32(Console.ReadLine());

            //Use the following qualification rules to determine if the applicant qualifies for car insurance:
            //Applicants must be over 15 years old.
            //Applicants must not have any DUI’s.
            //Applicants must not have more than 3 speeding tickets.

            Console.Write("\n\nIs the person qualified? " + ((currentAge > 15) && (receivedDUI == false) && (howManySpeedTix <= 3)));

            Console.ReadLine();

        }
    }
}
