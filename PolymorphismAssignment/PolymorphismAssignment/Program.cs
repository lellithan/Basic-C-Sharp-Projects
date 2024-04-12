using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a polymorphic instance of IQuittable using new Employee child class
            IQuittable quit = new Employee();
            // make call to employee method Quit()
            quit.Quit();
            Console.ReadLine();
        }
    }
}
