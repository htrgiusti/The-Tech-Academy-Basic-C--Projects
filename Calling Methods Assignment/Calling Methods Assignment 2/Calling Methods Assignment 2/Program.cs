using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of MathOperations class
            MathOperations mathOps = new MathOperations();

            // Ask the user for input
            Console.WriteLine("Enter a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());          

            // Call each method and display the returned integer 
            int squaredNumber = MathOperations.SquareNumber(userInput);
            Console.WriteLine("Square of " + userInput + " is: " + squaredNumber);

            int sum = MathOperations.CalculateSum(userInput);
            Console.WriteLine("Sum of numbers up to " + userInput + " is: " + sum);

            Console.Read();
        }
    }
}
