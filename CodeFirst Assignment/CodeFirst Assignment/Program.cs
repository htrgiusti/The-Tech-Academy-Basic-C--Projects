using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                Console.WriteLine("Enter the student First Name: ");
                var firstName = Console.ReadLine();
                Console.WriteLine("Enter the student Last Name: ");
                var lastName = Console.ReadLine();
                Console.WriteLine("Enter the student Age: ");
                var age = Convert.ToInt32(Console.ReadLine());

                var student = new Student { FirstName = firstName, LastName = lastName, Age = age };
                db.Students.Add(student);
                db.SaveChanges();
            }
        }
           
        public class Student
        {
            public int StudentId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
        }

        public class StudentContext : DbContext
        {
            public DbSet<Student> Students { get; set; }

            public StudentContext() : base("Data Source=HEITOR\\SQLEXPRESS;Initial Catalog = \"CodeFirst Assignment\"; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
            {
                Database.SetInitializer<StudentContext>(new DropCreateDatabaseIfModelChanges<StudentContext>());
            }
        }
    }
}
