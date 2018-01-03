using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EcommerceStore.Classes
{
    class Inventory<T>:IEnumerable<T>
    {
        private T[] Items;
        private int Count;

        public Inventory(int numberOfItems, int count)
        {
            Items = new T[numberOfItems];
            Count = count;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return Items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
