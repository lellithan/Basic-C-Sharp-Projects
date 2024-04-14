using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a new DateTime so that we can modify the
            // current date later after we assign the current time to our object
            DateTime dateTime = new DateTime();
            dateTime = DateTime.Now;
            // print to the console the current day and time
            Console.WriteLine(dateTime + "\nEnter a whole number: ");
            // ask the user for a whole number to see the date and time after however many hours they enter
            int userNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} + {1} hour(s) = {2}", dateTime, userNum, dateTime.AddHours(userNum));
            Console.ReadLine();
        }
    }
}
