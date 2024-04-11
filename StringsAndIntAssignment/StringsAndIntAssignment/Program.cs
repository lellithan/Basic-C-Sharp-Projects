using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a list that contains data of type int and ask the user to input a number
            List<int> numberList = new List<int>() { 78, 99, 46, 10, 12 };
            Console.WriteLine("Please enter a number that we will divide the numbers in our list by."); 
            // try block where we will divide and print out each element in the list to our console
            try
            {
                int userInput = Convert.ToInt32(Console.ReadLine());
                foreach (int num in numberList)
                {
                    Console.WriteLine(num + " divded by " + userInput + " equals: " + (num / userInput));
                }
            }
            // if the user enters a string then catch the error and print the message to the console
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
            }
            // if the user enters 0 then print this message
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            // any other exception that might be thrown, print to the console.
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Code has successfully continued past the try/catch block.");
            Console.ReadLine();
        }
    }
}
