using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        //1.Create a one-dimensional Array of strings. Ask the user to input some text. Create a loop that goes through
        //  each string in the Array, adding the user’s text to the string.Then create a loop that prints off each string 
        //  in the Array on a separate line.

        string[] stringArray = { "Eric", "Jesse", "Erik", "Mike", "Lindsay" };

        // Prompt the user for some text to add to each name in the array
        Console.Write("Enter some text to add to each name within an array: ");
        string userText = Console.ReadLine();

        // Iterate through each name in the array and print to the console the name plus the text the user entered.
        for (int i = 0; i < stringArray.Length; i++)
        {
            Console.WriteLine(stringArray[i] + " " + userText);
        }

        Console.ReadLine();
        
        //Clear the screen for the next part of the exercise
        Console.Clear();

        // Create a method to evaluate a string of text is a numeric value to use in the following exercises.
        bool UserEntryIsNumber(string userEnteredText)
        {
            int userEntryNumber;
            bool isUserEntryANumber = int.TryParse(userEnteredText, out userEntryNumber);
            return isUserEntryANumber;
        }

        //2.Create an infinite loop.
        //Making the value of itWorks false so the infinite loop doesn't execute and we can move on to the next part of the exercise 

        bool itWorks = false;

        Console.WriteLine("This is part of an infinite loop.  The value of \"itWorks\" needs to be set to true to make it work.");

        while (itWorks == true)
        {
            Console.WriteLine("This is some text for an infinite loop.");
        }

        Console.ReadLine();

        //Clear the screen for the next part of the exercise
        Console.Clear();

        //3.Fix the infinite loop so it will execute.
        itWorks = true;

        //Declare variables to be used in the program
        string userNumber;
        int userNumberConverted;

        Console.WriteLine("This is part of an infinite loop.  The value of \"itWorks\" needs to be set to true to make it work.");
        Console.WriteLine("The current value of \"itWorks\" is " + itWorks + ".");

        while (itWorks == true)
        {
            Console.WriteLine("\nThis is some text for an infinite loop.");
            Console.Write("Enter a 1 for true to iterate through the loop again or 2 for false to exit the program: ");
            userNumber = Console.ReadLine();
           

            if (UserEntryIsNumber(userNumber) == true)
            {
                userNumberConverted = Convert.ToInt32(userNumber);

                if (userNumberConverted == 1)
                {
                    itWorks = true;
                }
                else if (userNumberConverted == 2)
                {
                    itWorks = false;
                    Console.WriteLine("You have set the value to false.  Will exit out of this part of the program.");
                }
                else
                {
                    Console.WriteLine("You didn't enter a 1 or 2.  Setting the value to false and exiting this part of the program.");
                    itWorks = false;

                }
            }
            else
            {
                Console.WriteLine("You didn't enter a 1 or a 2.  Setting \"itWorks\" to false and exiting this part of the program.");
                itWorks = false;
            }
      
        }

        Console.ReadLine();

        //Clear the screen for the next part of the exercise
        Console.Clear();

        //4.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.
        Console.Write("Please enter a numeric value less than 10 to continue iterating through a loop: ");
        userNumber = Console.ReadLine();

        if (UserEntryIsNumber(userNumber) == true)
        {
            userNumberConverted = Convert.ToInt32(userNumber);

            while (userNumberConverted < 10)
            {
                Console.Write("\nPlease enter a value less than (\"<\") 10 to iterate through the loop again: ");
                userNumber = Console.ReadLine();
                if (UserEntryIsNumber(userNumber) == true)
                {
                    userNumberConverted = Convert.ToInt32(userNumber);
                }
                else
                {
                    Console.WriteLine("\nYou didn't enter a numeric value.  Exiting the loop!");
                    userNumberConverted = 10;
                }
            }
            Console.WriteLine("The value " + userNumberConverted + " and the program will exit from here.");

        }
        else
        {
            Console.WriteLine("\nYou didn't enter a numeric value.  Exiting the loop!");
        }

        Console.ReadLine();

        //Clear the screen for the next part of the exercise
        Console.Clear();

        //5.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.
        Console.Write("Please enter a numeric value less than or equal to 10 to continue iterating through a loop: ");
        userNumber = Console.ReadLine();

        if (UserEntryIsNumber(userNumber) == true)
        {
            userNumberConverted = Convert.ToInt32(userNumber);

            while (userNumberConverted <= 10)
            {
                Console.Write("\nPlease enter a value less than or equal to (\"<=\") 10 to iterate through the loop again: ");
                userNumber = Console.ReadLine();
                if (UserEntryIsNumber(userNumber) == true)
                {
                    userNumberConverted = Convert.ToInt32(userNumber);
                    if (userNumberConverted <= 10)
                    {
                        Console.WriteLine("The value you entered " + userNumberConverted + " is <= 10.");
                    }
                    else
                    {
                        Console.WriteLine("The value you entered " + userNumberConverted + " is not <= 10.");
                    }
                }
                else
                {
                    Console.WriteLine("\nYou didn't enter a numeric value.  Exiting the loop!");
                    userNumberConverted = 11;
                }
            }
            Console.WriteLine("The value you entered is " + userNumberConverted + " and the program will exit from here.");

        }
        else
        {
            Console.WriteLine("\nYou didn't enter a numeric value.  Exiting the loop!");
        }
        Console.ReadLine();

        //Clear the screen for the next part of the exercise
        Console.Clear();

        //6.Create a List of strings where each item in the list is unique.  Ask the user to select text to search for in the 
        //  List.  Create a loop that iterates through the list and then displays the index of the array that contains matching 
        //  text on the screen.

        //Create the list of strings
        List<string> stringList = new List<string>() { "Superman", "Batman", "Aquaman", "Wonder Woman", "Ironman", "Hulk", "Spiderman", "Captain America", "Black Widow", "Thor", "The Flash", "Captain Marvel" };

        // Set the initial boolean value as to whether the users string matches any in the list
        bool stringMatched = false;
        string textToFind;

        Console.WriteLine("This exercise will output a list strings containing names of some of the most popular superhero's in movies.");

        //Create a method to output the list of strings for the user to choose to enter from
        void StringListOutput()
        {
            for (int i = 0; i < stringList.Count; i++)
            {
                Console.Write((i + 1) + ": " + stringList[i] + "\n");
            }
        }

        //Create a loop to continue requesting a string from the user until they enter a matching value
        while (stringMatched == false)
        {
            StringListOutput();

            //Create a loop to request a string from the user and test each value in the list whether it matches the user's string

            Console.WriteLine("\nPlease enter a string from the list above to print out it's index value (NOTE: Case matters): ");
            textToFind = Console.ReadLine();

            for (int j = 0; j < stringList.Count; j++)
            {
                if (textToFind == stringList[j])
                {
                    Console.WriteLine("\nThe text you entered " + textToFind + " is at index value: " + j);
                    //8.Add code to that above loop that stops it from executing once a match has been found.
                    stringMatched = true;
                }
            }

            //7.Add code to that above loop that tells a user if they put in text that isn’t in the List.
            // Check if the user entered any values that match any of the strings in order to continue the while loop and check again if they didn't match any strings
            if (stringMatched == false)
            {
                Console.WriteLine("\nThe text you entered " + textToFind + " doesn't match any of the strings in the list.");
                stringMatched = false;
            }
        }

        Console.ReadLine();

        //Clear the screen for the next part of the exercise
        Console.Clear();

        //9.Create a List of strings that has at least two identical strings in the List. Ask the user to select text to search 
        //  for in the List. Create a loop that iterates through the list and then displays the indices of the array that contain 
        //  matching text on the screen.

        // Create the list of strings to compare
        stringList = new List<string> { "This is a string", "This is another string", "Eric", "Erik", "Matching string", "Not a matching string", "Eric", "Matching string", "I love coding in C#", "Eric" };

        int dupCount = 0;
        stringMatched = false;

        //create an outer loop to check if the user enters a string that has a matching string until they do enter one that has another matching string
        while (stringMatched == false)
        {
            StringListOutput();

            //Prompt the user for a string from the list to see if it has a matching string in the list
            Console.Write("\nEnter a string from the list above to search if it has another matching string in the list: ");
            textToFind = Console.ReadLine();

            //Create the loop that prompts the user for a string and checks to see if that string has a matching string in the list
            for (int i = 0; i < stringList.Count; i++)
            {
                if (textToFind == stringList[i])
                {
                    stringMatched = true;
                    dupCount++;
                    Console.WriteLine("The string \"" + textToFind + "\" matches the the string in the list at index value: " + i + "!");
                }
            }
            if (stringMatched == false)
            {
                Console.WriteLine("The string you entered \"" + textToFind + "\" doesn't match any string in the list!");
            }
            else
            {
                if (dupCount > 1)
                {
                    Console.WriteLine("\nThe string you entered \"" + textToFind + "\" had " + dupCount + " matches in the list.");
                }
                else
                {
                    Console.WriteLine("\nThe string you entered \"" + textToFind + "\" had " + dupCount + " match in the list.");
                }
            }

        }

        Console.ReadLine();

        //Clear the screen for the next part of the exercise
        Console.Clear();

        //11.Create a List of strings that has at least two identical strings in the List. Create a foreach loop that evaluates 
        //  each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.
        // Create the list of strings to compare
        stringList = new List<string> { "This is a string", "This is another string", "Eric", "Erik", "Matching string", "Not a matching string", "Eric", "Matching string", "I love coding in C#" };

        List<string> tempList = new List<string>();
        List<string> duplicatesInList = new List<string>();

        foreach (string stringListSearch in stringList)
        {
            if (!tempList.Contains(stringListSearch))
            {
                tempList.Add(stringListSearch);
            }
            else
            {
                duplicatesInList.Add(stringListSearch);
            }
        }

        Console.WriteLine("Below is the list of items from the list without duplicates: ");

        int nonDupCount = 0;
        //Show the list of non duplicates
        foreach (string noDuplicates in tempList)
        {
            nonDupCount++;
            Console.WriteLine(nonDupCount + ": " + noDuplicates);
        }

        Console.WriteLine("\nBelow is the list of items from the list without duplicates: ");

        dupCount = 0;
        //show the list of duplicates
        foreach (string dupListItems in duplicatesInList)
        {
            dupCount++;
            Console.WriteLine(dupCount + ": " + dupListItems);
        }

        Console.ReadLine();
    }
}
