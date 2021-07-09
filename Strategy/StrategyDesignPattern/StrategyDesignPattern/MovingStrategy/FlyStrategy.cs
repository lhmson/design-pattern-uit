using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern
{
    public class FlyStrategy : IMoveStrategy
    {
        public object TravelByMoney()
        {
            return "I travel by plane and it's fast";
        }
    }
}
