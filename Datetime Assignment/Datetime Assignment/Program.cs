using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The current Date and Time is: "); // Prints "The current Date and Time is: " to the console
            Console.WriteLine(DateTime.Now); // Prints the current date and time using DateTime.Now struct

            Console.WriteLine("Type a number: "); // Prints "Type a number: " to the console
            double userInput = Convert.ToDouble(Console.ReadLine()); // Creates a double type variable called "userInput" and gives the user input as a value

            Console.WriteLine(@"The exact date and time in {0} hours will be: ", userInput); // Prints "The exact date and time in "userInput" hours will be: " to the console
            Console.WriteLine(DateTime.Now.AddHours(userInput)); // Prints the current date and time plus+ the value of "userInput" to show the exact date and time 

            Console.Read();
        }
    }
}
