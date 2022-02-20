using BasketHandler.Property;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasketHandler.Models
{
	public interface IDefineItems
	{
		List<Item> DefineItemForUser();
	}
}
