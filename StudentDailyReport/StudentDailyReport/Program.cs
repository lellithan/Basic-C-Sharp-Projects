using System;

namespace StudentDailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            // program starts - write to console a welcome message
            Console.WriteLine("The Tech Academy.\nStudent Daily Report.\n\nPress 'Enter' to continue.");
            Console.ReadLine();

            // a series of questions to gather information from our student
            // ask for student name and store within string data type
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();

            // string variable for name of course they are on
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();

            // store their page number in a short as it's most likely we wont be in the billions
            Console.WriteLine("What page number are you on?");
            ushort pageNumber = Convert.ToUInt16(Console.ReadLine());

            // take in a string and convert to a bool - user must be precise or conversion will fail
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());

            // string to contain positive experiences
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveAnswer = Console.ReadLine();

            // string that contains feedback from the student
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedbackAnswer = Console.ReadLine();

            // string to ushort conversion again because it is unlikely that "hours studied" is higher than the hundreds
            Console.WriteLine("How many hours did you study today?");
            ushort hoursStudied = Convert.ToUInt16(Console.ReadLine());

            // step 5 - a thanks for the student
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
