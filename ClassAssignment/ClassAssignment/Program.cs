using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // step 2 - instantiate the class
            divideTwo divide = new divideTwo();
            Console.WriteLine("Enter a whole number: ");
            // ask the user for input to divide by
            int userInput;
            int userInputTwo = Convert.ToInt32(Console.ReadLine());

            // overloaded methods. one that has an out and one does not.
            divide.Operate(userInputTwo);
            // becasue this class is static we can make a call to it by the class type
            staticDivide.Operate(userInputTwo);
            Console.WriteLine("Please enter another number for the method with out params.");
            divide.Operate(out userInput);
            Console.WriteLine(userInput);
            Console.ReadLine();
        }
    }
}
