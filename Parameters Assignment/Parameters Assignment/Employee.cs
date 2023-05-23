using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters_Assignment
{
    // Make the Employee class take a generic type parameter.
    class Employee<T>
    {
        // Add a property to the Employee class called “things” and have its data type be
        // a generic list matching the generic type of the class.
        public List<T> Things = new List<T>();

        public Employee()
        {
            Things = new List<T>();
        }

    }
}
