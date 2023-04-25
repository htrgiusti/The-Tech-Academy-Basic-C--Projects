using System;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Academy of Learning Career College.");
            Console.WriteLine("Student Daily Report.");
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page number?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
            string needhelp = Console.ReadLine();
            bool needhelpbool = bool.Parse(needhelp);
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string experiences = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            int studyHoursNum = Convert.ToInt32(studyHours);
            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
