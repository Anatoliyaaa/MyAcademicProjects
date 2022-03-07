using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_8
{
    delegate double MyDelegate(double x);
    delegate double MapDelegate(double x);
    delegate double FoldDelegate(double x, double y);
    public class Program
    {
        public static void Main(string[] args)
        {
            Functions functions = new Functions();

            MyDelegate f = new MyDelegate(functions.F1);
            int n = 50;

            Console.WriteLine("Вычисление интеграла методом левосторонних прямоугольников\n");

            double I1 = Integral.LeftRectangle(f, 0.1, 0.5, n);
            Console.WriteLine("Значение интерграла с шагом N: " + I1);
            double I2 = Integral.LeftRectangle(f, 0.1, 0.5, 2 * n);
            Console.WriteLine("Значение интерграла с шагом 2N: " + I2);
            Console.WriteLine("Погрешность по правилу Рунге: " + Integral.Runge(I1, I2) + "\n");

            f -= functions.F1;
            f += functions.F2;

            I1 = Integral.LeftRectangle(f, 1, 3, n);
            Console.WriteLine("Значение интерграла с шагом N: " + I1);
            I2 = Integral.LeftRectangle(f, 1, 3, 2 * n);
            Console.WriteLine("Значение интерграла с шагом 2N: " + I2);
            Console.WriteLine("Погрешность по правилу Рунге: " + Integral.Runge(I1, I2) + "\n");

            f -= functions.F2;
            f += functions.F3;

            I1 = Integral.LeftRectangle(f, 0.1, 1, n);
            Console.WriteLine("Значение интерграла с шагом N: " + I1);
            I2 = Integral.LeftRectangle(f, 0.1, 1, 2 * n);
            Console.WriteLine("Значение интерграла с шагом 2N: " + I2);
            Console.WriteLine("Погрешность по правилу Рунге: "+Integral.Runge(I1, I2) + "\n");



            Console.WriteLine("\nФункция правоассоциативной свёртки без задания начального значения ");
            Console.Write("Массив: ");
            double sum = 0;
            double[] a = { 1, 4, 5, 15};

            Write(a);

            sum = HOF.FoldLFunctionSum(a);
            Console.WriteLine("\nСумма ряда: " + sum);


            Console.WriteLine("\nOбращение к функции отображения: ");
            double[] a1 = { -7, 0, 5, 5, 7 };

            Write(a1);


            MapDelegate map = new MapDelegate(functions.MapFunc1);
            HOF.MapFunc(map, ref a1);
            Write(a1);




            map -= functions.MapFunc1;
            map += functions.MapFunc2;
            HOF.MapFunc(map, ref a1);
            Write(a1);


            map -= functions.MapFunc2;
            map += functions.MapFunc3;
            HOF.MapFunc(map, ref a1);
            Write(a1);
 

            Console.WriteLine("\nOбращение к функции свертки: ");
            FoldDelegate fold = new FoldDelegate(functions.FoldFunc1);
            double[] a2 = { 1, 2, 3 };
            Write(a2);

            Console.WriteLine("Функция 1: " + HOF.FoldFunc(fold, a2));
            fold -= functions.FoldFunc1;
            fold += functions.FoldFunc2;
            Console.WriteLine("Функция 2: " + HOF.FoldFunc(fold, a2));
            fold -= functions.FoldFunc2;
            fold += functions.FoldFunc3;
            Console.WriteLine("Функция 3: " + HOF.FoldFunc(fold,a2));
             

            Console.ReadLine();
        }
        public static void Write(double[] mas)
        {
            Console.Write("Массив : ");
            foreach (double i in mas)
            {
                Console.Write(i + "  ");
            }
            Console.WriteLine();
        }



    }

}
