using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_8
{
    class HOF
    {
        //Правоассоциативная свёртка элементов списка без задания начального значения
        public static double FoldLFunctionSum(double[] mas)
        {
            double sum = 0;
            int index = mas.Length;
            sum = reduce(-1);

            double reduce(int ind)
            {
                ind++;
                if (ind == index)
                {
                    return 0;
                }

                return mas[ind] + reduce(ind);
            }
            return sum;


        }

        //функция отображения
        internal static void MapFunc(MapDelegate map, ref double[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = map(mas[i]);
            }
        }

        //функция свертки
        internal static double FoldFunc(FoldDelegate fold, double[] mas)
        {
            double result = 0;
            int index = mas.Length;
            result = reduce(-1);

            double reduce(int ind)
            {
                ind++;
                if (ind == index)
                {
                    return 1;
                }
                return fold(mas[ind], reduce(ind));
            }
            return result;
        }

    }
}
