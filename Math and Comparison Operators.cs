using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {   // In this assignment I had to create an anonymous income comparison program.

            // Print the header for the income comparison program.
            Console.WriteLine("Anonymous Income Comparison Program");

            // Get details for person 1.
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string hourlyRate1 = Console.ReadLine();
            Console.WriteLine("Hours worked per week?");
            string weekHours1 = Console.ReadLine();
            // Calculate the annual salary for person 1 by multiplying hourly rate, weekly hours, and 52 weeks in a year.
            int salary1 = Convert.ToInt32(hourlyRate1) * Convert.ToInt32(weekHours1) * 52;

            // Get details for person 2.
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string hourlyRate2 = Console.ReadLine();
            Console.WriteLine("Hours worked per week?");
            string weekHours2 = Console.ReadLine();
            // Calculate the annual salary for person 2 by multiplying hourly rate, weekly hours, and 52 weeks in a year.
            int salary2 = Convert.ToInt32(hourlyRate2) * Convert.ToInt32(weekHours2) * 52;

            // Print the annual salary for person 1.
            Console.WriteLine("Annual Salary of Person 1:");
            Console.WriteLine(salary1);

            // Print the annual salary for person 2.
            Console.WriteLine("Annual Salary of Person 2:");
            Console.WriteLine(salary2);

            // Compare the salaries of person 1 and person 2, and print the result.
            Console.WriteLine("Person 1 makes more money than Person 2");
            bool comparison = salary1 > salary2;
            Console.WriteLine(comparison);

            // Wait for user input before closing the program.
            Console.Read();

            
        }
    }
}
