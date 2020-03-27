using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using csc237_gtanaka_Bethanys.Models;
using csc237_gtanaka_Bethanys.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace csc237_gtanaka_Bethanys.Controllers
{
	public class ShoppingCartController : Controller
	{
		private readonly IPieRepository _pieRepository;
		private readonly ShoppingCart _shoppingCart;

		public ShoppingCartController(IPieRepository pieRepository, ShoppingCart shoppingCart)
		{
			_pieRepository = pieRepository;
			_shoppingCart = shoppingCart;
		}

        public ViewResult Index()
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

        public RedirectToActionResult AddToShoppingCart(int pieID)
        {
            var selectedPie = _pieRepository.AllPies.FirstOrDefault(p => p.PieID == pieID);

            if (selectedPie != null)
            {
                _shoppingCart.AddToCart(selectedPie, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int pieID)
        {
            var selectedPie = _pieRepository.AllPies.FirstOrDefault(p => p.PieID == pieID);

            if (selectedPie != null)
            {
                _shoppingCart.RemoveFromCart(selectedPie);
            }
            return RedirectToAction("Index");
        }
    }
}
