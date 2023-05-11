using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods_Assignment_4
{
    class MathOperation
    {
        // Create a method that takes two integers as parameters
        // Make one parameter optional by providing a default value
        public int MathOp(int i, int x = 1)
        {
            // Perform multiplication on integers and return the result 
            int result = i * x;
            return result;
        }
    }
}
