using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMBDAassignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // create list and add 10 employees to it
            List<Employee> employees = new List<Employee>();
            Employee one = new Employee("Joe", "Dirt", 1);
            Employee two = new Employee("Bob", "Dirt", 2);
            Employee three = new Employee("Gibs", "Dirt", 3);
            Employee four = new Employee("Tomar", "Dirt", 4);
            Employee five = new Employee("Zachariah", "Dirt", 10);
            Employee six = new Employee("Joe", "Clean", 5);
            Employee seven = new Employee("Timmy", "Clean", 6);
            Employee eight = new Employee("Zoey", "Clean", 7);
            Employee nine = new Employee("Limur", "Clean", 8);
            Employee ten = new Employee("Darts", "Clean", 9);

            employees.Add(one);
            employees.Add(two);
            employees.Add(three);
            employees.Add(four);
            employees.Add(five);
            employees.Add(six);
            employees.Add(seven);
            employees.Add(eight);
            employees.Add(nine);
            employees.Add(ten);

            // using a foreach loop search employees and find all items with the fname "Joe"
            // and add them to the list Joes
            List<Employee> Joes = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.firstName == "Joe")
                {
                    Joes.Add(employee);
                }
            }

            // print to console for fun
            foreach (Employee joe in Joes)
            {
                Console.WriteLine(joe.firstName + " " + joe.lastName + " | ID: " + joe.ID);
            }

            // no foreach loop needed! lambda expression does the job all in one line!
            List<Employee> joes = employees.Where(x => x.firstName == "Joe").ToList();

            foreach (Employee joe in joes)
            {
                Console.WriteLine(joe.firstName + " " + joe.lastName + " | ID: " + joe.ID);
            }
            Console.ReadLine();
        }
    }
}
