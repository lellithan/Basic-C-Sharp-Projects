using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    public class Employee
    {
        public string firstName;
        public string lastName;
        public int ID;

        // overload the == operator two compare the two IDs of a Employee object
        public static bool operator ==(Employee employeeOne, Employee employeeTwo)
        {
            return employeeOne.ID == employeeTwo.ID;
        }
        // can't have one without the other. do the same for !=.
        public static bool operator !=(Employee employeeOne, Employee employeeTwo)
        {
            return employeeOne.ID != employeeTwo.ID;
        }
    }
}
