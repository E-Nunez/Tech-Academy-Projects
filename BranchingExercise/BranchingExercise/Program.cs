using System;

namespace BranchingExercise
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine();

            Console.WriteLine("Please enter the package weight:");
            decimal packWeight = Convert.ToDecimal(Console.ReadLine());
            if (packWeight > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }
            Console.WriteLine();

            Console.WriteLine("Please enter the package width:");
            decimal packWidth = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Please enter the package height:");
            decimal packHeight = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Please enter the package length:");
            decimal packLength = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();

            decimal totalDimension = packWidth * packHeight * packLength;

            if (totalDimension > 50)
            {
                Console.WriteLine("Package is too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }
            Console.WriteLine();

            decimal totalQuote = ((totalDimension * packWeight)  / 100.0m);

            string totalPack = String.Format("Your estimated total for shipping this package is : {0:C}", totalQuote);
            Console.WriteLine(totalPack);
            Console.WriteLine("Thank You.");

            
            Console.ReadLine();
        }
    }
}
