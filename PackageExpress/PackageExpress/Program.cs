using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            //  welcome the user and ask them for the weight of their package
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\nWhat is the weight of your package? Numerals only.");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50) // if the weight is heavier than 50 then inform the customer and exit the application
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            //  proceed and get the width, height, and length of the package from the customer
            Console.WriteLine("What is your package width?");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your package height?");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your package length?");
            int length = Convert.ToInt32(Console.ReadLine());
            if ((width + height + length) > 50) //  check if the total of the package dimensions is greater than 50, if so, exit the program
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            //  multiply the dimension together, then the total by the weight, THEN divide by 100 and you have the quote amount it takes to ship the package
            int quote = ((height * width * length) * weight) / 100;
            Console.WriteLine("Your estimated total for shipping this package is: $" + $"{quote:n}\nThank You!");
            Console.ReadLine();
        }
    }
}
