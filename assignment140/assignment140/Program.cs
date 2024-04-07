using System;

namespace assignment140
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Acme Accounting Sytems\nRemember, we're \"accounting\" on you!");
            Console.ReadLine();

            int eight = 8;
            int five = 5;

            // addition
            Console.WriteLine("Add: " + (eight + five) + 
                "\nSubtract: " + (eight - five) +
                "\nMultiply: " + (eight * five) +
                "\nDivide: " + (eight / five)
                );
            Console.ReadLine();

            
        }
    }
}
