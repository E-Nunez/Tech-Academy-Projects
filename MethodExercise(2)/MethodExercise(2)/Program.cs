using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercise_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MathCalc.MathOperation(12));
            Console.WriteLine(MathCalc.MathOperation(10.75m));
            Console.WriteLine(MathCalc.MathOperation("5"));
            Console.ReadLine();
        }
    }


}
