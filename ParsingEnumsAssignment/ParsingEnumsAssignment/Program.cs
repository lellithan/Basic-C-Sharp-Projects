using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What day is today? Use proper capitilization.");
                string day = Console.ReadLine();
                int enumValue = (int)Enum.Parse(typeof(DaysOfTheWeek), day);
                Console.WriteLine("The enum int value of " + day + " is: " + enumValue);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.ReadLine();
        }
    }
    public enum DaysOfTheWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
