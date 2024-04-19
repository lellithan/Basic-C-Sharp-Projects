using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const string helloWorld = "Hello, World!";
            // using implicit identifier var we instantiate a new instance of ChainCons
            // because we provide no arguments to our constuctor. it travels down the chain
            // and instiates it to the defaul values of "Hello" and " World!"
            var chain = new ChainCons();
            // print the values of chain to the console.
            // output : Hello World!
            string newString = chain.Hello + chain.World;
            if (newString == helloWorld)    Console.WriteLine(newString);
            Console.ReadLine();
        }
    }
}
