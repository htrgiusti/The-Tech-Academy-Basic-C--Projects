using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment
{
    class Program
    {
        static void Main()
        {
            // In the Main() method of the console app, instantiate the class.
            MathOperations mathops = new MathOperations();

            // Call the method in the class passing in two numbers and specifying the parameters by name.
            mathops.method(numberOne: 10, numberTwo: 21);
            
            Console.Read();
        }
    }
}
