using csc237_gtanaka_Bethanys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csc237_gtanaka_Bethanys.ViewModels
{
	public class ShoppingCartViewModel
	{
		public ShoppingCart ShoppingCart { get; set; }
		public decimal ShoppingCartTotal { get; set; }
	}
}
