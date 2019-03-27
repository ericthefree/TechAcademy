using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Prints the current date and time to the console.
            Console.WriteLine("The current time right now is: " + DateTime.Now + "\n");

            //2.Asks the user for a number.
            Console.Write("Please enter a number of hours to check the timespan: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            //3.Prints to the console the exact time it will be in X 
            //hours, X being the number the user entered in step 2.
            DateTime currentTime = DateTime.Now;
            DateTime hoursLater = currentTime.AddHours(userNumber);
            Console.WriteLine("\nThe time " + userNumber + " hours from now will be: " + hoursLater);

            Console.ReadLine();
        }
    }
}
