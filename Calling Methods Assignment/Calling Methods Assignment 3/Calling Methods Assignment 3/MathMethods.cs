using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods_Assignment_3
{
    class MathMethods
    {
        // First Method that takes an integer
        public int MathOp(int number)
        {
            return number + 1000;
        }
        
        // Second Method that takes a decimal 
        public int MathOp(decimal number)
        {
            int newnum = Convert.ToInt32(number);
            return newnum * 1000;
        }
        
        // Third Method that takes a string
        public int MathOp(string number)
        {
            int newnum = Convert.ToInt32(number);
            return newnum / 4;
        }
        
    }
}
