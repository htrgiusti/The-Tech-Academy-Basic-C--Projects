using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment
{
    // Create another class called Employee and have it inherit from the Person class.
    class Employee : Person
    {
        // Implement the SayName() method inside of the Employee class.
        public override void SayName()
        {
            Console.WriteLine("I am an employee.");
            base.SayName();
        }
    }
}
