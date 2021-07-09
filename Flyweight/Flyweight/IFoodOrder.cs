using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    interface IFoodOrder
    {
        void Serve(FoodOrderContext context);
    }
}
