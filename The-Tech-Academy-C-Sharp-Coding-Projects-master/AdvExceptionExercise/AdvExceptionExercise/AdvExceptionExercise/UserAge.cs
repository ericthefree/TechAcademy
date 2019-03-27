using System;
using System.IO;

namespace AdvExceptionExercise
{
    public class UserAge
    {
        public int Age { get; set; }
        public int Month { get; set; }
        public bool keepAsking { get; set; }

        public void GetYearBorn()
        {
            bool validAge = false;
            int userAge = 0;
            bool validMonth = false;
            int userMonth = 0;

            //Get user input for the users age
            while (!validAge)
            {
                var logOutput = new UserAge();

                //1. Ask the user for his age.
                Console.Write("Please enter your age: ");
                validAge = int.TryParse(Console.ReadLine(), out userAge);
                
                //The user didn't enter a numeric value. 
                if (!validAge)
                {
                    Console.WriteLine("You didn't enter a numeric value!");
                    Console.WriteLine("Please enter a whole number for your age...no decimal values!");
                    throw new FormatException("User entry for age was invalid!  Not a numeric value.");
  
                }
                //The user entered an age less than or equal to 0. 
                else if (userAge <= 0)
                {
                    Console.WriteLine("You entered a value less than or equal to 0");
                    Console.WriteLine("Please enter a whole number greater than 0 for your age...no decimal values: ");
                    throw new ArgumentOutOfRangeException("User entry for age was less than or equal to 0!");

                }
                validAge = true;

                //Getting the month a user was born and checking for a valid numeric entry for month born
                while (validAge == true && !validMonth)
                {
                    Console.Write("\nPlease enter the number of the month you were born: ");
                    validMonth = int.TryParse(Console.ReadLine(), out userMonth);

                    //The user didn't enter a numeric value. 
                    if (!validMonth)
                    {
                        Console.WriteLine("Please enter a numeric value between 1 and 12 that is a whole number!");
                        throw new FormatException("User entry for month was invalid.  Not a value between 1 and 12.");
                    }

                    //check to see if the user entered a value between 1 and 12
                    else if (userMonth < 1 || userMonth > 12)
                    {
                        Console.WriteLine("You enter an invalid number for the month you were born!");
                        Console.WriteLine("Please enter a valid number for the month you were born between 1 and 12.");
                        validMonth = false;
                        throw new ArgumentOutOfRangeException("User entry for month was less than 1 or greater than 12.");

                    }
                    validMonth = true;

                }

            }

            //if the user is over 100 years, tell them they are OLD!
            if (userAge > 100)
            {
                Console.WriteLine("\nMan, you are OLD!  You were born a REALLY long time ago!");

            }

            //writing out the current year to console so I can see the value here
            Console.WriteLine("\nThe current year is {0}", DateTime.Now.Year);
            
            //create a variable for year born based solely on the current year minus their age
            int yearBorn = DateTime.Now.Year - userAge;
            keepAsking = false;

            //If the month they were born is greater than the current year's month we need to
            //subtract a year from the yearBorn variable to account for they since the they are 
            //ALMOST a year older (i.e. I'm 49 born in april...the year is now 2019 in january
            //simply subracting my age won't give the correct year born because it didn't account
            //for the month i was born
            if (userMonth > DateTime.Now.Month)
            {
                yearBorn -= 1;
            }

            //2.Display the year user born.
            Console.WriteLine("You were born in: " + yearBorn);
            //all valid entries have been entered, so we can quit now...setting to false
            keepAsking = false;
        }



    }

}
