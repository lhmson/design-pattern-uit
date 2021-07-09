using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class FoodItemFactory
    {
		private readonly IDictionary<string, FoodItem> _items = new Dictionary<string, FoodItem>();

		public FoodItem GetFoodItem(string itemName)
		{
			FoodItem item;
			if (this._items.TryGetValue(itemName, out item))
			{
				return item;
			}
			item = new FoodItem(itemName);
			this._items.Add(itemName, item);
			return item;
		}

		public int TotalItemsMade
		{
			get
			{
				return this._items.Count;
			}
		}
	}
}
