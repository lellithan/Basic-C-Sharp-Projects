using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    // declare our struct Number with a decimal value of name Amount
    public struct Number
    {
        public decimal Amount;
    }
    class Program
    {
        static void Main(string[] args)
        {
            // create an instance of our struct
            Number number = new Number();
            // assign our value of Amount in our new struct the value of 8.75
            number.Amount = 8.75m;
            // print Amount to the console
            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
    }
}
