using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object with type “string” as its generic parameter.
            // Assign a list of strings as the property value of Things.
            Employee<string> employeeString = new Employee<string>();
            employeeString.Things = new List<string> { "Bear", "Boar", "Spider" };

            // Instantiate an Employee object with type “int” as its generic parameter.
            // Assign a list of integers as the property value of Things.
            Employee<int> employeeInt = new Employee<int>();
            employeeInt.Things = new List<int> { 1, 2, 3 };

            // Create a loop that prints all of the Things to the Console.
            Console.WriteLine("\n Employee string list: ");
            foreach (string thing in employeeString.Things)
            {
                Console.WriteLine(thing);
            }

            Console.WriteLine("\n Employee int list: ");
            foreach (int thing in employeeInt.Things)
            {
                Console.WriteLine(thing);
            }
            Console.Read();



        }
    }
}
