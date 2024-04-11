using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate a new variable of type employee
            Employee employee = new Employee();
            // we inherit from person so we can instaniate the public variables from main
            employee.firstName = "Sample";
            employee.lastName = "Student";
            // make a call to the specific SayName() function that is within child class employee
            employee.SayName();
            Console.ReadLine();
        }
    }
}
