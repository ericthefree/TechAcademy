using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantiateClassEx
{
    public class MyVoidClass
    {
        //1. Create a class. In that class, create a void method that takes two integers as parameters.
        //Have the method do a math operation on the first integer and display the second integer to the screen.
        public void MyMathOp(int mathOp, int displayOp)
        {
            double powerOf = Math.Pow(mathOp, 10);
            Console.WriteLine("Your first integer " + mathOp + " to the power of 10 is: " + powerOf);
            Console.WriteLine("The second integer you entered is: " + displayOp);

        }

    }
}
