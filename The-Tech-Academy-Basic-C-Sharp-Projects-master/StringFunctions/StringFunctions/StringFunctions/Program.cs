using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Eric";
            //string quote = "The man said, \"Hello\" Eric!  \nHello on a new line. \n \t Hello on a tab.";
            //string filename = @"C:\Users\Eric";

            //bool trueOrFalse = name.Contains("s");

            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToUpper();

            //name = name.ToLower();

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Eric");

            Console.WriteLine(sb);
            Console.Read();
        }
    }
}
