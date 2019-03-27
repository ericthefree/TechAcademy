using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Inside the Main() method, instantiate an Employee 
            //object with firstName "Sample" and lastName "Student". 
            //Test commit

            Employee employee = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";

            //Call the SayName() method on the object.
            employee.SayName();

            IQuittable iquittable = new Employee();
            iquittable.Quit(employee);

            Console.ReadLine();
        }
    }
}
