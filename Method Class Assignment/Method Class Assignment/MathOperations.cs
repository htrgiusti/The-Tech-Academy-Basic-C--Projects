using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment
{
    class MathOperations
    {
        // Create a class. In that class, create a void method that takes two integers as parameters.
        // Have the method do a math operation on the first integer and display the second integer to the screen. 
        public void method(int numberOne, int numberTwo)
        {
            int result = numberOne * 2;
            Console.WriteLine("Number one + 2 = " + result);

            Console.WriteLine("Number two = " + numberTwo);
        }
    }
}
