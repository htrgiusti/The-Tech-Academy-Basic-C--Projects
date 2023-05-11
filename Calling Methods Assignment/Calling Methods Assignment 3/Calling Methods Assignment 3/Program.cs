using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods_Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathMethods class
            MathMethods math1 = new MathMethods();

            // Call the first method with an int parameter 
            Console.WriteLine(math1.MathOp(10));

            // Call the second method with a decimal parameter 
            Console.WriteLine(math1.MathOp(5.5m));

            // Call the third method with a string parameter 
            Console.WriteLine(math1.MathOp("1000"));
            

            Console.Read();
        }
    }
}
