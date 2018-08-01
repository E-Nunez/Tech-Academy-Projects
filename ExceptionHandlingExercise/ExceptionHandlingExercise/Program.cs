using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<decimal> numbers = new List<decimal>() { 10, 20, 40, 70, 100 };
                Console.WriteLine("Pick a number to divide from the list \n (10, 20, 40, 70, 100)");
                decimal numInput = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine();


                for (int i = 0; i < numbers.Count; i++)
                {
                    decimal result = numbers[i] / numInput;
                    Console.WriteLine("Result:");
                    Console.WriteLine(result + "\n");
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                return;
            }

            Console.WriteLine("The Program has emerged from the try/catch block and continued with execution.");



            Console.ReadLine();
        }
    }
}
