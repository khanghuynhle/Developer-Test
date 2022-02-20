using BasketHandler.Models;
using BasketHandler.Property;
using System;

namespace BasketHandler
{
	public class Initialiser : IInitialiser
	{
		private readonly IUpdateBasket _updateBasket;
		private readonly IDisplayingItems _displayingItems;
		private readonly IDisplayingCostHandler _displayDiscountHandler;

		public Initialiser(IUpdateBasket updateBasket, IDisplayingItems displayingItems, IDisplayingCostHandler displayingDiscountHandler)
		{
			_updateBasket = updateBasket;
			_displayingItems = displayingItems;
			_displayDiscountHandler = displayingDiscountHandler;
		}

		//The main logic of this application:
		public void InitiliseBasketHandler()
		{
			//This is to display items for user to choose
			_displayingItems.DisplayItems();

			Console.Write("Please choose a product from the above list by entering the number of that item: ");

			_updateBasket.AddItem(Convert.ToInt32(Console.ReadLine()));

			//Letting user add a discount code if they'd like to
			_displayDiscountHandler.DisplayCostHandler();
		}
	}
}
