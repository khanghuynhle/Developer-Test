using BasketHandler.Models;
using BasketHandler.Property;
using System;
using System.Collections.Generic;

namespace BasketHandler
{
	public class DefineItems : IDefineItems
	{
		private readonly ItemsInBasket _itemsInBasket;
		public DefineItems (ItemsInBasket itemsInBasket)
		{
			_itemsInBasket = itemsInBasket;
		}
		public List<Item> DefineItemForUser()
		{
			List<Item> itemsInStock = _itemsInBasket.Items;
			itemsInStock.Add(new Item() { ItemName = "Iphone 13 pro", ItemPrice = 1000});
			itemsInStock.Add(new Item() { ItemName = "Iphone 13", ItemPrice = 900 });
			itemsInStock.Add(new Item() { ItemName = "Iphone 13 Pro Max", ItemPrice = 1300});
			itemsInStock.Add(new Item() { ItemName = "Macbook", ItemPrice = 2000});
			itemsInStock.Add(new Item() { ItemName = "Phone Charger", ItemPrice = 30});
			itemsInStock.Add(new Item() { ItemName = "Macbook Charger", ItemPrice = 100});
			itemsInStock.Add(new Item() { ItemName = "Airpod 3", ItemPrice = 150});
			itemsInStock.Add(new Item() { ItemName = "Airpod Pro", ItemPrice = 250});
			itemsInStock.Add(new Item() { ItemName = "Apple Watch 5", ItemPrice = 300});
			itemsInStock.Add(new Item() { ItemName = "Apple Watch 6", ItemPrice = 400});

			return itemsInStock;
		}
	}
}
