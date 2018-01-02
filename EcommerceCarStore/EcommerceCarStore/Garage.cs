using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EcommerceCarStore
{
    class Garage<T> : IEnumerable<T>
    {
        T[] items = new T[10];
        int count = 0;

        public void AddCustomed(T item)
        {
            if (count == (items.Length / 2))
            {
                T[] newArray = new T[items.Length * 2];

                for (int i = 0; i < items.Length; i++)
                {
                    newArray[i] = items[i];
                }

                items = newArray;

            }
            items[count] = item;


            count++;
        }

        public void RemoveCustomed(T car)
        {
            T[] newArray = new T[items.Length];

            int j = 0;
            for (int i = 0; i < items.Length; i++)
            {
                if (!items[i].Equals(car))
                {
                    newArray[i] = items[j];
                    j++;
                }
                else
                {
                    j++;
                }
            }

            items = newArray;
        }

        public int AtIndexOf(T car)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(car))
                {
                    return i;
                }
            }
            return -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
