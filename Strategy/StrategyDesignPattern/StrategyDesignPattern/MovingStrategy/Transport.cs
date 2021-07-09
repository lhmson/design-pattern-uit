using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern
{
    public class Transport
    {
        // The Context maintains a reference to one of the Strategy objects. The
        // Context does not know the concrete class of a strategy. It should
        // work with all strategies via the Strategy interface.
        private IMoveStrategy _strategy;

        public Transport()
        { }

        // Usually, the Context accepts a strategy through the constructor, but
        // also provides a setter to change it at runtime.
        public Transport(IMoveStrategy strategy)
        {
            this._strategy = strategy;
        }

        // Usually, the Context allows replacing a Strategy object at runtime.
        public void SetStrategy(IMoveStrategy strategy)
        {
            this._strategy = strategy;
        }

        // The Context delegates some work to the Strategy object instead of
        // implementing multiple versions of the algorithm on its own.
        public void DoSomeBusinessLogic()
        {
            Console.WriteLine("Context: Pick way of travel (based on money)");
            var res = this._strategy.TravelByMoney();

            Console.WriteLine(res);
        }
    }
}
