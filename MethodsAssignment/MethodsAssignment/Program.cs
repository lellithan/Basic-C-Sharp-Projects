using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a new class that has an int that will be the userInput that we store so we can do operations on
            byFive letsOperate = new byFive();
            // ask the user for a number and then store it within our new class object and operate on it
            Console.WriteLine("Enter a number that we will operate on.");
            letsOperate.userInput = Convert.ToInt32(Console.ReadLine());
            // simultaneously print the operation results and call the classes methods that return the result of the two numbers
            Console.WriteLine("Your number times 5 is equal to: " + letsOperate.timesFive(letsOperate.userInput) +
                "\nYour number plus 5 is equal to: " + letsOperate.plusFive(letsOperate.userInput) +
                "\nYour number minus 5 is equal to: " + letsOperate.minusFive(letsOperate.userInput));
            Console.ReadLine();
        }
    }
}
