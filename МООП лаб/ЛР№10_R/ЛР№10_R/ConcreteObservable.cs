using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_10_R
{
    class ConcreteObservable: Observable
    {
        private Parameter parameter;
        public Parameter Parameter
        {
            get
            {
                return parameter;
            }
            set
            {
                this.parameter = value;
                this.Notify(parameter);
            }
        }

    }
}
