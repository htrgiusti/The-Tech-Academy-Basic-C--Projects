using System;
using System.Collections.Generic;

namespace Strings_and_integers_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = new List<int>() { 100, 200, 50, 450, 535, 1000, 10 };

            bool numValid = false;
            while (!numValid)
            {
                try
                {
                    Console.Write("Enter a number to divide the above list by: ");
                    float userNumber = float.Parse(Console.ReadLine());

                    if (userNumber == 0)
                    {
                        Console.WriteLine("0 is not valid. Please enter another number.");
                    }
                    else
                    {
                        foreach (int num in numbersList)
                        {
                            float Divide = num / userNumber;
                            Console.WriteLine(num + "/" + userNumber + " = " + Divide);
                            numValid = true;
                        }
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please, enter a number.");
                }
                
            Console.WriteLine("The program has exited the try/catch block");
            Console.Read();
            }
        }
    }
}
