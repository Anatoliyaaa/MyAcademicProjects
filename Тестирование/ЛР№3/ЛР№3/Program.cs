using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FF.ChangeStrInStr("1", "5", "2222"));
            Console.ReadKey();
            
        }
    }

    // s1 заменяется на s2 в строке s
    public class FF
    {
        public static string ChangeStrInStr(string s1, string s2, string s)
        {
            
            if (s1!="")                                     //1
            while (s.Contains(s1))                          //2
            {                                               
               int i = s.IndexOf(s1);                       //3
               s = s.Remove(i, s1.Length).Insert(i, s2);    
            }
            

            return s;                                       // 4
        }

    }
}
