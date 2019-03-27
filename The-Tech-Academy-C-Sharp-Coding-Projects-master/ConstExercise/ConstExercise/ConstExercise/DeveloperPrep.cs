using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstExercise
{
    public class DeveloperPrep
    {
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }
        public int StudentId { get; set; }

        //3. Chain two constructors together.
        public DeveloperPrep(string name, string studentEmail) : this(name, studentEmail, 00000)
        {

        }

        public DeveloperPrep(string name, string studentEmail, int schoolId)
        {
            StudentName = name;
            StudentId = schoolId;
            StudentEmail = studentEmail;

        }
    }
}
