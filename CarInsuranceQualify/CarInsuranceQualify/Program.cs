using System;

namespace CarInsuranceQualify
{
    class Program
    {
        static void Main(string[] args)
        {
            //  print to the console to see if 
            Console.WriteLine("Let's check to see if you qualify for our car insurance!\nTo start, what is your age?");
            ushort age = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? answer \"true\" or \"false.\"");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            ushort ticketCount = Convert.ToUInt16(Console.ReadLine());

            bool qualifed = (age > 15 && dui == false && ticketCount < 3);
            Console.WriteLine("Qualified?\n" + qualifed);
            Console.ReadLine();
        }
    }
}
