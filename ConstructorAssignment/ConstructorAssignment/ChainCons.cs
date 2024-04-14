using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    public class ChainCons
    {
        public string Hello { get; set; }
        public string World { get; set; }
        public ChainCons() : this("Hello", " World!")
        {
        }
        public ChainCons(string hello) : this(hello, " World!")
        {
        }
        public ChainCons(string hello, string world)
        {
            Hello = hello;
            World = world;
        }
    }
}
