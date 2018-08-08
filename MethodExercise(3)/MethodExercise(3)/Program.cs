using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercise_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int num2;
            int num3;
            MathOperation divide = new MathOperation();
            divide.MathCalc(out num);
            divide.MathCalc(out num, out num2);
            divide.MathCalc(out num, out num2, out num3);
            Console.ReadLine();
            
        }
    }
}
