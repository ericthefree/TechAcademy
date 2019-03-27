using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            // 2. Do a boolean comparison using a do while statement.
            Console.WriteLine("This is the exercise to do a boolean comparison using a DO WHILE statement.\n");
            Console.WriteLine("This program will ask you to enter a guess of a random number between 1 and 25 until you guess correctly.");
            Console.WriteLine("When you guess the number correctly it will output the number of tries it took you to guess the number.");

            Random randomFunction = new Random();
            int randomNumber = randomFunction.Next(1, 25);
            int guessCount = 0;
            bool guessedCorrect = false;

            // Console.WriteLine("\nThe current random number is: " + randomNumber);

            // Writing out the random number generated for testing the guesses
            Console.Write("\nEnter a number between 1 and 25 to guess the number: ");
            int userGuess = Convert.ToInt32(Console.ReadLine());

            do
            {

                if (userGuess == randomNumber)
                {
                    guessCount += 1;
                    Console.WriteLine("\nYou guessed the correct number!");
                    Console.WriteLine("You guessed the number in " + guessCount + " number of guesses.");
                    guessedCorrect = true;
                }
                else if (userGuess < 1)
                {
                    guessCount += 1;
                    Console.Write("\nYou entered a number less than 1.  Please enter a number between 1 and 25 to guess the number: ");
                    userGuess = Convert.ToInt32(Console.ReadLine());
                    guessedCorrect = false;
                }
                else if (userGuess > 25)
                {
                    guessCount += 1;
                    Console.Write("\nYou entered a number greater than 25.  Please enter a number between 1 and 25 to guess the number: ");
                    userGuess = Convert.ToInt32(Console.ReadLine());
                    guessedCorrect = false;
                }
                else
                {
                    guessCount += 1;
                    Console.Write("\nYou entered in invalid guess.  Please enter a number between 1 and 25 to guess the number: ");
                    userGuess = Convert.ToInt32(Console.ReadLine());
                    guessedCorrect = false;
                }
            }
            while (guessedCorrect == false);

            Console.Read();
        }
    }
}
