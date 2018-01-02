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

        public void Add(T item)
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
            if (count == items.Length / 2)
            {
                T[] newArray = new T[items.Length / 2];

                for (int i = 0; i < items.Length; i++)
                {
                    newArray[i] = items[i];
                }

                //Cars[Count] = T;
            }
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
