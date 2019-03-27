using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportExercise
{
    class Program
    {
        static void Main()
        {

            // This is an exercise to create a daily report for students at the Tech Academy

            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report\n");

            //Ask some questions from the user and assigned to well named variables
            Console.WriteLine("What course are you on?");
            string currentCourse = Console.ReadLine();
            Console.WriteLine("\nWhat page number are you currently on?");
            string currentPage = Console.ReadLine();
            int currentPageNumber = Convert.ToInt32(currentPage);
            Console.WriteLine("\nDo you need help with anything?  Please answer \"true\" or \"false\"");
            string needsHelp = Console.ReadLine();
            bool studentNeedsHelp = Convert.ToBoolean(needsHelp);
            Console.WriteLine("\nWere there any positive experiences you'd like to provide?  Please be specific");
            string positiveFeedback = Console.ReadLine();
            Console.WriteLine("\nIs there any other feedback you'd like to provide?  Please be specific.");
            string otherFeedback = Console.ReadLine();
            Console.WriteLine("\nHow many hours did you study today?");
            string hoursStudiedToday = Console.ReadLine();
            int numberHoursStudied = Convert.ToInt32(hoursStudiedToday);

            Console.WriteLine("\nThank you for your answers.  An instructor will respond to this shortly.  Have a great day!\n");

            Console.WriteLine("You are currently taking the  \"" + currentCourse + "\" course.");
            Console.WriteLine("You are currently on page: " + currentPageNumber);
            Console.WriteLine("You said your answer to needing help was: \"" + studentNeedsHelp + "\"");
            Console.WriteLine("When asked if you had any positive experiences you responded with, \n\"" + positiveFeedback + "\"");
            Console.WriteLine("When asked for any other feedback you responded with, \n\"" + otherFeedback + "\"");
            Console.WriteLine("You said you have studied " + numberHoursStudied + " hours today.");
            Console.ReadLine();

        }
    }
}
