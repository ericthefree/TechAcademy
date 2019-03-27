using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeList
{
    public class Employee : People
    {
        public string UserName { get; set; }
        public int UserId { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyPhone { get; set; }
        public List<People> People { get; set; }

        public Employee(string firstName, string lastName, int userId)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.UserId = userId;

        }
    }
}
