using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //**************************************************//
            //1.Create an array of strings. Ask the user to select an index of the Array 
            //and then display the string at that index on the screen.
            //3.Add in a message that displays when the user selects an index that doesn’t exist.


            string[] stringUserArray = new string[7];

            // Add users from a list in an array.
            addUserArrayList("Eric", "Maria", "Catherine", "Samuel", "Lorin", "Stephen", "Daniel");
            

            //Method to add a comma delimited list of users into a string array
            void addUserArrayList(params string[] userArray)
            {

                for (int i = 0; i < userArray.Length; i++ )
                {
                    Console.WriteLine(userArray[i]);
                    stringUserArray[i] = userArray[i];
                }
            }
            
            bool validArraySelection = false;

            // Get the value entered and evaluate it against the array in the list
            // used a while function to evaluate it against anything but a number and 
            // a value between 0 and 5 since there are currently 6 names in the list
            while (validArraySelection == false)
            {
                int totalArrayUsers = stringUserArray.Length - 1;

                // Prompt the user for an index in an array from 0 to 5

                Console.Write("Select an index value from 0 to " + totalArrayUsers + " to return the name associated with that location in the array: ");
                string userArraySelection = Console.ReadLine();

                // Evaluate that the value entered is actually a number and not something 
                //other than a number like a character or empty value
                int userArrayValue;
                bool isUserArrayNumber = int.TryParse(userArraySelection, out userArrayValue);

                // If it is a number evaluate it's within the require number of items in the list
                if (isUserArrayNumber == true)
                {
                    // Variable to take the user input and convert to an int value
                    int userArrayNumber = Convert.ToInt32(userArraySelection);

                    // Evaluate that it's within the parameter of the total items in the array
                    if (userArrayNumber >= 0 && userArrayNumber <= 5)
                    {
                        Console.WriteLine("\nYour selection " + userArrayNumber + " contains the name: " + stringUserArray[userArrayNumber]);
                        validArraySelection = true;
                    }
                    else
                    {
                        //This is a message when the user doesn't enter a value for a valid index number\
                        Console.WriteLine("\nYou didn't enter a value between 0 and " + totalArrayUsers + ".");
                        validArraySelection = false;
                    }
                }
                else
                {
                    // This is a value when the user doesn't enter a number and either enters nothing or a character
                    Console.WriteLine("\nYou did not enter a valid numeric value between 0 and " + totalArrayUsers + ".");
                    validArraySelection = false;
                }
                
            }

            Console.ReadLine();
            
            //Clear the screen for the next part of the exercise
            Console.Clear();

            //**************************************************//
            //2.Create an array of integers. Ask the user to select an index of the Array and then display the integer at that index on the screen.
            //This was pretty easy because I was able to change only a few lines from the previous exercise to account for it being an int instead of a string
            //3.Add in a message that displays when the user selects an index that doesn’t exist.

            int[] intNumberArray = new int[9];

            // Add users from a list in an array.
            addIntArrayList( 0, 1, 5, -1, 200, 1000, -1201012, 1000000, 5234 );


            //Method to add a comma delimited list of users into a string array
            void addIntArrayList(params int[] intArray)
            {

                for (int i = 0; i < intArray.Length; i++)
                {
                    intNumberArray[i] = intArray[i];
                }
            }

            bool validIntArraySelection = false;

            // Get the value entered and evaluate it against the array in the list
            // used a while function to evaluate it against anything but a number and 
            // a value between 0 and 5 since there are currently 6 names in the list
            while (validIntArraySelection == false)
            {
                int totalArrayNumbers = intNumberArray.Length - 1;

                // Prompt the user for an index in an array from 0 to 5

                Console.Write("Select an index value from 0 to " + totalArrayNumbers + " to return the name associated with that location in the array: ");
                string numberArraySelection = Console.ReadLine();

                // Evaluate that the value entered is actually a number and not something 
                //other than a number like a character or empty value
                int intNumberArrayValue;
                bool isNumberArray = int.TryParse(numberArraySelection, out intNumberArrayValue);

                // If it is a number evaluate it's within the require number of items in the list
                if (isNumberArray == true)
                {
                    // Variable to take the user input and convert to an int value
                    int intNumberArrayNumber = Convert.ToInt32(numberArraySelection);

                    // Evaluate that it's within the parameter of the total items in the array
                    if (intNumberArrayNumber >= 0 && intNumberArrayNumber <= 5)
                    {
                        Console.WriteLine("\nYour selection " + totalArrayNumbers + " contains the name: " + intNumberArray[intNumberArrayNumber]);
                        validIntArraySelection = true;
                    }
                    else
                    {
                        //This is a message when the user doesn't enter a value for a valid index number\
                        Console.WriteLine("\nYou didn't enter a value between 0 and " + totalArrayNumbers + ".");
                        validIntArraySelection = false;
                    }
                }
                else
                {
                    // This is a value when the user doesn't enter a number and either enters nothing or a character
                    Console.WriteLine("\nYou did not enter a valid numeric value between 0 and " + totalArrayNumbers + ".");
                    validIntArraySelection = false;
                }

            }

            Console.ReadLine();

            //Clear the screen for the next part of the exercise
            Console.Clear();

            //**************************************************//
            //4.Create a List of strings. Ask the user to select an index of the List and then display the content at that index on the screen.
            //3.Add in a message that displays when the user selects an index that doesn’t exist.

            List<string> stringUser = new List<string>();

            // Add users from a list in an array.
            addUserRange("Eric", "Maria", "Catherine", "Samuel", "Lorin", "Stephen", "Daniel");


            //Method to add a comma delimited list of users into a string array
            void addUserRange(params string[] list)
            {

                for (int i = 0; i < list.Length; i++)
                {
                    stringUser.Add(list[i]);
                }
            }

            bool validUserSelection = false;

            // Get the value entered and evaluate it against the array in the list
            // used a while function to evaluate it against anything but a number and 
            // a value between 0 and 5 since there are currently 6 names in the list
            while (validUserSelection == false)
            {
                int totalUsers = stringUser.Count - 1;

                // Prompt the user for an index in an array from 0 to 5

                Console.Write("Select an index value from 0 to " + totalUsers + " to return the name associated with that location in the array: ");
                string userSelection = Console.ReadLine();

                // Evaluate that the value entered is actually a number and not something 
                //other than a number like a character or empty value
                int userValue;
                bool isUserNumber = int.TryParse(userSelection, out userValue);

                // If it is a number evaluate it's within the require number of items in the list
                if (isUserNumber == true)
                {
                    // Variable to take the user input and convert to an int value
                    int userNumber = Convert.ToInt32(userSelection);

                    // Evaluate that it's within the parameter of the total items in the array
                    if (userNumber >= 0 && userNumber <= 5)
                    {
                        Console.WriteLine("\nYour selection " + userNumber + " contains the name: " + stringUser[userNumber]);
                        validUserSelection = true;
                    }
                    else
                    {
                        //This is a message when the user doesn't enter a value for a valid index number\
                        Console.WriteLine("\nYou didn't enter a value between 0 and " + totalUsers + ".");
                        validUserSelection = false;
                    }
                }
                else
                {
                    // This is a value when the user doesn't enter a number and either enters nothing or a character
                    Console.WriteLine("\nYou did not enter a valid numeric value between 0 and " + totalUsers + ".");
                    validUserSelection = false;
                }

            }

            Console.ReadLine();
        }
    }
}
