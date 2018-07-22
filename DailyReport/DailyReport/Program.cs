using System;

namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine();

            Console.WriteLine("Student Daily Report");
            Console.WriteLine("");

            Console.WriteLine("What Course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("What page number?");
            int pageNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string needHelp = Console.ReadLine();
            bool ndHelp = Convert.ToBoolean(needHelp);
            Console.WriteLine();

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string posExp = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("How many hours did you study today?");
            decimal studyHours = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();

            string reportResponse = "Thank you for your answers. An Instructor will respond to this shortly. Have a great day!";
            Console.WriteLine(reportResponse);

            Console.ReadLine();

        }
    }
}
