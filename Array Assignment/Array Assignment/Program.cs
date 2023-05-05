using System;
using System.Collections.Generic;

namespace Array_Assignment
{
    class Program
    {
        static void Main()
        {
            // Create a string array with some animal names
            string[] animalsArray = { "Tiger", "Bear", "Falcon", "Lion", "Dog", "Snake", "Spider" };
            Console.WriteLine("Select an index between 0 and 6 of the string array");
            // Prompt the user to select an index for the string array and store their input in a variable
            int stringSelect = Convert.ToInt32(Console.ReadLine());

            // Check if the selected index is within the bounds of the array and display the corresponding number if it is
            if (stringSelect >= 0 && stringSelect < animalsArray.Length)
            {
                Console.WriteLine($"The string at index {stringSelect} is {animalsArray[stringSelect]}");
            }
            else
            {
                Console.WriteLine("That index doesn't exist.");
            };

            
            // Create an integer array with some numbers
            int[] numbersArray = { 10, 430, 830, 1000, 2, 15 };
            Console.WriteLine("Select an index between 0 and 5 of the number array");
            // Prompt the user to select an index for the integer array and store their input in a variable
            int intSelect = Convert.ToInt32(Console.ReadLine());
            
            // Check if the selected index is within the bounds of the array and display the corresponding number if it is
            if (intSelect >= 0 && intSelect < numbersArray.Length)
            {
                Console.WriteLine($"The number at index {intSelect} is {numbersArray[intSelect]}");
            }
            else
            {
                Console.WriteLine("That index doesn't exist.");
            };

            
            // Create a list of strings with some fruit names
            List<string> fruitList = new List<string> { "Strawberry", "Banana", "Grape", "Apple", "Cherry" };
            Console.WriteLine("Select an index between 0 and 4 of the string List");
            // Prompt the user to select an index for the list and store their input in a variable
            int listIndex = Convert.ToInt32(Console.ReadLine());
            
            // Check if the selected index is within the bounds of the list and display the corresponding fruit if it is
            if (listIndex >= 0 && listIndex < fruitList.Count)
            {
                Console.WriteLine($"The fruit at index {listIndex} is {fruitList[listIndex]}");
            }
            else
            {
                Console.WriteLine("That index doesn't exist.");
            }


            // Wait for the user to press a key before exiting the program
            Console.Read();
        }
    }
}
