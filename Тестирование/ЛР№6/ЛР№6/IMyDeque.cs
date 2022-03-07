using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_6
{
    interface IMyDeque<T> : IEnumerable<T>
    {
        void Add(T item); //добавить элемент в конец

        void AddFirst(T item); //добавить элемент в начало

        void Remove(); // удалить элемент из начала

        void RemoveLast(); // удалить элемент из конца

        void Clear(); // очистить элементы дека 
        void RemoveAll(); // удалить все элементы дека

        bool IsEmpety(); // проверка на наличие элементов в деке

        string Write(); // вывод дека
    }
}
