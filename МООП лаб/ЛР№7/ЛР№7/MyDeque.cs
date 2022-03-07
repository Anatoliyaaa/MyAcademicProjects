using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;using System.IO;

namespace ЛР_7
{
    [Serializable]
    public class MyDeque<T> : IMyDeque<T>
    {
        T[] deq;
        public int deqNum { get; private set; }

        public static int count;

        public T this[int index]
        {
            get => deq[index];
            set => deq[index] = value;
        }
        public MyDeque()
        {
            deq = new T[0];
            this.deqNum = Interlocked.Increment(ref count);
        }
        public MyDeque(int n)
        {
            deq = new T[n];
            this.deqNum = Interlocked.Increment(ref count);
        }
        public int Lenght()
        {
            return deq.Length;
        }
        public void Clear()
        {
            Array.Clear(deq, 0, deq.Length);
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

        public void RemoveFirst()
        {
            T[] d = new T[deq.Length - 1];
            for (int i = 0; i < d.Length; i++)
                d[i] = deq[i + 1];
            deq = d;
        }

        public void RemoveLast()
        {
            T[] d = new T[deq.Length - 1];
            for (int i = 0; i < deq.Length - 1; i++)
                d[i] = deq[i];
            deq = d;
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
            // Go to last pused element

            while (i < deq.Length)
            {
                yield return deq[i];
                i++;
            }
        }
        // We must implement this method because
        // IEnumerable<T> inherits IEnumerable
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerable<T> Backwards() // в обратном порядке
        {
            int i = deq.Length;
            // Go to last pused element
            i--;
            while (i >= 0)
            {
                yield return deq[i];
                i--;
            }
        }        public object DeepClone()
        {
            MyDeque<T> deqc = new MyDeque<T>(deq.Length);
            for (int i = 0; i < deq.Length; i++)
                deqc[i] = deq[i];
            return deqc;

        }        public MyDeque<T> ShallowClone()
        {
            return (MyDeque<T>)this.MemberwiseClone();
        }        public object Clone()
        {
            return DeepClone();
        }

        public static IEnumerable<string> GetDeqWithCondition(IEnumerable<MyDeque<int>> deques)
        {
            var result = new List<string>();
            foreach (MyDeque<int> deque in deques)
            {
                //
                int min = deque[0];
                foreach (int deq in deque)
                {
                    if (deq < min)
                        min = deq;
                }
                if (min <= 0)
                {
                    result.Add(Convert.ToString(deque.deqNum));
                }
            }
            return result;
        }        static public IEnumerable<string> GetDeqWithConditionPipeLine(IEnumerable<MyDeque<int>> deques)
        {

            var result = new List<string>();

            //IEnumerable< MyDeque<int>> query = deques.Where(deque => deque.Min() <= 0);
            //foreach (int deqn in query)
            //{
            //    result.Add(Convert.ToString(deqn));
            //}

            foreach (MyDeque<int> deque in deques)
            {
                if (deque.Any(deq => deq <= 0))
                {
                    //int minvalue = deque.Min();
                    result.Add(Convert.ToString(deque.deqNum));
                }
                //int minvalue = deque.Where(deq => deq<= 0).Min();
                //if (minvalue <= 0)


            }

            return result;
        }

        //сериализация в бинарном формате
        public static void SaveDequeInBinaryFormat(MyDeque<T> deq)
        {
            FileStream fs = new FileStream("C:/Users/MSI GF63/Desktop/мусор (нет)/универ/Лабы/4 семестр/МООП/ЛР№7/BinarySerialize.dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();

            try
            {
                bf.Serialize(fs, deq);
            }
            catch (SerializationException e)
            {
                throw;
            }
            finally
            {

                fs.Close();
            }
        }
        //десериализация из бинарного формата
        public static MyDeque<T> OpenDequeFromBinaryFormat()
        {
            MyDeque<T> deq = null;
            FileStream fs = new FileStream("C:/Users/MSI GF63/Desktop/мусор (нет)/универ/Лабы/4 семестр/МООП/ЛР№7BinarySerialize.dat", FileMode.Open);
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                deq = (MyDeque<T>)bf.Deserialize(fs);
            }
            catch (SerializationException e)
            {
                throw;
            }
            finally
            {
                fs.Close();
            }
            return deq;
        }


    }
}
