using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
            // Concatenate three strings.
            string name = "My name is Eric.\n";
            string job = "I work as an SDET in the mobile space.\n";
            string hobby = "I love learning to code in C#.\n";

            string allStrings = String.Concat(name, job, hobby);

            Console.WriteLine("\n" + allStrings + "\n");

            //Convert a string to uppercase.
            string nameUpper = name.ToUpper();

            Console.WriteLine(nameUpper + "\n");

            //Create a Stringbuilder and build a paragraph of text, one sentence at a time.
            StringBuilder myString = new StringBuilder();

            myString.Append("My name is Eric Freeman.");
            myString.AppendLine();
            myString.Append("I work as an SDET on the mobile team for my company.");
            myString.AppendLine();
            myString.Append("In my spare time I love to travel if possible, ");
            myString.AppendLine();
            myString.Append("spend time with my wife and kids and take time to learn");
            myString.AppendLine();
            myString.Append("about software development.");

            string paragraph = myString.ToString();

            Console.WriteLine(paragraph);

            Console.ReadLine();
        }
    }
}
