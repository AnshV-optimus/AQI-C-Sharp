using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQICsharp
{
    public class CustomCollection2<T> : IEnumerable<T>
    {
        private List<T> items;
        public CustomCollection2()
        {
            items = new List<T>();
        }
        public void add(T value)
        {
            items.Add(value);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new CustomEnumerator(this); // passing the reference of the collection to the enumerator
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class CustomEnumerator : IEnumerator<T>
        {
            private readonly CustomCollection2<T> collection;
            private int currentIndex = -2;
            public CustomEnumerator(CustomCollection2<T> collection)
            {
                this.collection = collection;
            }
            public T Current => collection.items[currentIndex];
            object IEnumerator.Current => Current;
            public bool MoveNext()
            {
                currentIndex += 2;
                if (currentIndex < collection.items.Count)
                {
                    return true;
                }
                Reset();
                return false;
            }
            public void Reset()
            {
                currentIndex = -2;
            }

            public void Dispose() { }
        }
    }
}
