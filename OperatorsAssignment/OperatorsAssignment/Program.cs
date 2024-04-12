using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // create two different employee classes
            // both with different numbers for their ID property
            Employee employeeOne = new Employee();
            employeeOne.ID = 1;
            Employee employeeTwo = new Employee();
            employeeTwo.ID = 2;
            // print to the screen the result of our overloaded operators
            Console.WriteLine(employeeOne == employeeTwo);
            Console.ReadLine();
        }
    }
}
