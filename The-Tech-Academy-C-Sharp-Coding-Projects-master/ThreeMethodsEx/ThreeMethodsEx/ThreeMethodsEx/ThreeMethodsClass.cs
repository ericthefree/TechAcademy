using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeMethodsEx
{
    //1. Create a class. In that class, create a method that will 
    //take in an integer, do a math operation to it and then return 
    //the answer as an integer.
    public class ThreeMethodsClass
    {
        public int DoSomeMath(int myInteger)
        {
            double doubleValue = Math.Sqrt(myInteger);
            int intValue = Convert.ToInt32(doubleValue);
            Console.WriteLine("\nThe square root of your value " + myInteger + " is: " + intValue + "\n");
            return intValue;
        }

        //3. Add a second method to the class, with the same name, 
        //that will take in a decimal, do a different math 
        //operation to it and then return the answer as an integer.
        public float DoSomeMath(float myRadius)
        {
            float circleArea = myRadius * myRadius * (3.14f);
            Console.WriteLine("\nThe area of the circle with a radius of " + myRadius + " is: " + circleArea + "\n");
            return circleArea;
        }

        //5. Add a third method to the class, with the same name, 
        //that will take in a string, convert it to an integer if 
        //possible, do a different math operation to it and then 
        //return the answer as an integer.

        public int DoSomeMath(string myUserValue)
        {
            int myIntegerValue = Convert.ToInt16(myUserValue);
            int dividedValue = myIntegerValue / 2;
            int remainderValue = myIntegerValue % 2;

            Console.WriteLine("\nYour value " + myIntegerValue + " divided by 2 is: " + dividedValue + " with a remainder of " + remainderValue + "\n");

            //return only the remainder
            return remainderValue;
        }

    }
}
