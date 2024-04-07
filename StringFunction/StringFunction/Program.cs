using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Ellie";
            //string quote = "The man said, \"Hello\", Ellie.\nHello on a new line.\n\tHello on a tab.";
            //string fileName = @"C:\Users\Ellie";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToUpper();

            //Console.WriteLine(name);

            //string name = "Ellie";
            //name = "Smellie";

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Ellie.");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
