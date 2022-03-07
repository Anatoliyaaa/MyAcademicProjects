using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ЛР_6
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class MyDeque<T> : IMyDeque<T>
    {
        T[] deq;
        public T this[int index]
        {
            get => deq[index];
            set => deq[index] = value;
        }
        public MyDeque()
        {
            deq = new T[0];
        }
        public int Lenght()
        {
            return deq.Length;
        }
        public void Clear()
        {
            Array.Clear(deq, 0, deq.Length);
        }
        public void RemoveAll()
        {
            T[] d = new T[0];
            deq = d;
        }

        public bool IsEmpety()
        {
            return deq.Length == 0;
        }

        public void Add(T a)
        {
            T[] d = new T[deq.Length + 1];
            for (int i = 0; i < deq.Length; i++)
                d[i] = deq[i];
            d[d.Length - 1] = a;
            deq = d;
        }

        public void AddFirst(T a)
        {
            T[] d = new T[deq.Length + 1];
            for (int i = 1; i < deq.Length + 1; i++)
                d[i] = deq[i - 1];
            d[0] = a;
            deq = d;
        }

        public void Remove()
        {
            //if (deq.Length != 0){

                T[] d = new T[deq.Length - 1];
                for (int i = 0; i < d.Length; i++)
                    d[i] = deq[i + 1];
                deq = d;
            //}

        }

        public void RemoveLast()
        {
            //if (deq.Length != 0){

                T[] d = new T[deq.Length - 1];
                for (int i = 0; i < deq.Length - 1; i++)
                    d[i] = deq[i];
                deq = d;
            //}

        }

        public string Write()
        {
            if (IsEmpety())
            {
                return "Дек пуст";
            }
            else
            {
                string s = "Элементы дека: ";
                foreach (T t in deq)
                {
                    s += t + " ";
                }
                return s;
            }

        }
        public IEnumerator<T> GetEnumerator()
        {
            int i = 0;

            while (i < deq.Length)
            {
                yield return deq[i];
                i++;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
