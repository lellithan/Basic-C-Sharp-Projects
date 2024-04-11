using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate class employee
            Employee employee = new Employee();
            // set values to the empty string variables from the person class - inheritance
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            // because employee is child class of person, we can call method SayName() - inheritance
            employee.SayName();
            Console.ReadLine();
        }
    }
}
