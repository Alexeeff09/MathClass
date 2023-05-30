using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class TrigonometryClass
    {
        public static double SinValue(double a, double b, double c)
        {
            return b / a;
        }
        public static double CosValue(double a, double b, double c)
        {
            return c / a;
        }
        public static double TanValue(double a, double b, double c)
        {
            return b / c;
        }
        public static double CotanValue(double a, double b, double c)
        {
            return c / b;
        }
        public static double ArcsinValue(double a, double b, double c)
        {
            return Math.Asin(SinValue(a, b, c));
        }
    }
}
