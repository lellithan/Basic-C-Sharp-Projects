using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class optionalInt
    {
        public optionalInt() { numOne = 0; numTwo = 0; }
        public int timesFive(int num, int times = 0) 
        {
            return num + (5 * times);
        }
        public int numTwo;
        public int numOne;
    }
}
