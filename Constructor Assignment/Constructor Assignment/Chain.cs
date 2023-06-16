using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Assignment
{
    class Chain
    {
        string Name { get; set; }
        float Num { get; set; }
        
        // Constructor if both parameters, a string and a float, are provided.
        public Chain(float num, string name)
        {
            Name = name;
            Num = num;
        }

        // Constructor if only a float is provided
        public Chain(float num1) : this(num1, "Heitor")
        {
            Console.WriteLine(num1 + " and your default name is: " + Name);
        }

        // Constructor if only a string is provided
        public Chain(string name1) : this(100, name1)
        {
            Console.WriteLine(name1 + " and your default favorite number is: " + Num);
        }


    }
}
