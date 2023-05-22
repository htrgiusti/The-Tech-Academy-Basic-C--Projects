using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignment
{
    class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("I am an employee.");
            base.SayName();
        }
        // Have your Employee class from the previous drill inherit that interface
        // and implement the Quit() method in any way you choose.
        public void Quit()
        {
            Console.WriteLine("Employee quitting...");
        }
    }
}
