using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                FirstName = "Heitor",
                LastName = "Giusti"
            };

            employee.SayName();

            // Use polymorphism to create an object of type IQuittable and call the Quit() method on it.     
            IQuittable quittable = employee;
            quittable.Quit();

            Console.Read();
        }
    }
}
