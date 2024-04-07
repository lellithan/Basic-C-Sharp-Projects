using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;  //  create variable i
            while (i < 10) //   while i is less than 10 print it to the console.
            {
                Console.WriteLine(i);
                i++; // increment i
            }

            do
            {
                Console.WriteLine(i); // do ensures that that i will be incremented and printed at least once
                i--;
            }
            while (i >= 0);

            Console.ReadLine();
        }
    }
}
