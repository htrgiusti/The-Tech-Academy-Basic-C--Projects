using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // In the Main() method, create a list of at least 10 employees.
            // At least two employees should have the first name “Joe”.
            List<Employee> names = new List<Employee>()
            {
                new Employee() {Id = 8, FirstName = "Joe", LastName = "Williams"},
                new Employee() {Id = 2, FirstName = "Malik", LastName = "Alvarado"},
                new Employee() {Id = 9, FirstName = "Nicholas ", LastName = "Dalton"},
                new Employee() {Id = 1, FirstName = "Ricardo ", LastName = "Sparks"},
                new Employee() {Id = 6, FirstName = "Omar", LastName = "Berg"},
                new Employee() {Id = 3, FirstName = "Edwin", LastName = "VanCleef"},
                new Employee() {Id = 100, FirstName = "Phillip", LastName = "Padilla"},
                new Employee() {Id = 43, FirstName = "Joe", LastName = "Riley"},
                new Employee() {Id = 14, FirstName = "Joe", LastName = "Mueller"},
                new Employee() {Id = 5, FirstName = "Johnny", LastName = "Lucero"},
            };

            // Using a foreach loop, create a new list of all employees with the first name “Joe”.          
            List<Employee> Joes = new List<Employee>();
            
            foreach (Employee employee in names)
            {
                if (employee.FirstName == "Joe")
                {
                    Joes.Add(employee);
                }
            }

            // Display the employees with the first name "Joe" (foreach loop).
            Console.WriteLine("Employees with the first name Joe foreach loop: ");
            foreach (Employee employee in Joes)
            {
                Console.WriteLine($"Id: {employee.Id}, First Name: {employee.FirstName}, Last Name: {employee.LastName} \n");
            }           
            
            // Perform the same action again, but this time with a lambda expression.
            List<Employee> Joes2 = names.Where(x => x.FirstName == "Joe").ToList();

            // Display the employees with the first name "Joe" (lambda expression).
            Console.WriteLine("Employees with the first name Joe lambda expression: ");
            foreach (Employee employee in Joes2)
            {
                Console.WriteLine($"Id: {employee.Id}, First Name: {employee.FirstName}, Last Name: {employee.LastName} \n");
            }

            // Using a lambda expression, make a list of all employees with an Id number greater than 5.
            List<Employee> ids = names.Where(x => x.Id > 5).ToList();

            // Display all "id" numbers greater than 5 (lambda expression)
            Console.WriteLine("Display all numbers greater than 5 lambda expression");
            foreach (Employee employee in ids)
            {
                Console.WriteLine($"Id: {employee.Id}, First Name: {employee.FirstName}, Last Name: {employee.LastName}");
            }

            Console.Read();











        }
    }
}
