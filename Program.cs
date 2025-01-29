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

            // DELEGATE EXAMPLE

            Delegates Obj = new Delegates();

            Callback del = Delegates.StaticDelegateMethod;
            del += Obj.InstanceDelegateMethod;

            del(10);

            // Anonymous method
            Callback del2 = delegate (int value)
            {
                Console.WriteLine("Anonymous method: " + value * value);
            };

            // Lambda expression

            CallbackReturn callbackReturn = x => x * x;
            Console.WriteLine("Lambda expression: " + callbackReturn(10));

            del2 += x => Console.WriteLine("Lambda expression2: " + x * x * x);

            del2(10);

            // Action delegate

            Action actionDel = Delegates.print;
            actionDel();

            Action<int , string> returnActionDel = Obj.ForActionDelegate;
            returnActionDel(1 , "Ansh");

            //parameterized delegate    
            MathOperation mathOpDel = Obj.Add;

            UsingDelegate.PrintResult(mathOpDel, 10, 20);

            Func<int, int ,int> funcDel = (a , b) => a + b;

            Console.WriteLine("Func delegate: " + funcDel(10, 20));

            Predicate<int> predicateDel = Obj.IsEven;
            Console.WriteLine(predicateDel(5));
            Console.WriteLine(predicateDel(6));

            //LAMBDA EXPRESSION CLASS

            var lambda = new LambdaExpression();    
            Console.WriteLine( lambda.Add(10, 20));

            var usingLambda = new UsingLambda();
            UsingLambda.PrintResult(lambda.Add, 10, 200);
        }
    }
}
