using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using try/catch to handle exceptions.
            try
            {
                // Ask the user for their age.
                Console.WriteLine("Enter your age: ");
                int age = int.Parse(Console.ReadLine());

                if (age <= 0)
                {
                    // Display appropriate error messages if the user enters zero or negative numbers.
                    Console.WriteLine("Invalid age. Age must be a positive number.");
                }
                else
                {
                    int currentYear = DateTime.Now.Year;
                    int birthYear = currentYear - age;
                    
                    // Display the year the user was born.
                    Console.WriteLine("You were born in: " + birthYear);                   
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Age must be a numeric value.");
            }
            catch (Exception ex)
            {
                // Display a general message if an exception was caused by anything else.
                Console.WriteLine("An error has occurred: " + ex.Message);
            }
            Console.Read();
        }
    }
}
