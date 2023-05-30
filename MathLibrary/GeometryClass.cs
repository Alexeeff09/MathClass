using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class GeometryClass
    {

        public static double TriangleArea(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }

        public static double RightTriangleArea(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }

        public static double RectangleArea(double length, double width)
        {
            return length * width;
        }

        public static double CircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public static double TrapezoidArea(double base1, double base2, double height)
        {
            return 0.5 * (base1 + base2) * height;
        }
    }
}

