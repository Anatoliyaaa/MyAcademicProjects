using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_2
{
    class Program
    {
        static void Main(string[] args)
        {
            FF ff = new FF();
            ff.R = 20;
            Console.ReadKey();
        }
    }

    public class FF
    {

        double r = 5;
        public double R
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("R должен быть больше 0");
                }
                else
                {
                    r = value;
                }
            }
            get { return r; }
        }

        public bool HitCheck(double x, double y)
        {
            if (x >= 0 && y >= 0) // 1 chetvert`
            {
                if (r * r >= (x - r) * (x - r) + y * y)
                    return true;
            }

            if (x <= 0 && y <= 0) // 4 chetvert`
            {
                if (r * r <= (x + r) * (x + r) + (y + r) * (y + r)) // vne okrujnosti
                    if (x >= -r && y >= -r) // tol`ko v uglu
                      return true;
            }

            return false;

        }

    }
}
