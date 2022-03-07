using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_10_R
{

    public class ConcreteObserver
    {

        public static void ConcreteObserverTimeActivation(Parameter parameter)
        {
            string str = "Время активации: " + parameter.time_activation;
            Console.WriteLine(str);
        }
        public static void ConcreteObserverCurrentState(Parameter parameter)
        {
            string str = "Текущее состояние: " + parameter.current_state;
            Console.WriteLine(str);
        }
        public static void ConcreteObserverQuantityState(Parameter parameter)
        {
            string str = "Количество нахождений в состоянии \"работает\": " + parameter.quantity_state;
            Console.WriteLine(str);
        }

    }

}
