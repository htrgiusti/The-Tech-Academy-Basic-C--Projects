using System;

namespace Branching_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = num1 > num2 ? "num1 is greater than num2" : "num1 is less than num2";
            Console.WriteLine(result);
            Console.ReadLine();
            //// Welcome message 
            //Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            //// Ask package weight and read input
            //Console.WriteLine("What is your package weight?");
            //int packageWeight = Convert.ToInt32(Console.ReadLine());

            //// Create a variable to track if there is an error
            //bool error = false;

            //// Check if package weight is too heavy
            //if (packageWeight > 50)
            //{
            //    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            //    error = true;
            //    Console.Read();
            //}

            //// Check if there has been no error so far
            //if (!error)
            //{
            //    // Ask package width, height and length and gets input
            //    Console.WriteLine("What is your package width?");
            //    int packageWidth = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("What is your package height?");
            //    int packageHeight = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("What is your package length?");
            //    int packageLength = Convert.ToInt32(Console.ReadLine());

            //    // Calculate the total package size 
            //    int packageSize = packageWidth + packageHeight + packageLength;

            //    // Check if package is too big
            //    if (packageSize > 50)
            //    {
            //        Console.WriteLine("Package too big to be shipped via Package Express.");
            //        error = true;
            //        Console.Read();
            //    }

            //    // Check if there has been no error so far
            //    if (!error)
            //    {
            //        // Calculate the quote and display it to the user
            //        int quote = (packageWidth * packageHeight * packageLength * packageWeight) / 100;
            //        Console.WriteLine("Your estimated total for shipping this package is: ${0}.00", quote);
            //        Console.WriteLine("Thank you!");

            //        // Wait for the user to press a key before exiting the program
            //        Console.Read();
        }
            }
                            
        }
    }
}
