using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQICsharp
{
    public delegate void Callback(int value);
    public delegate int CallbackReturn(int value);
    public delegate void MathOperation(int a , int b);  

    public class Delegates
    {
        public static void print()
        {
            Console.WriteLine("Print method called with Action Delegate!");
        }
        public static void StaticDelegateMethod(int value)
        {
            Console.WriteLine("Static delegate method: " + value);
        }
        public void InstanceDelegateMethod(int value)
        {
            Console.WriteLine("Instance delegate method: " + value);
        }

        public void ForActionDelegate(int id , string name)
        {
           Console.WriteLine("Id: " + id + " Name: " + name);
        }

        //DELGATE AS PARAMETER
        public void Add(int a , int b) => Console.WriteLine("Addition: " + (a + b));

        public bool IsEven(int number)
        {
            if (number % 2 != 0)
                return false;
            return true;
        }

        
    }
    public class UsingDelegate
    {
        public static void PrintResult(MathOperation del, int a, int b)
        {
            del(a, b);
        }

    }
}
