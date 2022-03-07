using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite a = new Composite(10,5);
            a.Add(new Leaf(5, 1));
            Composite b = new Composite(20, 9);
            //a.Add(new Leaf(14, 2));
            //a.Add(new Leaf(51, 1));
            //a.Add(new Leaf(42, 4));
            b.Add(new Leaf(11, 4));
            //b.Add(new Leaf(25, 7));

            //Composite c = new Composite(15, 4);
            //Composite e = new Composite(17, 5);

            //c.Add(new Leaf(19, 3));
            //c.Add(e);

            //b.Add(c);
            a.Add(b);


            Console.WriteLine("Площадь здания равна "+ a.S());
            Console.WriteLine(a.Display());
            Console.ReadKey();

        }
    }
}
