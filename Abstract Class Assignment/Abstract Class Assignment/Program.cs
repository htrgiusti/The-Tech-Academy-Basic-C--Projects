﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inside the Main() method, instantiate an Employee object with firstName “Sample” and lastName “Student”.
            // Call the SayName() method on the object.
            Employee employee = new Employee()
            {
                FirstName = "Heitor",
                LastName = "Giusti"
            };

            employee.SayName();

            Console.Read();

        }
    }
}
