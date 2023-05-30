using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    // метод Герона
    internal class SquareRootClass
    {
        public double SquareRootFind(double num)
        {

            double ran = num / 2;
            double result = ran;

            while (true)
            {
                double ran2 = (ran + num / ran) / 2;

                if (IsCloseEnough(ran, ran2))
                {
                    result = ran2;
                    break;
                }

                ran = ran2;
            }

            return result;
        }

        public static bool IsCloseEnough(double a, double b)
        {
            double epsilon = 0.000001;
            double diff = a - b;

            if (diff < 0)
            {
                diff = -diff;
            }

            return diff < epsilon;
        }
    }
}
