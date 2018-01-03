using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EcommerceStore.Classes
{
    public class Inventory<T> : IEnumerable<T>
    {
        public T[] Items = new T[2];
        public int Count = 0;

        public void Add(T item)
        {
            if (Count == (Items.Length / 2))
            {
                T[] newArray = new T[Items.Length * 2];

                for (int i = 0; i < Items.Length; i++)
                {
                    newArray[i] = Items[i];
                }

                Items = newArray;
            }
            Items[Count] = item;
            Count++;
        }

        public void Remove(T item)
        {
            T[] newArray = new T[Items.Length];
            if (Count - 1 <= Items.Length / 2)
            {
                newArray = new T[Items.Length / 2];
            }

            int j = 0;
            int tempCount = Count;
            for (int i = 0; i < tempCount; i++)
            {
                if (j >= tempCount) break;
                if (!item.Equals(Items[j]))
                {
                    newArray[i] = Items[j];
                    j++;
                }
                else
                {
                    Count--;
                    i--;
                    j++;
                }
            }
            Items = newArray;
        }

        public int AtIndexOf(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (Items[i].Equals(item))
                {
                    return i;
                }
            }
            throw new InvalidOperationException();
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
