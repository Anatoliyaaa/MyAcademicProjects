using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RC_comparison_method_options
{
    public class RC
    {
        double _K;//капитальные вложения на строительство/ремонт РЦ по тому же варианту;
        double _E;//нормативный коэффициент эффективности капитальных вложений;( Для каждого РЦ свой)
        double _IzS;//годовые издержки на содержание РЦ 
        double _IzD;// годовые издержки на доставку товаров с РЦ
        public double _P;//суммарные произведенные затраты по i-му варианту сооружения РЦ;

        //public int Count { get; private set; }// Количесвто РЦ
        //public static int count;
        public RC(double k, double e, double izS, double izD)
        {
            _K = k;
            _E = e;
            _IzS = izS;
            _IzD = izD;
            //Count = Interlocked.Increment(ref count);
            _P = AllZ();
        }

        public double AllZ() //считает все затраты
        {
            return _K * _E + _IzD + _IzS;
        }
    }
}
