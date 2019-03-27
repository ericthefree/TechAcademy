using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        List<int> intList = new List<int>();

        intList.Add(4);
        intList.Add(10);
        intList.Remove(10);

        List<string> intList2 = new List<string>();
        intList2.Add("Hello");
        intList2.Add("Eric");
        intList2.Remove("Eric");

        Console.WriteLine(intList2[0]);

        //byte[] byteArray = new int(5000);


        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };

        Console.ReadLine();
    }
}
