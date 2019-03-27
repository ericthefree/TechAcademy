using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. In the Main() method, instantiate that class.
            MathFunctions mathFunctions = new MathFunctions();

            //3. Have the user enter a number. Call the method on that number. 
            //Display the output to the screen. It should be the entered number, 
            //divided by two.
            mathFunctions.DivideBy(out int dividedNumber);

            //call the function to get the value of the numbers
            mathFunctions.MultiplyNumbers(out int firstNumber, out int secondNumber);

            //call the overloaded function to get the return value
            Console.Write("\nEnter a number to be divided: ");
            int myNumberToDivide = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter a number to divide by the first number you entered: ");
            int myNumberToDivideBy = Convert.ToInt32(Console.ReadLine());
            mathFunctions.DivideBy(myNumberToDivide, myNumberToDivideBy);

            //Prompt for 3 values to be multiplied in the static class
            Console.Write("\nEnter three integer values separated by a space \' \': ");
            string[] userValues = Console.ReadLine().Split(' ');
            int firstValue = int.Parse(userValues[0]);
            int secondValue = int.Parse(userValues[1]);
            int thirdValue = int.Parse(userValues[2]);

            double totalValueMultiplied = MyMathClass.MultiplyNumbersTogether(firstValue, secondValue, thirdValue);

            Console.ReadLine();
        }
    }

    //6. Declare a class to be static.
    static class MyMathClass
    {
        public static double MultiplyNumbersTogether(int firstValue, int secondValue, int thirdValue)
        {
            double totalValue = Convert.ToDouble(firstValue * secondValue * thirdValue);

            Console.WriteLine("\nThe total value by multiplying the first number " + firstValue + ", the second number " + secondValue + " and the third number " + thirdValue + " is: " + (firstValue * secondValue * thirdValue));
            return totalValue;
        }
    }


}
