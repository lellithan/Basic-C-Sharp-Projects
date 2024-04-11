using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class overloadedAddition
    {
        // default constructor sets number to 26
        public overloadedAddition()
        {
            number = 26;
        }
        // over loaded functions that takes and returns an int
        public int Addition(int num)
        {
            return number + num;
        }
        // overloaded function that takes a decimal and returns a decimal
        public decimal Addition(decimal num)
        {
            return Convert.ToDecimal(number) + num;
        }
        // and finally, a function that takes in a string and returns an int
        public int Addition(string num)
        {
            int sum = 0;
            try
            {
                sum = Convert.ToInt32(num) + number;
            }
            catch(FormatException ex)
            {
                Console.WriteLine("String was not a convertable number.");
                Console.ReadLine();
            }
            return sum;
        }
        public int number;
    }
}
