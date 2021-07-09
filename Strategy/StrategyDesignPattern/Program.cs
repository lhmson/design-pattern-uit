using System;

namespace StrategyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Transport();

            Console.WriteLine("Client: I have lots of money");
            context.SetStrategy(new FlyStrategy());
            context.DoSomeBusinessLogic();

            Console.WriteLine();

            Console.WriteLine("Client: I have a bit money");
            context.SetStrategy(new WalkStrategy());
            context.DoSomeBusinessLogic();
        }
    }
}
