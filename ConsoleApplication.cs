using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Application_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is an assignment in which I had to create 5 different math operations using user inputs.

            Console.WriteLine("Give a number from 1 to 100.");
            string num1 = Console.ReadLine();
            int total = Convert.ToInt32(num1) * 50;
            Console.WriteLine("Your number multiplied by 50 is: " + total);

            Console.WriteLine("Give a number from 1 to 100.");
            string num2 = Console.ReadLine();
            int total2 = Convert.ToInt32(num2) + 25;
            Console.WriteLine("Your number plus 25 is: " + total2);

            Console.WriteLine("Give a number from 1 to 100.");
            string num3 = Console.ReadLine();
            float total3 = Convert.ToInt32(num3) / 12.5f;
            Console.WriteLine("Your number divided by 12.5 is: " + total3);

            Console.WriteLine("Type a number.");
            string num4 = Console.ReadLine();
            bool total4 = Convert.ToInt32(num4) > 50;
            Console.WriteLine("Is your number greater than 50? Answer: " + total4);

            Console.WriteLine("Type a number.");
            string num5 = Console.ReadLine();
            int remainder = Convert.ToInt32(num5) % 7;
            Console.WriteLine("The remainder of your number divided by 7 is: " + remainder);

            Console.Read();
        }
    }
}
