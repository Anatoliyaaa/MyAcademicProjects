using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_8
{
    class Integral
    {
        public static double LeftRectangle(MyDelegate f, double a, double b, int n)
        {
            double result = 0;
            double h = (b - a) / n;
            double x = a;
            do
            {
                result += f(x);
                x += h;
            } while (x <= b - h) ;

            return Math.Round(result,3);
        }

        public static double Runge(double a, double b)
        {
            return Math.Round(Math.Abs(b - a) / 3, 3);
        }

    }
}
