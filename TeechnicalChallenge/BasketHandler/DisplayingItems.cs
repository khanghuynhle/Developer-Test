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
			int i = 0;
			foreach (Item item in _defineItems.DefineItemForUser())
			{
				Console.WriteLine("{itemOrder} {items}", i, _itemsInBasket.Items);
				i++;
			}
		}
	}
}
