using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoIntegersClassEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. In the Main() method of the console app, instantiate the class.
            TwoIntegersClass multiplyTable = new TwoIntegersClass();

            //3. Ask the user to input two numbers, one at a time. Let them know 
            //they need not enter anything for the second number.
            Console.WriteLine("This will print out the multiplication table for each number up to a number you specify.");
            Console.WriteLine("The second (optional) number specifies the number of times (10 if not specified");
            Console.WriteLine("the table will calculate for each number up to the second number.");

            Console.Write("\nPlease enter a number up to the number you want to show the multiplication table to: ");
            int multiplyNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\n(OPTIONAL) Enter a number of times you want to show the multiplication to (10 if not specified): ");
            string timesString = Console.ReadLine();

            //4. Call the method in the class, passing in the one or two numbers entered.
            //this will test if the second user string was empty and pass to the method either 1 or two arguments
            if (timesString != string.Empty)
            {
                int timesNumber = Convert.ToInt32(timesString);
                multiplyTable.MultiplyBy(multiplyNumber, timesNumber);
            }
            else
            {
                multiplyTable.MultiplyBy(multiplyNumber);
            }
            Console.ReadLine();
        }
    }
}
