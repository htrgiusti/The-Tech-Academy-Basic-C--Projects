using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int dach = 0;
            while (dach < 10) // While dach is less than 10
            {
                // Boolean comparison using a while statement
                Console.WriteLine("I love Dachshund dogs!"); // Write a message to the console
                dach++; // Increment dach by 1
            }
            
            // Boolean comparison using a do while statement
            int sausage = 0;
            do
            {
                Console.WriteLine("Sausage dogs are the best!"); // Write a message to the console
                sausage++; // Increment sausage by 1
            } while (sausage < 10); // While sausage is less than 10

            Console.WriteLine("Enter the name of your Dachshund dog:"); // Prompt the user to enter the name of their dachshund dog
            string name = Console.ReadLine(); // Read the user's input from the console

            Console.WriteLine($"Hello {name}, the sausage dog!"); // Write a greeting to the console
            Console.Read();
                
        }
    }
}
