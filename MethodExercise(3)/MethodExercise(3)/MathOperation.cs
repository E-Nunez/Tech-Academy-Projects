using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercise_3_
{
    class MathOperation
    {
        public void MathCalc(out int num1)
        {
            num1 = 50;
            Console.WriteLine(num1 + " divided by 2 = " + (num1 / 2));

            Console.WriteLine();
        }

        public void MathCalc(out int num1, out int num2)
        {
            num1 = 2;
            Console.WriteLine("Enter a number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num2 + " divided by " + num1 + " = " + (num2 / num1));

            Console.WriteLine();
        }

        public void MathCalc(out int num1, out int num2, out int num3)
        {
            Console.WriteLine("Enter a number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number to multiply with previous number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            string result = Convert.ToString(num1 * num2);
            Console.WriteLine("= " + result);

 

            Console.WriteLine("Enter one more number to divide with the result of last two numbers entered: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(result + " divided by " + num3 + " = " + (Convert.ToInt32(result) / num3));
        }
    }
}
