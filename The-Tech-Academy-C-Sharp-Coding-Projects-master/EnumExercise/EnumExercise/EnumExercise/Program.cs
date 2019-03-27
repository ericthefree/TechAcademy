using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExercise
{
    class Program
    {
        //1. Create an enum for the days of the week.
        public enum DaysOfTheWeek
        {
            Monday, Tuesday, Wednesday, Thursday,
            Friday, Saturday, Sunday
        }

        static void Main(string[] args)
        {
            bool matchFound = false;

            while (matchFound == false)
            {
                DaysOfTheWeek day;

                //2. Prompt the user to enter the current day of the week.
                Console.Write("Please enter the current day of the week: ");

                //3. Assign the value to a variable of that enum data type you just created.
                string dayEntered = Console.ReadLine();

                //4. Wrap the statement in a try/catch block and have it print "Please 
                //   enter an actual day of the week." to the console if an error occurs.
                try
                {
                    day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), dayEntered);
                
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nPlease enter an actual day of the week.\n");
                    Console.WriteLine(ex.Message);

                }
                if (Enum.TryParse(dayEntered, out day))
                {
                    Console.WriteLine("\nThe value entered: " + dayEntered + " was found within the enum DaysOfTheWeek!");
                    matchFound = true;
                }

            }
            Console.ReadLine();
        }
    }
}
