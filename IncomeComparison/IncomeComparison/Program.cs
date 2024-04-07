using System;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            // print to the console that we are looking for information from the user about the first person
            // asking first for the hourly rate they earn and then the hours worked for the week
            Console.WriteLine("Anonymous Income Comparison Program\nPerson 1\nPlease enter the hourly rate of the first person:");
            float hourlyRateOne = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Now, please enter the hours worked per week for this person:");
            float hoursWorkedOne = Convert.ToSingle(Console.ReadLine());

            // now we ask the user for information on the second person
            Console.WriteLine("Person 2\nPlease enter the hourly rate of the second person:");
            float hourlyRateTwo = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Now, please enter the hours worked per week for this person:");
            float hoursWorkedTwo = Convert.ToSingle(Console.ReadLine());

            // take the two persons' information and use math.round to round the salary to the hundreths place
            // formula is hourly rate * the hours worked times 52.1429 (the representation of the weeks in a year)
            double salaryOne = Math.Round(((hourlyRateOne * hoursWorkedOne) * 52.1429), 2);
            double salaryTwo = Math.Round(((hourlyRateTwo * hoursWorkedTwo) * 52.1429), 2);
            Console.WriteLine("Annual salary of Person 1:" + $"{salaryOne:n}" + "$"); // use the dollar sign and curly braces to format the salaries with commas
            Console.WriteLine("Annual salary of Person 2:" + $"{salaryTwo:n}" + "$");

            //  quick comparison to see if person 1 makes more, then we print to the console
            bool isPerson1More = salaryOne > salaryTwo;
            Console.WriteLine("Does Person 1 make more money than Person 2?\n" + isPerson1More);
            Console.ReadLine();
        }
    }
}
