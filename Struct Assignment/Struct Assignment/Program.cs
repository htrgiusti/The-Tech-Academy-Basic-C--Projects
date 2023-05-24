using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // In the Main() method, create an object of data type Number and assign an amount to it.
            Number num = new Number();
            num.Amount = 9.99m;

            // Print this amount to the console.
            Console.WriteLine(num.Amount);

            Console.Read();

        }
    }
}
