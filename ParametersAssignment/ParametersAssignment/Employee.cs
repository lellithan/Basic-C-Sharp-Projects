using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    public class Employee<T>
    {
        public string firstName;
        public string lastName;
        public int ID;
        public List<T> things = new List<T>();
    }
}
