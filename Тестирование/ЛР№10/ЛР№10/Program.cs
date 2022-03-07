using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace ЛР_10
{
    public delegate double Func(double x);
    public class Program
    {
        public static int FN = 1;//A
        public static int LN = 23;//X
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение шага n");
            int n = Convert.ToInt32(Console.ReadLine());
            
            Func func = new Func(function);
       
            double In = Trapec(func, -1.0, 1.0, n);
            double I2n = Trapec(func, -1.0, 1.0, 2 * n);
            
            double runge = Runge(In, I2n);
            Console.WriteLine("Погрешность по Рунге: " + runge);

            Console.WriteLine("Введите значение для факториала ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Факториал: " + factorial(n));
            Console.ReadKey();

        }
        public static double function(double x)
        {
            return Math.Sin(x + 2) / (0.4 + Math.Cos(x));
        }
        public static double Trapec(Func del, double a, double b, int n)
        {
            Debug.Assert(n > 0, "Неверно указано количество шагов");
            double result = 0;
            double h = (double)(b - a) / n;
            double x1 = (double)a + h;
            Debug.Assert(x1 >= a, "Неверно указано количество шагов");
            if (x1 < a)
            {
                throw new ArgumentOutOfRangeException();
            }

            for (int k = 1; k <= n; k++)
            {
                double x2 = (double)(x1 - h);
                result += (double)(del(x2) + del(x1)) / 2;

                //Debug.WriteLine(result.ToString());

                if (k == FN)
                    Debug.WriteLine(FN + ": " + result.ToString());
                if (k == LN)
                {
                    Debug.WriteLine(LN + ": " + result.ToString());
                }
                x1 += (double)h;
            }

            result *= h;
            Debug.WriteLine(result.ToString());
            return result;
        }
        public static int factorial(int n)
        {
            if (n < 0) throw new OverflowException();
            if (n == 0) return 1;
            if (n == 1) return 1;
            int result;
            try
            {
                result = factorial(n - 1) * n;
            }
            catch
            {
                Trace.WriteLine("Переполнение стека");
                throw new OverflowException();
            }
            return result;
        }
        public static double Runge(double a, double b)
        {
            return Math.Round(Math.Abs(b - a) / 3, 10);
        }

    }

}
