using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ЛР_9
{
    public class Composite:Component
    {
        List<Component> floors;
        public int NumFloor { get; private set; }
        public static int count;
        public int stairs=1;
        public Composite(int qrooms, int qcorridors) : base(qrooms, qcorridors)
        {
            floors = new List<Component>();
            Leaf c = new Leaf(qrooms, qcorridors);
            floors.Add(c);
            this.NumFloor = Interlocked.Increment(ref count);
        }
        public Composite() 
        {
            floors = new List<Component>();
            this.NumFloor = Interlocked.Increment(ref count);
        }
        public override void Add(Component c)
        {
            floors.Add(c);
        }

        public override string Display(/*int Numfloor*/)
        {

            string result = "";
            foreach (Component c in floors)
            {
                if (stairs == NumFloor)
                {
                    result += "Этаж номер " + NumFloor + " " + c.Display();
                }
                else 
                {
                    result += "пройден\nЛестница\nЭтаж номер " + NumFloor + " " + c.Display();
                    stairs +=NumFloor-1;
                }
            }
            return result;
        }

        public override void Remove(Component c)
        {
            floors.Remove(c);
        }

        public override int S()
        {
            int S = 0;

            foreach (Component c in floors)
            {
                S += c.S();
            }
            return S;
        }

    }
}
