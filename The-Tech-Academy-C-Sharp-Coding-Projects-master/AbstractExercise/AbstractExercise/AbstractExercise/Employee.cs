using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExercise
{
    //3. Create another class called Employee and have it 
    //inherit from the Person class.

    //Interface EX - 2. Have your Employee class from the previous drill 
    //inherit that interface and implement the Quit() method in any way you choose.
    public class Employee : Person, IQuittable
    {
        //4. Implement the SayName() method inside of the Employee class.
        public override void SayName()
        {
            Console.WriteLine("Employee's Name:");
            Console.WriteLine(firstName + " " + lastName);
        }

        public void Quit(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
