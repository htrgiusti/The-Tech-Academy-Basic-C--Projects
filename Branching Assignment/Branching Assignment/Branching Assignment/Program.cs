using System;

namespace Branching_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("What is your package weight?");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            bool error = false;
            
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                error = true;
            }

            if (!error)
            {
                Console.WriteLine("What is your package width?");
                int packageWidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is your package height?");
                int packageHeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is your package length?");
                int packageLength = Convert.ToInt32(Console.ReadLine());

                int packageSize = packageWidth + packageHeight + packageLength;

                if (packageSize > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    error = true;
                }
                if (!error)
                {
                    int quote = (packageWidth * packageHeight * packageLength * packageWeight) / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: ${0}.00", quote);
                    Console.WriteLine("Thank you!");
                    Console.Read();
                }
            }
            
           





            Console.Read();
        }
    }
}
