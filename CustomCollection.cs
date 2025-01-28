using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace AQICsharp
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class CustomCollection<T> : IEnumerable<T>
    {
        private List<T> items;

        public CustomCollection()
        {
            items = new List<T>();
        }

        public void Add(T item)
        {
            items.Add(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < items.Count; i += 2)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public static implicit operator CustomCollection<T>(CustomCollection2<T> v)
        {
            throw new NotImplementedException();
        }
    }

    class MainClass
    {
        //static void Main()
        //{
        //    var collection = new CustomCollection<int>();
        //    collection.Add(1);
        //    collection.Add(2);
        //    collection.Add(3);
        //    collection.Add(4);
        //    collection.Add(5);
        //    collection.Add(6);

        //    // Iterate through the collection
        //    foreach (var item in collection)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
    }


}
