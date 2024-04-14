using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number to be appended to a document.");
            int userInput = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C:\Users\New User\Logs\assignmentLogs.txt", true))
            {
                file.WriteLine(userInput);
            }
            using (StreamReader file = new StreamReader(@"C:\Users\New User\Logs\assignmentLogs.txt", true))
            {
                string filePrint = file.ReadToEnd();
                Console.WriteLine("assignmentLogs.txt file: \n" + filePrint);
            }
            Console.ReadLine();
        }
    }
}
