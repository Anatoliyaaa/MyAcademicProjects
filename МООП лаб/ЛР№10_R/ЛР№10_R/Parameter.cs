using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ЛР_10_R
{
    public class Parameter
    {

        public int time_activation; //время активации
        public string current_state; //текущее состояние
        public int quantity_state; //количесвто нахождений в состоянии "работает"


        public Parameter(int time_activation, string current_state)
        {
            this.time_activation = time_activation;
            this.current_state = current_state;
            this.quantity_state = 0;
        }

    }
}
