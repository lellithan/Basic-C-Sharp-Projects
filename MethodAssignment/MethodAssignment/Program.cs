using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // create our class that has the method we need to use to operate on
            optionalInt optional = new optionalInt();
            // print to user that we need two numbers and the second one is not required 
            Console.WriteLine("Enter two numbers, press enter after each number.\nThe second number is not necessary, leave it blank by pressing enter if you would like.");
            // since the first number is required then we convert it and store it as an integer
            int numOne = Convert.ToInt32(Console.ReadLine());
            // the second input we are going to store as the string version because we need to first check if the user actually input anything
            string inputTwo = Console.ReadLine();
            // if the user entered nothing for the second input then we run the else statement which will use the defaulted argument of the funcion.
            // if it isnt empty then pass the number entered to the second parameter of the function.
            if (inputTwo != "")
            {
                int numTwo = Convert.ToInt32(inputTwo);
                Console.WriteLine("Number one + (number two * 5) is: " + optional.timesFive(numOne, numTwo));
            }
            else
            {
                Console.WriteLine("Number one + (number two * 5) is: " + optional.timesFive(numOne));
            }
            Console.ReadLine();
        }
    }
}
