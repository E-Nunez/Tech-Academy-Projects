using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello, my name is: \n";
            string name = "Eric ";
            string lastName = "Nunez";

            hello = hello.ToUpper();

            Console.WriteLine(hello + name + lastName);
            Console.WriteLine();

            StringBuilder paragraph = new StringBuilder();

            paragraph.Append("The Tech Academy is a code school that was founded in 2014 by Erik Gross and Jack Stanley. ");
            paragraph.Append("Their Software Developer Boot Camp is available online in full and they have campuses in Portland, Oregon; Seattle, Washington; and Denver, Colorado. ");
            paragraph.Append("Students can attend in-person or study online from home.");

            Console.WriteLine(paragraph);

            

            Console.ReadLine();
        }
    }
}
