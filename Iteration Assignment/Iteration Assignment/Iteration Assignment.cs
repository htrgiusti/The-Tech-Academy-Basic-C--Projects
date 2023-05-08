using System;
using System.Collections.Generic;

namespace Iteration_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // *Console App Assignment Part 1*

            // Create an array of strings
            string[] names = new string[] { "Bob", "John", "Tyler", "Edward" };

            // Ask the user to input some text
            Console.WriteLine("Enter a surname: ");
            string userSurname = Console.ReadLine();

            // Loop through each string in the array and add user's text input
            for (int i = 0; i < names.Length; i++)
            {
                names[i] += userSurname;
            }

            // Print each string in the updated array
            foreach (string str in names)
            {
                Console.WriteLine(str);
            }
            Console.Read();



            // *Console App Assignment Part 2* 

            // Add an infinite loop
            while (true)
            {
                // Ask the user to enter a number
                Console.WriteLine("Enter a number: ");

                // Read the user's input
                string input = Console.ReadLine();

                // Exit the loop if the user enters ''quit''
                if (input.ToLower() == "quit")
                {
                    break; // exit the loop
                }
            }



            // *Console App Assignment Part 3*

            // A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator.

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Loop 1 iteration {i + 1}");
            }

            // Loop using "<=" operator

            for (int j = 0; j <= 5; j++)
            {
                Console.WriteLine($"Loop 2 iteration {j + 1}");
            }

            Console.Read();



            // *Console App Assignment Part 4*

            // Create a list of strings
            List<string> fruitList = new List<string> { "apple", "banana", "grape", "strawberry" };

            // Ask the user to input text to search for in the list
            Console.WriteLine("Enter a fruit name to search for in the list: ");
            string userInput = Console.ReadLine();

            // A bool to indicate whether a match has been found
            bool matchFound = false;

            // Loop through the list and check for a match
            for (int i = 0; i < fruitList.Count; i++)
            {
                if (fruitList[i].Contains(userInput))
                {
                    // Display the index of the list item that contains matching text
                    Console.WriteLine($"Fruit name found at index {i}");

                    // Set the bool to true
                    matchFound = true;

                    // Stop the loop from executing further
                    break;
                }
            }

            // Check if a match was found
            if (!matchFound)
            {
                // Display a message saying that the input is not on the list   
                Console.WriteLine("Your input is not on the list.");
            }

            Console.Read();



            // *Console App Assignment Part 5*

            // A list of strings that has at least two identical strings in the list. 
            List<string> names = new List<string> { "Heitor", "Heitor", "Jesse", "James", "Ash", "Oak" };

            // Ask the user to select text to search for in the list.
            Console.WriteLine("Type a name to search for in the list: ");
            string userInput = Console.ReadLine();

            // A bool to indicate whether a match has been found
            bool matchFound = false;

            // Loop through the list and check for a match
            for (int i = 0; i < names.Count; i++)
            {
                // If a matching string is found, display its index and set matchFound to true
                if (names[i].Equals(userInput))
                {
                    Console.WriteLine($"Match found at index: {i}");
                    matchFound = true;
                }
            }

            // If no matches were found, display a message to the user
            if (!matchFound)
            {
                Console.WriteLine($"No matches found for {userInput}");
            }
            Console.Read();



            // *Console App Assignment Part 6*
            
            // Create a list of strings that has at least two identical strings in the list. 
            List<string> animalList = new List<string>() { "Lion", "Tiger", "Cat", "Lion", "Bird", "Turtle" };
            List<string> repeatCheck = new List<string>();
            Console.WriteLine("Animals List: ");

            // Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.
            foreach(string animal in animalList)
            {
                Console.WriteLine(animal);
                if (repeatCheck.Contains(animal))
                {
                    Console.WriteLine("This animal has been repeated.");
                }
                else
                {
                    Console.WriteLine("This animal has not been repeated.");
                }
                repeatCheck.Add(animal);
            }
            Console.Read();
























        }
    }
}
