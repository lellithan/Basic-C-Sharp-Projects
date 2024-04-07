using System;

namespace CarInsuranceQualify
{
    class Program
    {
        static void Main(string[] args)
        {
            //  print to the console to tell the user to answer some information
            Console.WriteLine("Let's check to see if you qualify for our car insurance!\nTo start, what is your age?"); //  applicant age
            ushort age = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? answer \"true\" or \"false.\""); // if applicant has ever had a dui and store in a bool
            bool dui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?"); // ask the applicant how many speedtickets they have received
            ushort ticketCount = Convert.ToUInt16(Console.ReadLine());

            //  three qualifiers that the applicant must succeed in
            //  1. applicant must be older than 15 years of age
            //  2. applicant must not have any duis
            //  3. applicant must not have more than 3 speeding tickets
            bool qualifed = (age > 15 && dui == false && ticketCount <= 3);
            Console.WriteLine("Qualified?\n" + qualifed);
            Console.ReadLine();
        }
    }
}
