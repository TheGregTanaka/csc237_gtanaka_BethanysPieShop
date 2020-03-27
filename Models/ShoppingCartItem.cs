using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csc237_gtanaka_Bethanys.Models
{
	public class ShoppingCartItem
	{
		public int ShoppingCartItemID { get; set; }
		public Pie Pie { get; set; }
		public int Amount { get; set; }
		public string ShoppingCartID { get; set; }
	}
}
