using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            int res;

            res = calculator.Add(5);
            Console.WriteLine("result is "+ res);

            res = calculator.Sub(2);
            Console.WriteLine("result is " + res);

            res = calculator.Div(2);
            Console.WriteLine("result is " + res);

            res = calculator.Mul(12);
            Console.WriteLine("result is " + res);

            Console.ReadLine();
        }
    }
}
