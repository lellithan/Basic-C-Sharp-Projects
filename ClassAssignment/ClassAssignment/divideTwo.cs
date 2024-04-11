using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    // step 1 - created a class that has a void int that outputs an int
    class divideTwo
    {
        public static void Operate(int num)
        {
            Console.WriteLine("The num passed in divided by 2 is: " + num / 2);
        }
        public void Operate(out int num)
        {
            Console.WriteLine("Please enter another whole number.");
            num = Convert.ToInt32(Console.ReadLine()) / 2;
        }
    }
}
