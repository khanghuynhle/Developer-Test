using System.Collections.Generic;

namespace BasketHandler.Models
{
	public interface IUpdateBasket
	{
		List<int> AddItem(int itemNumber);
		void AddDiscountCode(int discountCode);

	}
}
