using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate the new class that has our void method
            voidMethod runMethod = new voidMethod();

            // call the method within, while passing in two ints
            runMethod.Operation(3, 7);

            // instatiate two new int variables and then calling the method and passing in the arguments by name
            int numOne = 3;
            int numTwo = 7;
            runMethod.Operation(numOne, numTwo);

            Console.ReadLine();
        }
    }
}
