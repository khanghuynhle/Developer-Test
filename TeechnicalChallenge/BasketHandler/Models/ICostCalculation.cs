using System;
using System.Collections.Generic;
using System.Text;

namespace BasketHandler.Models
{
	public interface ICostCalculation
	{
		void CalculateAfterDiscountCode();
		int CalculateTotalCost();
	}
}
