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

            // overloaded methods. one that has an out and one does not. one is static and the other is not.
            // because the operate has an out we need to create a variable that we are going to instatiate
            // within the method and output it to its place in memory here.
            divideTwo.Operate(userInputTwo);
            // becasue this method is static we instead make a call to it by the class type. not the instance of divide decalared earlier
            divide.Operate(out userInput);
            Console.WriteLine(userInput);
            Console.ReadLine();
        }
    }
}
