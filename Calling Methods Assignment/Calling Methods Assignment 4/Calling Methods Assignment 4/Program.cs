using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods_Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate MathOperation class
            MathOperation math1 = new MathOperation();
            // Ask the user to provide first parameter
            Console.WriteLine("Enter an integer number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            // Ask the user to provide a second parameter or press enter
            Console.WriteLine("Enter a second integer or press enter.");
            try
            {
                // Call method with 2 parameters if both parameters are provided
                int num2 = Convert.ToInt32(Console.ReadLine());
                int results = math1.MathOp(num1, num2);
                Console.WriteLine(num1 + " x " + num2 + " = " + results);
            }
            catch
            {
                // Call method with one parameter if only one is provided 
                int results = math1.MathOp(num1);
                Console.WriteLine(num1 + " x Default 1" + " = " + results);
            }              
            Console.Read();
        }
    }
}
