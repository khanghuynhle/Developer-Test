﻿using BasketHandler.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasketHandler
{
	public class DisplayingCostHandler : IDisplayingCostHandler
	{
		private readonly ICostCalculation _costCalculation;
		public DisplayingCostHandler(ICostCalculation costCalculation)
		{
			_costCalculation = costCalculation;
		}
		public void DisplayCostHandler()
		{
			Console.WriteLine("Would you like to add a discount code? (Y or N)");
			if (Console.ReadLine().StartsWith("Y"))
			{
				_costCalculation.CalculateAfterDiscountCode();
			}
			else if (Console.ReadLine().StartsWith("N"))
			{
				_costCalculation.CalculateTotalCost();
			}
			else
			{
				Console.WriteLine("Please type in (Y)es or (N)o only");
			}
		}
	}
}
