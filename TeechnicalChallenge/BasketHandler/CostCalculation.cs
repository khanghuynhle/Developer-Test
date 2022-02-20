using BasketHandler.Models;
using BasketHandler.Property;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasketHandler
{
	public class CostCalculation : ICostCalculation
	{
		private readonly DiscountCode _discountCode;
		private readonly ItemsInBasket _itemsInBasket;

		public CostCalculation(DiscountCode discountCode, ItemsInBasket itemsInBasket)
		{
			_discountCode = discountCode;
			_itemsInBasket = itemsInBasket;
		}
		public void CalculateAfterDiscountCode()
		{
			if (!_discountCode.DiscountCodes.Contains(_discountCode.UserDiscoundCode))
			{
				Console.WriteLine("Sorry your code is not valid, please try again.");
			}
			else
			{
				var costBeforeDiscount = CalculateTotalCost();
				Console.WriteLine("Your total before discount is: ", costBeforeDiscount);
				int costAfterDiscount = costBeforeDiscount / _discountCode.UserDiscoundCode;
				Console.WriteLine("Your total after discount is: ", costAfterDiscount);
			}
		}

		public int CalculateTotalCost()
		{
			int cost = 0;
			foreach(int itemIndex in _itemsInBasket.ItemIndexes)
			{
				cost = cost + _itemsInBasket.Items.Select(a => a.ItemPrice).ElementAt(itemIndex);
			}
			Console.WriteLine("Your total is: {0}", cost);
			return cost;
		}
	}
}
