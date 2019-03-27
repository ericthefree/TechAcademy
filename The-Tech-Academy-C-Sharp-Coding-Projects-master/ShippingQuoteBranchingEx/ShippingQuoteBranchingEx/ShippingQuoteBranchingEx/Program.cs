using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuoteBranchingEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //The first line of the program must be: “Welcome to Package Express. Please follow the instructions below.”
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\n");

            //The user must then be prompted for the package weight.
            Console.Write("Please enter the package weight: ");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            //If the weight is greater than 50, display the error message, “Package too heavy to be shipped via Package Express.Have a good day.” At this point the program would end.
            if (packageWeight > 50)
            {
                Console.WriteLine("\nPackage is too heavey to be shipped via Package Express.  Have a good day!\n");
            }

            else
            {
                //The user must then be prompted for the package width.
                Console.Write("\nPlease enter the package width: ");
                double packageWidth = Convert.ToDouble(Console.ReadLine());

                //Then the package height.
                Console.Write("Please enter the package height: ");
                double packageHeight = Convert.ToDouble(Console.ReadLine());

                //Then the package length.
                Console.Write("Please enter the package length: ");
                double packageLength = Convert.ToDouble(Console.ReadLine());

                //If the sum of the dimensions is greater than 50, display the error message, “Package too big to be shipped via Package Express.” At this point the program would end.
                double sumDimensions = packageHeight + packageLength + packageWidth;

                if (sumDimensions > 50)
                {
                    Console.WriteLine("\nPackage is too big to be shipped via Package Express!");
                }
                else
                {
                    //The sum total of dimensions are then multiplied by the weight and divided by 100.
                    //The result of that calculation is the quote.
                    //Display the quote to the user as a dollar amount.

                    double quote = sumDimensions * packageWeight / 100;
                    string formatQuote = string.Format("{0:C}", quote);
                      

                    Console.Write("\nThe total amount for shipping your package is: " + formatQuote);
                }

            }
            Console.ReadLine();
        }
    }
}
