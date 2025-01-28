using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQICsharp
{
    public class Program
    {
        public static void Main()
        {
            var collection = new CustomCollection2<int>();
            collection.add(1);
            collection.add(2);
            collection.add(3);
            collection.add(4);
            collection.add(5);
            collection.add(6);


            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            
            var nonGenericCollection = new NonGenericCC();
            nonGenericCollection.Add(1);
            nonGenericCollection.Add(2);
            nonGenericCollection.Add(3);
            nonGenericCollection.Add(4);
            
            foreach(var item in nonGenericCollection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
