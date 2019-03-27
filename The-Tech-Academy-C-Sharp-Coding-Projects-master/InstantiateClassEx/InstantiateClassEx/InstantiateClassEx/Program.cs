using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantiateClassEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. In the Main() method of the console app, instantiate the class.
            MyVoidClass myVoidClass = new MyVoidClass();
            
            Console.Write("Enter two integer values separated by a space \' \': ");
            string[] userValues = Console.ReadLine().Split(' ');
            int firstValue = int.Parse(userValues[0]);
            int secondValue = int.Parse(userValues[1]);

            //3. Call the method in the class, passing in two numbers.
            Console.WriteLine("\nThis is an example where values are passed in with just the integers given.");
            myVoidClass.MyMathOp(firstValue, secondValue);

            //4. Call the method in the class, specifying the parameters by name.
            Console.WriteLine("\nThis is an example where values are passed in with parameters by name.");
            myVoidClass.MyMathOp(mathOp: firstValue, displayOp: secondValue);

            Console.ReadLine();

        }      
    }
}
