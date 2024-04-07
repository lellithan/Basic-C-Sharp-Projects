using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // create 3 strings to concatenate together
            string firstName = "Ellie",
                middleName = "J",
                lastName = "Faulhaber";
            //  print to the console my full name and then make a new line and print my first name in all uppercase
            Console.WriteLine("Full name: " + firstName + " " + middleName + " " + lastName +
                "\nUppercase first name: " + firstName.ToUpper()
                );

            //  create a new instance of a stringbuilder
            StringBuilder sb = new StringBuilder();

            //  append 3 different string one by one onto our stringbuilder
            sb.Append("Picking up twigs, ");
            sb.Append("picking up twigs, ");
            sb.Append("picking up, picking up, picking up twigs.");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
