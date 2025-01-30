using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQICsharp
{
    public class CustomException: Exception
    {
        public CustomException() : base("Custom Exception Occurred") { }

        public CustomException(string message) : base(message) { }
        public CustomException(string message, Exception InnerException): base(message , InnerException) { }
    }

    public class CustomExceptionExample
    {
        public void Operation(int a, int b)
        {
            try
            {
                var result = CustomOperation.PerformCalculation(a, b);
                Console.WriteLine(result);
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
                if (ex.InnerException != null)
                    Console.WriteLine(ex.InnerException.Message);

            }
            catch (Exception ex)
            {
                Console.WriteLine("General Exception" + ex.Message);
            }
        }
    }

    public class CustomOperation
    {
        public static int PerformCalculation(int a, int b)
        {
            try
            {
                if (a == 0 || b == 0)
                {
                    throw new CustomException("Numbers cannot be zero");
                }
                return a / b;
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
                throw new CustomException("Custom Exception Occurred", ex);
            }
        }
    }
}
