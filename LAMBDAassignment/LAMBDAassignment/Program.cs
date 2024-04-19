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
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { firstName = "Joe", lastName = "Dirt", ID = 1 },
                new Employee() { firstName = "Bob", lastName = "Dirt", ID = 2 },
                new Employee() { firstName = "Gibs", lastName = "Dirt", ID = 3 },
                new Employee() { firstName = "Tomar", lastName = "Dirt", ID = 4 },
                new Employee() { firstName = "Zachariah", lastName = "Dirt", ID = 5 },
                new Employee() { firstName = "Joe", lastName = "Clean", ID = 6 },
                new Employee() { firstName = "Timmy", lastName = "Clean", ID = 7 },
                new Employee() { firstName = "Zoey", lastName = "Clean", ID = 8 },
                new Employee() { firstName = "Limur", lastName = "Clean", ID = 9 },
                new Employee() { firstName = "Darts", lastName = "Clean", ID = 10 }
            };
            //Employee one = new Employee("Joe", "Dirt", 1);
            //Employee two = new Employee("Bob", "Dirt", 2);
            //Employee three = new Employee("Gibs", "Dirt", 3);
            //Employee four = new Employee("Tomar", "Dirt", 4);
            //Employee five = new Employee("Zachariah", "Dirt", 10);
            //Employee six = new Employee("Joe", "Clean", 5);
            //Employee seven = new Employee("Timmy", "Clean", 6);
            //Employee eight = new Employee("Zoey", "Clean", 7);
            //Employee nine = new Employee("Limur", "Clean", 8);
            //Employee ten = new Employee("Darts", "Clean", 9);

            //employees.Add(one);
            //employees.Add(two);
            //employees.Add(three);
            //employees.Add(four);
            //employees.Add(five);
            //employees.Add(six);
            //employees.Add(seven);
            //employees.Add(eight);
            //employees.Add(nine);
            //employees.Add(ten);

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

            Console.WriteLine("Print the List that was created using a foreach.");
            // print to console for fun
            foreach (Employee joe in Joes)
            {
                Console.WriteLine(joe.firstName + " " + joe.lastName + " | ID: " + joe.ID);
            }

            Console.WriteLine("\nPrint the List that was created using a LAMBDA expression.");
            // no foreach loop needed! lambda expression does the job all in one line!
            List<Employee> joes = employees.Where(x => x.firstName == "Joe").ToList();

            foreach (Employee joe in joes)
            {
                Console.WriteLine(joe.firstName + " " + joe.lastName + " | ID: " + joe.ID);
            }

            Console.WriteLine("\nPrint the List that was created using a LAMBDA and where ID's are greater than 5.");
            List<Employee> greaterFive = employees.Where(x => x.ID > 5).ToList();

            foreach (Employee id in greaterFive)
            {
                Console.WriteLine(id.firstName + " " + id.lastName + " | ID: " + id.ID);
            }

            Console.ReadLine();
        }
    }
}
