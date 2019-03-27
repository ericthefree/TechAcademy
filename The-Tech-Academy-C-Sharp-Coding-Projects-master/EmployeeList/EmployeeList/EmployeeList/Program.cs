using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeList
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. In the Main() method, create a list of at least 10 employees. 
            //   Each employee should have a first and last name, as well as an 
            //   Id. At least two employees should have the first name "Joe".
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee("Eric", "Freeman", 10005));
            employees.Add(new Employee("Erik", "Gross", 10051));
            employees.Add(new Employee("Joe", "Goodman", 10001));
            employees.Add(new Employee("Dan", "Christie", 10004));
            employees.Add(new Employee("Mike", "Shapiro", 10021));
            employees.Add(new Employee("Joe", "Namath", 10101));
            employees.Add(new Employee("Roman", "Powell", 10003));
            employees.Add(new Employee("Samuel", "Freeman", 10111));
            employees.Add(new Employee("Catherine", "Freeman", 10002));
            employees.Add(new Employee("Lorin", "Stewart", 11001));

            int userCount = 0;

            //Implemented this loop to list the employees to evaluate the list was created correctly
            //foreach (var employee in employees)
            //{
            //    Console.WriteLine("Employee: {0}, {1}, {2}", employee.FirstName, employee.LastName, employee.UserId);
            //    userCount++;
            //}

            //Console.WriteLine("Total User Count: " + userCount);

            //2. Using a foreach loop, create a new list of all employees with the 
            //   first name "Joe".

            List<Employee> newList = new List<Employee>();

            Console.WriteLine("Section 2 of the Lambda Exercise using a foreach loop shown below here.");
            foreach (var employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    Console.WriteLine("Found a user with the first name Joe: " + employee.FirstName + " " + employee.LastName + " user ID: " + employee.UserId);
                    newList.Add(new Employee(employee.FirstName, employee.LastName, employee.UserId));
                    userCount++;

                }
            }

            Console.WriteLine("Total user count with the first name Joe: " + userCount + "\n");

            //3. Do the same thing again, but this time with a lambda expression.
            Console.WriteLine("Section 3 of the Lambda Exercise using a lambda expression shown below here.");
            List<Employee> lambdaEmployeeList = employees.Where(x => x.FirstName == "Joe").ToList();
            foreach(Employee employee in lambdaEmployeeList)
            {
                Console.WriteLine("Current user in new lambdaEmployeeList where first name is Joe is: " + employee.FirstName + " " + employee.LastName + " and user ID: " + employee.UserId);
            }
            Console.WriteLine("Total user count with first name Joe is: " + lambdaEmployeeList.Count + "\n");

            //Create a list of users with last name of Freeman using lambda expression
            List<Employee> lambdaLastNameList = employees.Where(x => x.LastName == "Freeman").ToList();
            foreach (Employee employee in lambdaLastNameList)
            {
                Console.WriteLine("Current user in new lambdaLastNameList where last name is Freeman is: " + employee.FirstName + " " + employee.LastName + " and user ID: " + employee.UserId);
            }
            Console.WriteLine("Total user count with last name Freeman is: " + lambdaLastNameList.Count + "\n");


            //4. Using a lambda expression, make a list of all employees with an Id 
            //   number greater than 10005.
            Console.WriteLine("Section 4 of the Lambda Exercise using a lambda expression for user ID's greater than 10005 shown below here.");
            List<Employee> lambdaUserIdList = employees.Where(x => x.UserId > 10005).ToList();
            foreach(Employee employee in lambdaUserIdList)
            {
                Console.WriteLine("Current user in lambdaUserIdList where user ID > 5 is: " + employee.FirstName + " " + employee.LastName + " and user ID: " + employee.UserId);
            }
            Console.WriteLine("Total user count where id > 10005 is: " + lambdaUserIdList.Count);  

            Console.ReadLine();
        }
    }
}
