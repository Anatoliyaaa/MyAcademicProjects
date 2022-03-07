using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_10_R
{

    class Observable
    {
        private event Observer observers;
        public event Observer Observers
        {
            add
            {
                observers += value;
            }
            remove
            {
                observers -= value;
            }
        }
        public void ChangeState(Parameter parameter)
        {
            if (parameter.current_state == "работает")
            {
                parameter.quantity_state++;
            }
        }
        public void Notify(Parameter parameter)
        {
            if (observers != null)
            {
                ChangeState(parameter);
                observers(parameter);
            }

        }

    }
}
