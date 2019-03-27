using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodsExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.Create a class. In that class, create three methods, each of which
            //will take one integer parameter in and return an integer.The methods
            //should do some math operation on the received parameter.Put this class
            //in a separate.cs file in the application.
            //2. In the Main() program, ask the user what number they want to do the
            //math operations on.
            //3. Call each method in turn, passing the user input to the method.
            //Display the returned integer to the screen.
            Console.WriteLine("This will take a number you enter and perform 3 math operations on the number.");
            Console.WriteLine("The first operation will return the remainder of dividing by 2.");
            Console.WriteLine("The second operation will return the doubled value of your number.");
            Console.WriteLine("The third operation will return the value of your number added to a random number between 1 and 100");

            try
            {
                Console.Write("\nEnter a whole number to perform the above operations on that number: ");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                //Get the values of each operation from the math operations
                MathOp mathOperation = new MathOp();
                int mathEven = mathOperation.Even(userNumber);
                int mathDouble = mathOperation.DoubleNumber(userNumber);
                int mathRandom = mathOperation.RandomAdd(userNumber);

                //Output the first operation as even or odd based on the returned value
                if (mathEven == 0)
                {
                    Console.WriteLine("The value of your number " + userNumber + " divided by 2 returned a remainder of " + mathEven + " and is an even number.");
                }
                else
                {
                    Console.WriteLine("The value of your number " + userNumber + " divided by 2 returned a remainder of " + mathEven + " and is an odd number.");
                }

                //Output the second operation where the number is doubled
                Console.WriteLine("\nThe value of your number " + userNumber + " doubled is: " + mathDouble + ".");

                //Output the third operation where the number is added to a random number
                Console.WriteLine("\nThe value of your number " + userNumber + " added to a random number between 1 and 100 is: " + mathRandom + ".");
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("The value you entered was not a valid integer.");
            }
            finally
            {
                Console.ReadLine();
            }
        }

    }
}
