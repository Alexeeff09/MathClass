using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class AlgebraClass
    {
        public static List<double> SolveSquareRootEquation(double a, double b, double c)
        {
            SquareRootClass squareRootClass = new SquareRootClass();
            double D, x1, x2;
            List<double> resultList = new List<double>();

            //Неполные квадратные уравнения
            if (b == 0)
            {
                x1 = 0;
                x2 = -b / a;
                resultList.Add(x1);
                resultList.Add(x2);
                return resultList;
            }
            else if (c == 0)
            {
                x1 = squareRootClass.SquareRootFind(a / -c);
                resultList.Add(x1);
                return resultList;
            }
            else if (a == 0)
            {
                x1 = -c / b;
                resultList.Add(x1);
                return resultList;
            }
            // Полное квадратное уравнение
            else
            {
                D = b * b - 4 * a * c;
                if (D < 0)
                {
                    Console.WriteLine("Корней нет");
                }
                else if (D == 0)
                {
                    x1 = (-b + squareRootClass.SquareRootFind(D)) / (2 * a);
                    resultList.Add(x1);
                }
                else
                {
                    x1 = (-b + squareRootClass.SquareRootFind(D)) / (2 * a);
                    x2 = (-b - squareRootClass.SquareRootFind(D)) / (2 * a);
                    resultList.Add(x1);
                    resultList.Add(x2);
                }

                return resultList;
            }
        }
        public static double SolveLinearEquation(double a, double b)
        {
            if (a == 0)
            {
                Console.WriteLine("Коэффициент 'a' не может быть равен нулю.");
                return 0;
            }
            double x = -b / a;
            return x;
        }

        public static double SumSeries(List<double> list)
        {
            double sum = 0;
            foreach (double item in list)
            {
                sum += item;
            }
            return sum;
        }

        public static double MaxSeries(List<double> list)
        {
            double max = list.ElementAt(0);
            foreach (double item in list)
            {
                if (item > max) max = item;
            }
            return max;
        }

        public static double AvgSeries(List<double> list)
        {
            double sum = 0;
            int count = 0;
            foreach (double item in list)
            {
                sum += item;
                count++;
            }
            return sum / count;
        }


    }
}
