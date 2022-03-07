using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ЛР_9
{
    public abstract class Component
    {
        //

        public int RoomsS { get; set; }
        public int CorridorsS { get; set; }

        public Component (int srooms, int scorridors)
        {
            CorridorsS = scorridors;
            RoomsS = srooms;

        }
        public Component()
        {
            CorridorsS = 0;
            RoomsS = 0;

        }
        public abstract int S();
        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract string Display(/*int c*/);

    }
}
