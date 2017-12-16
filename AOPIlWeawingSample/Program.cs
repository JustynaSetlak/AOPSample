using System;

namespace AOPIlWeawingSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            var sum = calculator.AddNumbers(5, 8);
            Console.WriteLine(sum);
            Console.ReadKey();  
        }
    }
}
