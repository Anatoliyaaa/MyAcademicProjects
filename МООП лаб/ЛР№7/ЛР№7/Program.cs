using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_7
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDeque<int> deq1 = new MyDeque<int>() {1,2,3,4,5 };

            //сериализация/десериализация в/из бинарный/ного формат/а 
            MyDeque<int>.SaveDequeInBinaryFormat(deq1);
            MyDeque<int> deq2 = MyDeque<int>.OpenDequeFromBinaryFormat();
            foreach (int i in deq2)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
