using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EcommerceCarStore
{
    class Garage<T> : IEnumerable<T>
    {
        T[] _cars = new T[10];
        private int _count = 0;

        public void Add(T car)
        {
            if (_count == (_cars.Length / 2))
            {
                T[] newArray = new T[_cars.Length * 2];

                for (int i = 0; i < _cars.Length; i++)
                {
                    newArray[i] = _cars[i];
                }

                _cars[_count] = car;
                _count++;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _count; i++)
            {
                yield return _cars[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
