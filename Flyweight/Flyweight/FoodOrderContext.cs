using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class FoodOrderContext
    {
		public int table
		{
			get;
			private set;
		}

		public FoodOrderContext(int tableNumber)
		{
			this.table = tableNumber;
		}
	}
}
