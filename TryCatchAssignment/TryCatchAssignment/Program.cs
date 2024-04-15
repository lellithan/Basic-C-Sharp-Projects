using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Input you or someone else's age to the console.\nWe'll give you the year you/they were born.");

            int userAge;
            int currentYear = 2024;

            try
            {
                userAge = Convert.ToInt32(Console.ReadLine());
                isPositive(userAge);
            }
            catch (NegativeOrZeroException)
            {
                Console.WriteLine("Zero and negative numbers are not allowed. Please enter positive whole integers.");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Please try again. Please enter positive whole integers.");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("The person's age you entered was born in the year " + (currentYear - userAge));
            Console.ReadLine();
        }
        public static void isPositive(int age)
        {
            if (age <= 0)
            {
                throw new NegativeOrZeroException();
            }
        }
    }
}
