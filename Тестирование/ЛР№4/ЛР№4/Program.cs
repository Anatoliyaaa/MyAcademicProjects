using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ЛР_4
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    // s1 заменяется на s2 в строке s
    public class GG
    {
        public static string ChangeStrInStr(string s1, string s2, string s)
        {

            if (s1 != "")                                     //1
                while (s.Contains(s1))                          //2
                {
                    int i = s.IndexOf(s1);                       //3
                    s = s.Remove(i, s1.Length).Insert(i, s2);
                }


            return s;                                       // 4
        }

    }

    public class FF
    {

        double r = 5;
        public double R
        {
            set
            {
                if (value <= 0)
                {
                    r = 5;
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
