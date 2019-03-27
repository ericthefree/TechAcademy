using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Create a const variable
            const string schoolName = "The Tech Academy";

            //2. Create a variable using the keyword "var".
            var newDeveloper = new DeveloperPrep("Eric Freeman", "ericthefree@outlook.com");

            Console.WriteLine("Welcome to " + schoolName + "!");
            Console.WriteLine("We have a new student: " + newDeveloper.StudentName + ".");
            Console.WriteLine("Everyone send an email to \'" + newDeveloper.StudentEmail + "\' and welcome them to the program!");

            Console.ReadLine();
        }
    }

}
