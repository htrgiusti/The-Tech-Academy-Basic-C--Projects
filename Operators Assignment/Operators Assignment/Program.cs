using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating Employee objects
            Employee emp1 = new Employee { Id = 1, FirstName = "Renato", LastName = "Onix" };
            Employee emp2 = new Employee { Id = 2, FirstName = "Juliana", LastName = "Novac" };
            Employee emp3 = new Employee { Id = 1, FirstName = "Heitor", LastName = "Giusti" };


            // Performing comparisons using overloaded operators
            Console.WriteLine($"Employee 1 \n Id: {emp1.Id} \n First Name: {emp1.FirstName} \n Last Name: {emp1.LastName}\n");
            Console.WriteLine($"Employee 2 \n Id: {emp2.Id} \n First Name: {emp2.FirstName} \n Last Name: {emp2.LastName}\n");
            Console.WriteLine($"Employee 3 \n Id: {emp3.Id} \n First Name: {emp3.FirstName} \n Last Name: {emp3.LastName}\n");

            Console.WriteLine($"Employee 1 Id == Employee 2 Id: {emp1 == emp2}");
            Console.WriteLine($"Employee 1 Id == Employee 3 Id: {emp1 == emp3}");
            
            Console.WriteLine($"Employee 1 Id != Employee 2 Id: {emp1 != emp2}");
            Console.WriteLine($"Employee 1 Id != Employee 3 Id: {emp1 != emp3}");
            



            Console.Read();

        }
    }
}
