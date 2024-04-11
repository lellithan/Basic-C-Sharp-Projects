using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a new class which has three overloaded funcitons, one that takes a string,
            // one that takes an int, and one that takes a decimal and returns a decimal
            overloadedAddition addition = new overloadedAddition();
            Console.WriteLine("The sum of 26 + 8 is: " + addition.Addition(8) +
                "\nThe sum of 26 + 3.452 is: " + addition.Addition(3.452m) + 
                "\nThe sum of 26 + 3 is: " + addition.Addition("3"));
            Console.ReadLine();
        }
    }
}
