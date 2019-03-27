using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.Takes an input from the user, multiplies it by 50, and prints the result to the console. (Note: make sure your code can take inputs larger than 10,000,000).
            Console.Write("Enter a number to be multiplied by 50: ");
            double largeNumberFromUser = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nThe result of your number, " + largeNumberFromUser + ", multiplied times 50 is: " + largeNumberFromUser * 50 + "\n\n");

            //2.Takes an input from the user, adds 25 to it, and prints the result to the console.
            Console.Write("Enter a number to have 25 added to it: ");
            int numberToBeAdded = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nThe result of your number, " + numberToBeAdded + ", having 25 added to it is: " + (numberToBeAdded + 25) + "\n\n");

            //3.Takes an input from the user, divides it by 12.5, and prints the result to the console.
            Console.Write("Enter a number to be divided by 12.5: ");
            double numberToBeDivided = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nThe result of your number, " + numberToBeDivided + ", and divided by 12.5 is: " + (numberToBeDivided / 12.5) + "\n\n");

            //4.Takes an input from the user, checks if it is greater than 50, and prints the true / false result to the console.
            Console.Write("Enter a number to see if it's greater than 50: ");
            int numberIsGreater = Convert.ToInt32(Console.ReadLine());
            bool userNumberBoolCheck = numberIsGreater > 50;
            Console.WriteLine("\nThe number you entered " + numberIsGreater + " is greater than 50 (True or False): " + Convert.ToString(userNumberBoolCheck) + "\n\n");

            //5.Takes an input from the user, divides it by 7, and prints the remainder to the console(tip: think % operator).
            Console.Write("Enter a number to divide by 7 and see the remainder output: ");
            double numberToRemainder = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nThe remainder of your number " + numberToRemainder + " divided by 7 is: " + (numberToRemainder % 7) + "\n\n");

            Console.ReadLine();

        }
    }
}
