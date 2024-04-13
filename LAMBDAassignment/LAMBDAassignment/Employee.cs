using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMBDAassignment
{
    public class Employee
    {
        public Employee(string fName, string lName, int id)
        {
            firstName = fName;
            lastName = lName;
            ID = id;
        }
        public string firstName;
        public string lastName;
        public int ID;
    }
}
