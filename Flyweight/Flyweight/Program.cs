using System;

namespace Flyweight
{
    class Program
    {
       

			private static readonly FoodItem[] items = new FoodItem[100];
		private static readonly FoodOrderContext[] tables = new FoodOrderContext[100];

		private static int _ordersMade;
		private static FoodItemFactory _factory;

		private static void TakeOrder(string flaver, int table)
		{
			items[_ordersMade] = _factory.GetFoodItem(flaver);
			tables[_ordersMade++] = new FoodOrderContext(table);
		}

		static void Main(string[] args)
		{
			_factory = new FoodItemFactory();

			TakeOrder("Cocacola", 2);
			TakeOrder("Cocacola", 2);
			TakeOrder("Sting", 1);
			TakeOrder("Sting", 1);
			TakeOrder("Pepsi", 1);
			TakeOrder("Sting", 897);
			TakeOrder("Cocacola", 97);
			TakeOrder("Cocacola", 97);
			TakeOrder("Sting", 3);
			TakeOrder("Pepsi", 3);
			TakeOrder("Cocacola", 3);
			TakeOrder("Pepsi", 96);
			TakeOrder("Sting", 552);
			TakeOrder("Cocacola", 121);
			TakeOrder("Pepsi", 121);

			for (int i = 0; i < _ordersMade; i++)
			{
				items[i].Serve(tables[i]);
			}

			Console.WriteLine();
			Console.WriteLine("Total food item objects made {0}", _factory.TotalItemsMade);
			Console.ReadKey();
		}
    }
}
