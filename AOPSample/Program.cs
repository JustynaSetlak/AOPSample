using System;
using Castle.Core.Logging;
using Castle.DynamicProxy;

namespace AOPSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var proxyGenerator = new ProxyGenerator();

            var calculator = proxyGenerator.CreateClassProxy<Calculator>(
                new MyInterceptorAspect(new ConsoleLogger()));

            var sum = calculator.AddNumbers(5, 8);
            Console.WriteLine($"Value of method execution: {sum}");

            Console.ReadKey();
        }
    }
}
