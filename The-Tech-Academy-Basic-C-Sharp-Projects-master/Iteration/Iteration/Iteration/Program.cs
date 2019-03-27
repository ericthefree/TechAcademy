using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

        //for ( int i = 0; i < testScores.Length; i++ )
        //{
        //    if ( testScores[i] > 85 )
        //    {
        //        Console.WriteLine("Passing test score: " + testScores[i]);
        //    }
        //}

        //string[] names = { "Jesse", "Eric", "Daniel", "Adam" };

        //for (int j = 0; j < names.Length; j++ )
        //{
        //    //if ( names[j] == "Eric" )
        //    //{
        //    //    Console.WriteLine("Found the name " + names[j] + " in the array position " + j + ".");
        //    //}

        //    Console.WriteLine("The name " + names[j] + " is found in the array position " + j + ".");

        //}

        //List<int> testScores = new List<int>();

        //testScores.Add(98);
        //testScores.Add(99);
        //testScores.Add(94);
        //testScores.Add(81);
        //testScores.Add(77);
        //testScores.Add(85);

        //foreach( int score in testScores )
        //{
        //    if (score > 85)
        //    {
        //        Console.WriteLine("Passing test score: " + score);
        //    }
        //}

        //List<string> names = new List<string>() { "Jesse", "Eric", "Dave", "James", "Bob" };

        //foreach (string name in names)
        //{
        //    //if (name == "Eric")
        //    //{
        //    //    Console.WriteLine("Found the name " + name);
        //    //}

        //    Console.WriteLine("Found the name: " + name);
        //}

        List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
        List<int> passingScores = new List<int>();

        foreach (int score in testScores)
        {
            if (score > 85)
            {
                passingScores.Add(score);
            }
        }

        Console.WriteLine("The number of passing scores was: " + passingScores.Count);

        Console.ReadLine();
    }
}
