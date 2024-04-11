using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class voidMethod
    {
        public void Operation(int intOne, int intTwo)
        {
            // perform an operation on the first argument
            intOne += 7;
            // print the second argument to the screen
            Console.WriteLine("Var intOne is: " + intTwo);
        }
    }
}
