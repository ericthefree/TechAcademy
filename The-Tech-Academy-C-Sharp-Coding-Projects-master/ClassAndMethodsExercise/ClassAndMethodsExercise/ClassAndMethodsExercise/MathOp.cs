using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Create a class. In that class, create three methods, each of which will 
//take one integer parameter in and return an integer. The methods should do some 
//    math operation on the received parameter. Put this class in a separate .cs 
//    file in the application.
namespace ClassAndMethodsExercise
{
    public class MathOp
    {
        //Create three methods that take an integer parameter and return an integer
        public int Even(int even)
        {
            int addTotal = even % 2;
            return addTotal;
        }

        public int DoubleNumber(int halfNumber)
        {
            int numberDoubled = halfNumber * 2;
            return numberDoubled;
        }

        public int RandomAdd(int randAdd)
        {
            Random randNumber = new Random();
            int randResult  = randNumber.Next(1, 100);
            int randomTotal = randAdd + randResult;
            return randomTotal;
        }

    }
}
