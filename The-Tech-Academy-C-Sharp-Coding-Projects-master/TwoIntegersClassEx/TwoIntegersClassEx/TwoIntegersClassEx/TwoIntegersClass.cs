using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoIntegersClassEx
{
    public class TwoIntegersClass
    {
        //1. Create a class. In that class, create a method that takes 
        //two integers as parameters.Make one of them optional. Have the 
        //method do a math operation and return a integer result.

        public void MultiplyBy(int firstInteger, int optionalInteger = 10)
        {
            //This will print out a multiplication table for the user based
            //on the first input string (how many lines below it) and the optional
            //string default=10 across

            Console.WriteLine("\nBelow is the multiplication table:");

            //Down
            for (int i = 1; i <= firstInteger; i++)
            {
                Console.Write("\n");

                //across
                for (int j = 1; j <= optionalInteger; j++)
                {
                    Console.Write("{0,5}", i * j);
                }

            }
           
        }
    }
}
