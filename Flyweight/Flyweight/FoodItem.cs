using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class FoodItem : IFoodOrder
    {
		public string item
		{
			get;
			private set;
		}

		public FoodItem(string newItem)
		{
			this.item = newItem;
		}

		public void Serve(FoodOrderContext context)
		{
			Console.WriteLine("Serving item {0} to table {1} .", this.item, context.table);
		}
	}
}
