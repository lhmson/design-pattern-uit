using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern
{
    public interface IMoveStrategy
    {
        object TravelByMoney();
    }
}
