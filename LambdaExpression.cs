using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AQICsharp
{
    public class LambdaExpression
    {
        public Func<int, int, int> Add = (int x, int y) => x + y;

        public Action<int,int> Multiply = (x , y) => Console.WriteLine("Result: " + x * y);
    }
    public class UsingLambda
    {
        public static void PrintResult(Func<int, int, int> del, int a, int b)
        {
            Console.WriteLine("Result: " + del(a, b));
        }

    }
   
}
