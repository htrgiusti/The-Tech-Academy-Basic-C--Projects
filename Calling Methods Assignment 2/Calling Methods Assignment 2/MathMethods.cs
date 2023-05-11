using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods_Assignment_2
{
    class MathOperations
    {
        // Method to square the input number
        public static int SquareNumber(int number)
        {
            return number * number;
        }

        // Method to calculate the sum of all numbers up to the input number
        public static int CalculateSum(int number)
        {
            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
