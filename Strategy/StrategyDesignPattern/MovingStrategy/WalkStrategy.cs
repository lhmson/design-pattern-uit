using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern
{
    class WalkStrategy : IMoveStrategy
    {
        public object TravelByMoney()
        {
            return "I walk and it's slow";
        }
    }
}
