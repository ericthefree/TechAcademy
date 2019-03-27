using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIoExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a while loop to continue asking the user for a number to write
            //to the file
            bool continueAsking = true;
            
            while (continueAsking == true)
            {
                //1.Ask a user for a number.
                Console.Write("Please enter an integer value: ");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                //2.Log that number to a text file.  (You may need to change the directory.
                //Create the directory if it doesn't exist
                System.IO.Directory.CreateDirectory(@"C:\LogDirectory");

                using (StreamWriter file = new StreamWriter(@"C:\LogDirectory\LogNumbers.txt", true))
                {
                    file.WriteLine("You entered the number: " + userNumber);
                }

                //ask the user if they want to enter another number
                Console.WriteLine("Would you like to enter another number? Yes to continue...");
                string anotherNumber = Console.ReadLine().ToLower();

                if (!(anotherNumber == "yes"))
                {
                    continueAsking = false;
                }
            }
            //3.Print the text file back to the user.
            string numbersEntered = File.ReadAllText(@"C:\LogDirectory\LogNumbers.txt");
            Console.WriteLine("The numbers you entered were:\n");
            Console.WriteLine(numbersEntered);

            Console.ReadLine();
        }
    }
}
