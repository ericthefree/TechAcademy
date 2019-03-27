using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompanyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.Inside of the Main method, instantiate and initialize 
            //an Employee object with a first name of "Sample" and a 
            //last name of "Student".

            //GENERIC EX: 3. Instantiate an Employee object with type "string" as its generic 
            //parameter.Assign a list of strings as the property value of Things.
            Employee<string> employeeNames = new Employee<string>();
            employeeNames.Things = new List<string>() { "Eric Freeman", "Mike Shapiro", "Dan Christie", "Eric Gross" };

            //GENERIC EX: 4. Instantiate an Employee object with type "int" as its generic 
            //parameter.Assign a list of integers as the property value of Things.
            Employee<int> employeeIds = new Employee<int>();
            employeeIds.Things = new List<int>() { 1001, 1002, 1003, 1004 };

            //GENERIC EX: 5. Create a loop that prints all of the Things to the Console.
            for(int i = 0; i < employeeNames.Things.Count; i++)
            {
                Console.WriteLine("The current name for index " + i + " is: " + employeeNames.Things[i]);

            }

            Console.WriteLine();

            for(int i = 0; i< employeeIds.Things.Count; i++)
            {
                Console.WriteLine("The current ID for index " + i + " is: " + employeeIds.Things[i]);
            }

            //Commenting this section out so I can instantiate the generic class
            //Employee employee = new Employee();
            //employee.FirstName = "Sample";
            //employee.LastName = "Student";

            //Employee employee1 = new Employee();
            //employee1.Name = "Sample1 Student1";
            //employee1.Id = 10001;

            //Employee employee2 = new Employee();
            //employee2.Name = "Sample2 Student2";
            //employee2.Id = 10002;

            //Employee employee3 = new Employee();
            //employee3.FirstName = "Sample3 Student3";
            //employee3.Id = 10001;

            //Console.WriteLine(employee1 == employee2);

            //Console.WriteLine(employee1 == employee3);

            //Console.WriteLine(employee1 != employee2);

            //Console.WriteLine(employee1 != employee3);

            //commenting out the call to the method I created for the operator 
            //overload exercise since it missed the point of the exercise
            //employee.EvaluateUserId(employee1, employee2);
            //employee.EvaluateUserId(employee1, employee3);

            //Commenting this section out so I can instantiate the generic class
            //5. Call the superclass method SayName() on the Employee object.
            //employee.SayName();

            //Commenting this section out so I can instantiate the generic class
            //POLYMORPHEX 3. Use polymorphism to create an object of type IQuittable
            //and call the Quit() method on it. Hint: an object can be of an interface 
            //type if it implements that specific interface.
            //IQuittable quitter = new Employee();
            //quitter.Quit(employee);

            Console.ReadLine();
        }
    }
}
