using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RC_comparison_method_options
{
    //comparison method options (метод сравнения вариантов)
    public class CMO_RC
    {

        public static List<RC> _RCs = new List<RC>();/*{ get;private set; }*/

        public CMO_RC(List<RC> r)
        {
            List<RC> _RCs = new List<RC>();
        }
        public static void Add(RC rc)
        {
            _RCs.Add(rc);
        }
        public static void Remove(RC rc)
        {
            _RCs.Remove(rc);
        }
        public static List<RC> ReturneList()
        {
            return _RCs;
        }
        public static bool IsYetRC(RC rc1, RC rc2) //нужно ли еще RC
        {
            if (rc1._P <= rc2._P)
                return false;
            else
            {
                _RCs.Add(rc2);
                return true;
            }

        }
        public static int CountRC()
        {
            return _RCs.Count();
        }

        public static bool IsYetRC(RC rc2) //нужно ли еще RC
        {
            List<RC> q = _RCs;
            RC rc1 = _RCs[_RCs.Count - 1];
            if (rc1._P <= rc2._P)
                return false;
            else
            {
                _RCs.Add(rc2);
                return true;
            }

        }

    }
}
