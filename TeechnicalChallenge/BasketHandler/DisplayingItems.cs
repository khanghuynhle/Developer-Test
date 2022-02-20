using BasketHandler.Models;
using BasketHandler.Property;
using System;
using System.Collections.Generic;

namespace BasketHandler
{
	public class DisplayingItems : IDisplayingItems
	{
		private readonly IDefineItems _defineItems;
		private readonly ItemsInBasket _itemsInBasket;

		public DisplayingItems (IDefineItems defineItems, ItemsInBasket itemsInBasket)
		{
			_defineItems = defineItems;
			_itemsInBasket = itemsInBasket ?? throw new NotImplementedException();
		}
		public void DisplayItems()
		{
			int i = 1;
			foreach (Item item in _defineItems.DefineItemForUser())
			{
				Console.WriteLine("{0}, Item Name: {1}, Price: {2}", i, item.ItemName, item.ItemPrice);
				//Console.WriteLine(i, ", Item Name: ", item.ItemName, "Item Price: ", item.ItemPrice);
				i++;
			}
		}
	}
}
