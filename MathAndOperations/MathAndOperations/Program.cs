using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number.");
            double userNumber = Convert.ToDouble(Console.ReadLine()); // take in a string from the user and convert to double
            Console.WriteLine("Operations on your number:\n * 50 = " + (userNumber * 50) + //start performing the operations on our number - first multiply
                "\n + 25 = " + (userNumber + 25) + // add 25 to it
                "\n / 12.5 = "  + (userNumber / 12.5) + // divide it by 12.5
                "\n > 50 = " + (userNumber > 50) + // comparison operator that returns true or false
                "\n % 7 = " + (userNumber % 7) // find the modulus of the number divided by 7
                );
            Console.ReadLine();
        }
    }
}

