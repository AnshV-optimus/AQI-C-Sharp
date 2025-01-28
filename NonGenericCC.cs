using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQICsharp
{
    public class NonGenericCC : IEnumerable
    {
        internal List<int> items; // Change access modifier to internal
        public NonGenericCC()
        {
            items = new List<int>();
        }
        public void Add(int value)
        {
            items.Add(value);
        }

        public IEnumerator GetEnumerator()
        {
            return new CustomEnumerator(this); // passing the reference of the collection to the enumerator
        }
    }
    public class CustomEnumerator : IEnumerator
    {
        private readonly NonGenericCC collection;
        private int currentIndex = -2;
        public CustomEnumerator(NonGenericCC collection)
        {
            this.collection = collection;
        }

        public object Current
        {
            get
            {
                if (currentIndex < 0 || currentIndex >= collection.items.Count)
                {
                    throw new InvalidOperationException();
                }
                return collection.items[currentIndex];
            }
        }

        public bool MoveNext()
        {
            if (currentIndex < collection.items.Count - 2)
            {
                currentIndex += 2;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            currentIndex = -2;
        }
    }
}
