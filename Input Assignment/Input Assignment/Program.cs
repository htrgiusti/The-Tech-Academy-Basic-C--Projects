using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Input_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number: "); // Asks the user to type a number
            string userInput = Console.ReadLine(); // Stores the user's input in the variable "userInput"
            File.WriteAllText(@"C:\Users\Heitor\Logs\log.txt", userInput); // Creates a log.txt and writes the contents of "userInput" into it
            Console.WriteLine("Log print: "); // Prints the line "Log print: "
            Console.WriteLine(File.ReadAllText(@"C:\Users\Heitor\Logs\log.txt")); // Reads the contents of the "log.txt" file, which contains the user's input, and prints it

            Console.Read();
            
        }
    }
}
