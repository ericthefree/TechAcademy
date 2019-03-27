nusing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Do a boolean comparison using a while statement.
            Console.WriteLine("This is the exercise to do a boolean comparison using a WHILE statement.");
            Console.WriteLine("This will print out all the prime numbers from 0 to a number you enter."); 
            Console.Write("\nPlease enter a number: ");
            int myNumber = Convert.ToInt32(Console.ReadLine());
            bool completed = false;

            while ( completed != true)
            {
                
                for (int i = 1; i <= myNumber; i++)
                {
                    int cnt = 0;
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)    
                        {
                            cnt++;
                        }
                    }
                    if (cnt == 2)
                    {
                        Console.WriteLine("\n" + i + " is prime!");
                    }
                }
                completed = true;

            }

            Console.Read();
        }
    }
}
