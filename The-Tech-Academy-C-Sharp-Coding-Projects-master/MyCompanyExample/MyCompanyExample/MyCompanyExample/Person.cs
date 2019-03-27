using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompanyExample
{
    public class Person
    {
        //1. Create a class called Person and give it two properties, 
        //each of data type string. One called FirstName, the other LastName.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string People { get; set; }

        //Commenting this out for the generic exercise
        //public void SayName()
        //{
        //    List<Employee> people = new List<Employee>();

        //    Console.WriteLine("Name: [" + FirstName + " " + LastName + "]");
        //}
    }
}
