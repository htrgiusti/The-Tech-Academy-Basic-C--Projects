using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inside of the Main method, instantiate and initialize an Employee object with a first name of “Sample” and a last name of “Student”.
            Employee sam = new Employee() { FirstName = "Sample", LastName = "Student" };
            // Call the superclass method SayName() on the Employee object.
            sam.SayName();
            Console.ReadLine();
        }
    }
}
