using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_10_R
{
    class Program
    {
        static void Main(string[] args)
        {
            Observable observable = new ConcreteObservable();
            observable.Observers += ConcreteObserver.ConcreteObserverTimeActivation;
            observable.Observers += ConcreteObserver.ConcreteObserverCurrentState;
            observable.Observers += ConcreteObserver.ConcreteObserverQuantityState;
            Parameter p = new Parameter(5, "работает");
            observable.Notify(p);
            Console.WriteLine();

            p.current_state = "отдыхает";           
            observable.Notify(p);
            Console.WriteLine();
            p.current_state = "работает";
            observable.Notify(p);
            Console.WriteLine();
            p.current_state = "умер";
            observable.Notify(p);
            Console.WriteLine();
            p.current_state = "спит";
            observable.Notify(p);
            Console.WriteLine();
            p.current_state = "работает";
            observable.Notify(p);
            Console.WriteLine();

            Console.ReadKey();
            Console.Clear();

            Parameter p2 = new Parameter(19, "что-то там");
            observable.Notify(p2);
            Console.WriteLine();
            p2.current_state = "работает";
            observable.Notify(p2);
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
