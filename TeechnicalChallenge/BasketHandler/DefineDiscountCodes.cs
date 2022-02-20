using BasketHandler.Models;
using BasketHandler.Property;
using System.Collections.Generic;

namespace BasketHandler
{
	public class DefineDiscountCodes : IDefineDiscountCodes
	{
		private readonly DiscountCode _discountCode;
		public DefineDiscountCodes(DiscountCode discountCode)
		{
			_discountCode = discountCode;
		}
		public List<int> DiscountCodes()
		{
			_discountCode.DiscountCodes.Add(5);
			_discountCode.DiscountCodes.Add(10);
			_discountCode.DiscountCodes.Add(15);
			_discountCode.DiscountCodes.Add(20);
			_discountCode.DiscountCodes.Add(25);
			_discountCode.DiscountCodes.Add(30);

			return _discountCode.DiscountCodes;
		}
	}
}
