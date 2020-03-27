using csc237_gtanaka_Bethanys.Models;
using csc237_gtanaka_Bethanys.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csc237_gtanaka_Bethanys.Components
{
	public class ShoppingCartSummary : ViewComponent
	{
		public readonly ShoppingCart _shoppingCart;

		public ShoppingCartSummary(ShoppingCart shoppingCart)
		{
			_shoppingCart = shoppingCart;
		}

		public IViewComponentResult Invoke()
		{
			var items = _shoppingCart.GetShoppingCartItems();
			_shoppingCart.ShoppingCartItems = items;

			var shoppingCartViewModel = new ShoppingCartViewModel
			{
				ShoppingCart = _shoppingCart,
				ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
			};
			return View(shoppingCartViewModel);
		}
	}
}
