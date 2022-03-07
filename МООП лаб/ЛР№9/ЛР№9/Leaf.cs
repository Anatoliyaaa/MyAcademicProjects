using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_9
{
    public class Leaf: Component
    {
        public Leaf(int srooms, int scorridors) : base(srooms, scorridors)
        {

        }

        public override void Add(Component c)
        {
            throw new NotImplementedException();
        }

        public override string Display()
        {

            return " | Площадь комнаты : " + RoomsS +" | Площадь коридора : " + CorridorsS+ "\n";
        }

        public override void Remove(Component c)
        {
            throw new NotImplementedException();
        }

        public override int S()
        {
            return RoomsS + CorridorsS ;
        }

    }
}
