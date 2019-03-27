using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeMethodsEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. In the Main() method of the console app, instantiate the class 
            //and call the one method, passing in an integer, such as 12. Then 
            //display the result to the screen.
            ThreeMethodsClass firstMethod = new ThreeMethodsClass();
            Console.Write("Enter a number to find it's square root rounded to a whole number: ");
            int myInteger = Convert.ToInt32(Console.ReadLine());

            firstMethod.DoSomeMath(myInteger: myInteger);

            //4.In the Main() method of the console app, instantiate the class 
            //and call the second method, passing in a decimal. Display the result 
            //to the screen.
            ThreeMethodsClass secondMethod = new ThreeMethodsClass();
            Console.Write("Enter the radius of a circle to find it's area: ");
            int myRadius = Convert.ToInt32(Console.ReadLine());

            secondMethod.DoSomeMath(myRadius: myRadius);

            //6. In the Main() method of the console app, instantiate the class 
            //and call the third method, passing in a string that equates to an 
            //integer. Display the result to the screen.
            ThreeMethodsClass thirdMethod = new ThreeMethodsClass();
            Console.Write("Enter a number to be divided by 2 and find the remainder: ");
            string myDivisionValue = Console.ReadLine();

            thirdMethod.DoSomeMath(myUserValue: myDivisionValue);

            Console.ReadLine();
        }
    }
}
