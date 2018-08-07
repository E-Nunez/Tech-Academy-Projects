using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercise_2_
{
    class MathCalc
    {
        public static int MathOperation(int num1)
        {
            return num1 + 10;
        }

        public static int MathOperation(decimal num2)
        {
            return Convert.ToInt32(num2 - 10);
        }

        public static int MathOperation(string num3)
        {
            return (Convert.ToInt32(num3) * 10);
        }
    }
}
