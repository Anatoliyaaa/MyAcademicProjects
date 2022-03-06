using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Приложение_V_0._1
{
    public class MyPoint
    {
        public double _x;
        public double _y;
        double _ED;
        public bool _p;

        public MyPoint(double x, double y, double ED, bool p)
        {
            _x = x;
            _y = y;
            _ED = ED;
            _p = p;
        }

        public static void DemoSort(List<MyPoint> points)
        {
            MyPoint temp;
            for (int i = 0; i < points.Count - 1; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    if (points[i]._ED > points[j]._ED)
                    {
                        temp = points[i];
                        points[i] = points[j];
                        points[j] = temp;
                    }
                }
            }
        }

        public static double R(double lat1, double lon1, double lat2, double lon2) // перевод из градусов в километры
        {
            var R = 6378.137; // Radius of earth in KM
            var dLat = lat2 * Math.PI / 180 - lat1 * Math.PI / 180;
            var dLon = lon2 * Math.PI / 180 - lon1 * Math.PI / 180;
            var a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) + Math.Cos(lat1 * Math.PI / 180) * Math.Cos(lat2 * Math.PI / 180) * Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            var d = R * c;
            return d;
        }

    }
}
