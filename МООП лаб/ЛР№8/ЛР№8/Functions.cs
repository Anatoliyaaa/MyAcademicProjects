using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_8
{
    class Functions
    {
        ////////////////////////
        public double F1(double x)
        {
            double result = x/Math.Pow(Math.Sin(2*x),3);

            return result;
        }
        public double F2(double x)
        {
            double result = (1-Math.Exp(0.7 / x)/(x+2));

            return result;
        }
        public double F3(double x)
        {
            double result = Math.Log(1+x)/x;

            return result;
        }
        ////////////////////////

        public double MapFunc1(double x)
        {
            return x * x * x;
        }
        public double MapFunc2(double x)
        {
            return -x;
        }
        public double MapFunc3(double x)
        {
            return Math.Sign(x);
        }

        ///////////////////////
        public double FoldFunc1(double x, double y)
        {
            return Math.Round(Math.Sqrt(x * y),3); 
        }
        public double FoldFunc2(double x, double y)
        {
            return x * y; 
        }
        public double FoldFunc3(double x, double y)//
        {
            return x < y ? x : y;
        }
    }
}
