using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment
{
    public class byFive
    {
        public byFive() { userInput = 0; }
        public int timesFive(int user)
        {
            return userInput * 5;
        }
        public int plusFive(int user)
        {
            return userInput + 5;
        }
        public int minusFive(int user)
        {
            return userInput - 5;
        }
        public int userInput;
    }
}
