using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Приложение_V_0._1
{
    public class SectorCounting
    {
        //dolgota
        public static double d1 = 44.925799;
        public static double d2 = 45.151153;
        //shirota
        public static double sh1 = 38.875634;
        static double sh2 = 39.201794;

        public static int A = 0;
        public static int B = 0;

        public static double nx = Nx();
        public static double ny = Ny();

        const int N = 4;

        static double Nx()
        {
            Poisk_A_B();
            double nx = (sh2 - sh1) / A;
            return nx;
        }

        static double Ny()
        {
            double ny = (d2 - d1) / B;
            return ny;
        }


        static void Poisk_A_B()
        {
            double L = Math.Ceiling( Math.Sqrt(N));
            A = N;
            for (int i = 1; i < L+1; i++)
                if (L % i == 0)
                    if (Math.Abs(i - L) < Math.Abs(A - L))
                        A = i;
            B = N / A;
        }

        public static int Ncount()
        {
            return N;
        }

    }
}
