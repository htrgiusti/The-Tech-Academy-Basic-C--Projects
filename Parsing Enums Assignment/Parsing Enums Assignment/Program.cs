using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_Enums_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Prompt the user to enter the current day of the week.
                Console.WriteLine("What day is today?");
                string userInput = Console.ReadLine();
                
                // Assign the value to a variable of that enum data type you just created.
                DaysOfWeek currentDay;
                if (Enum.TryParse(userInput, true, out currentDay))
                {
                    Console.WriteLine($"Today is: {currentDay}");
                }
                
                // Wrap the above statement in a try/catch block and have it print
                // "Please enter an actual day of the week.” to the console if an error occurs.
                else
                {
                    Console.WriteLine("Please enter an actual day of the week.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error has occurred: {ex.Message}");
            }
            Console.Read();
        }
    }
}
