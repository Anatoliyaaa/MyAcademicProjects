using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_7
{
    interface IMyDeque<T> : IEnumerable<T>, ICloneable
    {
        void Add(T item); //добавить элемент в конец

        void AddFirst(T item); //добавить элемент в начало

        void RemoveFirst(); // удалить элемент из начала

        void RemoveLast(); // удалить элемент из конца

        void Clear(); // очистить дек

        bool IsEmpety(); // проверка на наличие элементов в деке

        string Write(); // вывод дека
    }
}
