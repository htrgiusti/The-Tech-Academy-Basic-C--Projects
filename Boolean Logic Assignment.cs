using System;

namespace Boolean_Logic_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // In this Boolean Logic Assignment I had to create a basic approval program for car insurance.

            // // Print the header for the Car Insurance Application.
            Console.WriteLine("Car insurance Application.");

            // Ask for age and get user input.
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();

            // Ask if the user has had a DUI and get user input.
            Console.WriteLine("Have you ever had a DUI? Answer with true or false.");
            string dui = Console.ReadLine();

            // Ask for the number of speeding tickets the user has and get user input.
            Console.WriteLine("How many speeding tickets do you have?");
            string speedtickets = Console.ReadLine();

            // Determine if the user is qualified for car insurance based on age, DUI status, and number of speeding tickets.
            bool qualified = (Convert.ToInt32(age) >= 15 && Convert.ToBoolean(dui) == false && Convert.ToInt32(speedtickets) <= 3);

            // Print the result of the boolean expression.
            Console.WriteLine("Qualified?");
            Console.WriteLine(qualified);

            // Wait for user input before closing the program.
            Console.Read();





        }
    }
}
