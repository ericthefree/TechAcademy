using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Create a list of integers. Ask the user for a number to divide each number in the list 
            //by. Write a loop that takes each integer in the list, divides it by the number the user entered, 
            //and displays the result to the screen.
            List<int> integerList = new List<int>() { 1, 2, 6, 10, 5, 15, 21, 28, 40, 60, 100, 125, 144, 1000, 150000 };

            //5.Now put the loop in a try/catch block.Below and outside of the try/catch block, make the program 
            //    display a message to the display to let you know the program has emerged from the try/catch block 
            //    and continued on with program execution.In the catch block, display the error message to the screen.
            //    Then try various combinations of user input: valid numbers, zero and a string. Ensure the proper 
            //    error messages display on the screen, and that the code after the try/catch block gets executed.

            try
            {

                Console.Write("Please enter a number to divide by each number in the integer list: ");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                foreach (int numberToDivide in integerList)
                {
                    int dividedNumber = numberToDivide / userNumber;
                    Console.WriteLine("The result of " + numberToDivide + " divided by your number " + userNumber + " is: " + dividedNumber);

                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("The value of 0 entered caused an exception in the program.  Please enter a whole number other than 0");
            }
            catch(FormatException ex)
            {
                Console.WriteLine("The value you entered cause an exception in the program. Please enter a whole number.");
            }
            //2.Run that code, entering in non - zero numbers as the user. Look at the displayed results.
            // ******* Output had no errors.  Number in the list divided by a number greater resulted in 0 as a result.
            //3.Run that code, entering in zero as the number to divide by. Note any error messages you get.
            // *******Output error resulted in: "System.DivideByZeroException: 'Attempted to divide by zero.'"
            //4.Run that code, entering in a string as the number to divide by. Note any error messages you get.
            // *******Output error resulted in: System.FormatException: 'Input string was not in a correct format.'

            Console.ReadLine();

        }
    }
}
