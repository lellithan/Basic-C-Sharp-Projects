using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // using a generic we instantiate a class object using string as our generic
            // after we instantiate our list "things" by adding 3 items to the list
            Employee<string> employee = new Employee<string>();
            employee.things.Add("Hat");
            employee.things.Add("Shoe");
            employee.things.Add("Wig");
            // doing the same as before but this time we cast our generic to that of type int
            // add items to the list
            Employee<int> employeeInt = new Employee<int>();
            employeeInt.things.Add(1);
            employeeInt.things.Add(2);
            employeeInt.things.Add(3);
            // print each individual item in list things of string type
            // then do the same for the int typed list
            foreach (string thing in employee.things)
            {
                Console.WriteLine(thing);
            }
            foreach (int number in employeeInt.things)
            {
                Console.WriteLine(number);
            }
        }
    }
}
