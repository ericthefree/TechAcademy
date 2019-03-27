using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 5 + 10;
            Console.WriteLine("Five plus ten = " + total.ToString());
            int otherTotal = 12 + 22;
            int combined = total + otherTotal;
            Console.WriteLine(combined);

            int difference = 10 - 5;
            Console.WriteLine("Five minus ten = " + difference.ToString());

            int product = 10 * 5;
            Console.WriteLine(product);

            int quotient = 100 / 5;
            Console.WriteLine(quotient);
            quotient = 100 / 17;
            Console.WriteLine(quotient);

            double doubleQuotient = 100.0 / 17.0;
            Console.WriteLine(doubleQuotient);

            int remainder = 10 % 2;
            Console.WriteLine(remainder);

            int oddRemainder = 11 % 2;
            Console.WriteLine(oddRemainder);

            bool trueOrFalse = 12 > 5;
            Console.WriteLine(trueOrFalse.ToString());

            bool trueOrFalse2 = 12 < 5;
            Console.WriteLine(trueOrFalse2.ToString());

            int roomTemperature = 70;
            int currentTemperature = 72;

            bool isWarm = currentTemperature > roomTemperature;
            Console.WriteLine(isWarm);

            bool isWarm2 = currentTemperature >= roomTemperature;
            Console.WriteLine(isWarm2);

            bool isWarm3 = currentTemperature == roomTemperature;
            Console.WriteLine(isWarm3);

            bool isWarm4 = currentTemperature != roomTemperature;
            Console.WriteLine(isWarm4);


            Console.ReadLine();
       
        }
    }
}
