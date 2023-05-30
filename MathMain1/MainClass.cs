using MathLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMain1
{
    public class MainClass
    {
        public static void Main()
        {
            List<double> list = new List<double>()
            {
                1, 3, 5, 7, 8, 10, 12
            };
            List<double> result = AlgebraClass.SolveSquareRootEquation(-3, 5, -3);
            string resultString = string.Join("  ", result);
            Console.WriteLine("Корни x1,x2: " + resultString);
            Console.WriteLine("Корень х: " + AlgebraClass.SolveLinearEquation(1, 3));
            Console.WriteLine("Сумма ряда: " + AlgebraClass.SumSeries(list));
            Console.WriteLine("Максимальное число ряда: " + AlgebraClass.MaxSeries(list));
            Console.WriteLine("Среднее число ряда: " + AlgebraClass.AvgSeries(list));

            Console.WriteLine("Площадь треугольника: " + GeometryClass.TriangleArea(5, 3));
            Console.WriteLine("Площадь прямоугольного треугольника: " + GeometryClass.RightTriangleArea(5, 7));
            Console.WriteLine("Площадь прямоугольника: " + GeometryClass.RectangleArea(5, 7));
            Console.WriteLine("Площадь круга: " + GeometryClass.CircleArea(5.3));
            Console.WriteLine("Площадь трапеции: " + GeometryClass.TrapezoidArea(5, 7, 9));

            double a = 10; // Гипотенуза
            double b = 7; // Катетт
            double c = 8; // Катет

            Console.WriteLine("Синус: " + TrigonometryClass.SinValue(a, b, c));
            Console.WriteLine("Косинус: " + TrigonometryClass.CosValue(a, b, c));
            Console.WriteLine("Тангенс: " + TrigonometryClass.TanValue(a, b, c));
            Console.WriteLine("Котангенс: " + TrigonometryClass.CotanValue(a, b, c));
            Console.WriteLine("Арксинус: " + TrigonometryClass.ArcsinValue(a, b, c));
        }
    }
}
