using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompanyExample
{

    //GENERIC EX: 3. Create another class called Employee and have it 
    //inherit from the Person class. Give the Employee class 
    //a property called Id and have it be of data type int.

    //1. Make the Employee class take a generic type parameter.
    public class Employee<T> : Person//, IQuittable
    {
        public List<T> Employees { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        //2. Add a property to the Employee class called "things" and 
        //have its data type be a generic list matching the generic type 
        //of the class.
        public List<T> Things { get; set; }

        //commenting out the method I created for the operator overload exercise 
        //since it missed the point of the exercise
        //public void EvaluateUserId(Employee user1, Employee user2)
        //{
        //    Employee employee = new Employee();
        //    if(user1.Id == user2.Id)
        //    {
        //        Console.WriteLine("The user ID's match!");

        //    }
        //    else
        //    {
        //        Console.WriteLine("The user ID's do not match!");
        //    }
        //}

        //Commenting this section out so I can instantiate the generic class
        //Overload the "==" operator so it checks if two Employee objects are 
        //equal by comparing their Id property.
        //public static bool operator == (Employee first, Employee second)
        //{
        //    bool match = false;
        //    if ( first.Id == second.Id )
        //    {
        //        Console.WriteLine("The user ID's match! The return result of the comparison \'==\' is true!");
        //        match = true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("The user ID's do not match! The return result of the comparison \'==\' is false!");
        //    }
        //    return match;
        //}

        //public static bool operator != (Employee first, Employee second)
        //{
        //    bool match = false;
        //    if (first.Id != second.Id)
        //    {
        //        Console.WriteLine("The user ID's do not match! The return result of the comparison \'!=\' is true!");
        //        match = true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("The user ID's match! The return result of the comparison \'!=\' is false!");

        //    }
        //    return match;
        //}

        //public override bool Equals(object obj)
        //{
        //    return base.Equals(obj);
        //}

        //public override int GetHashCode()
        //{
        //    return base.GetHashCode();
        //}

        //Commenting this section out so I can instantiate the generic class
        //POLYMORPHEX 2. Have your Employee class from the previous drill inherit that interface 
        //and implement the Quit() method in any way you choose.
        //public void Quit(Employee employee)
        //{
        //    Console.WriteLine("\n" + employee.FirstName + " " + employee.LastName + " has quit the company!  We are sad to see them go.");
        //}
    }
}
