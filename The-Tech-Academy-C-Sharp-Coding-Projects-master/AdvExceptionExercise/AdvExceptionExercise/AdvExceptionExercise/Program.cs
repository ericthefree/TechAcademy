using System;
using System.IO;

namespace AdvExceptionExercise
{
    class Program
    {


        static void Main(string[] args)
        {
            //create a new instance of userage to use the methods for getting the year born
            UserAge yearBorn = new UserAge();

            yearBorn.keepAsking = true;

            while (yearBorn.keepAsking == true)
            {
                //3.Exceptions must be handled using "try .. catch".
                try
                {
                    //call the method to get the year born from teh UserAge class
                    yearBorn.GetYearBorn();

                }

                //4.Display appropriate error messages if user enters zero or negative numbers.
                //Catch an exception when a user enters an invalid value less than 1 or greater than 12 for months
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("You entered a value less than 0 or greater than 12 for month of birhday!\n");
                    LogOutputToFile(DateTime.Now + " : User entry for age was invalid (less than 0 or greater than 12 for month born).");
                    
                }

                //catch an exception when a user enters something other than a whole number(i.e. decimal or characters other than numbers)
                catch (FormatException)
                {
                    Console.WriteLine("You entered an invalid value that was not a number.\n");
                    LogOutputToFile(DateTime.Now + " : User entry was not a valid integer value.");

                }

                catch (ArgumentNullException)
                {
                    Console.WriteLine("You didn't enter a value.\n");
                    LogOutputToFile(DateTime.Now + "User didn't enter a value exception.");
                }

                //5.Display a general message if exception caused by anything else.
                catch (Exception)
                {
                    Console.WriteLine("An error occured!  Please contact your system administrator.\n");
                    LogOutputToFile(DateTime.Now + " : Generic exception occured.");
                    
                }
            }


            Console.ReadLine();
        }

        //create a static method to log file output for errors to a file
        public static void LogOutputToFile(string message)
        {
            System.IO.Directory.CreateDirectory(@"C:\AgeLogDirectory");
            using (StreamWriter logFile = new StreamWriter(@"C:\AgeLogDirectory\LogOutput.txt", true))
            {
                logFile.WriteLine(DateTime.Now + " : " + message);
            }

        }



    }
}
