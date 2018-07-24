using System;

namespace BooleanLogicExercise
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            int ageNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Have you ever had a DUI? Answer \"true\" or \"false\"");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("How many speeding tickets do you have?");
            int ticketNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
            Console.WriteLine("Qualified for car insurance?");
            bool over15 = ageNum > 15;
            bool noDUI = dui == false;
            bool speedTicket = ticketNum < 3;
            bool qualified = (over15 && noDUI && speedTicket);
            Console.WriteLine(qualified);

            
            Console.ReadLine();
        }
    }
}
