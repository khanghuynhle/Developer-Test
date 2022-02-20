using BasketHandler.Models;
using BasketHandler.Property;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BasketHandler
{
	public class UpdateBasket : IUpdateBasket
	{
		private readonly ItemsInBasket _itemsInBasket;
		private readonly DiscountCode _discountCode;

		public UpdateBasket(ItemsInBasket itemsInBasket, DiscountCode discountCode)
		{
			_itemsInBasket = itemsInBasket;
			_discountCode = discountCode;
		}
		public List<int> AddItem(int itemNumber)
		{
			//initiate new local list
			var listItemIndex = new List<int>();

			//Check if the number entered is in range of the items
			while (itemNumber < 0 || itemNumber > _itemsInBasket.Items.Count())
			{
				Console.WriteLine("Please enter a valid number for the item");
				AddItem(Convert.ToInt32(Console.ReadLine()));
			}
			listItemIndex.Add(itemNumber);
			_itemsInBasket.ItemIndexes = listItemIndex;

			//Check if user want to add more items
			Console.WriteLine("Would you like to add more item? (Y or N)");
			if (Console.ReadLine().ToUpper().StartsWith("Y"))
			{
				AddItem(Convert.ToInt32(Console.ReadLine()));
			}
			else if (Console.ReadLine().ToUpper().StartsWith("N"))
			{
				return _itemsInBasket.ItemIndexes;
			}
			else
			{
				Console.WriteLine("Please type in (Y)es or (N)o only");
			}

			return _itemsInBasket.ItemIndexes;
		}

		public void AddDiscountCode(int discountCode)
		{
			bool found = _discountCode.DiscountCodes.Any(x => x.Equals(discountCode));
			if (found)
				_discountCode.UserDiscoundCode = _discountCode.DiscountCodes.Where(x => x.Equals(discountCode)).First();
			else
				Console.WriteLine("Discount code is not found, please try again.");
		}

	}
}
