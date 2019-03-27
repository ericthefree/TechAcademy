using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise
{
    public class MathFunctions
    {
        //1. Create a class. In that class, create a void method that outputs an integer. 
        //Have the method divide the data passed to it by 2.

        public void DivideBy(out int myDividedNumber)
        {
            //3. Have the user enter a number. Call the method on that number. 
            //Display the output to the screen. It should be the entered number, divided by two.
            Console.Write("Enter an integer to be divided by 2: ");
            int numberToDivide = Convert.ToInt32(Console.ReadLine());

            myDividedNumber = numberToDivide / 2;

            Console.WriteLine("\nYour number " + numberToDivide + " divided by 2 is: " + myDividedNumber);
        }

        //4. Create a method with output parameters.
        public void MultiplyNumbers(out int firstNumber, out int secondNumber)
        {
            Console.Write("\nEnter the first number used to multiply: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter the second number used to multiply: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nThe first number " + firstNumber + " multiplied by the second number " + secondNumber + " is: " + (firstNumber * secondNumber));

        }

        //5. Overload a method.
        public int DivideBy(int numberToDivide, int numberToDivideBy)
        {
            int myDividedNumber = numberToDivide / numberToDivideBy;

            Console.WriteLine("\nYour number " + numberToDivide + " divided by " + numberToDivideBy + " is: " + myDividedNumber);

            return myDividedNumber;
        }
    }
}
