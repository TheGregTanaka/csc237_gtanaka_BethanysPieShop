using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csc237_gtanaka_Bethanys.Models
{
	public class OrderRepository : IOrderRepository
	{
		private readonly AppDbContext _appDbContext;
		private readonly ShoppingCart _shoppingCart;

		public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
		{
			_appDbContext = appDbContext;
			_shoppingCart = shoppingCart;
		}
		public void CreateOrder(Order order)
		{
			order.OrderPlaced = DateTime.Now;

			_appDbContext.Orders.Add(order);

			var shoppingCartItems = _shoppingCart.ShoppingCartItems;

			foreach (var item in shoppingCartItems)
			{
				var orderDetail = new OrderDetail()
				{
					Amount = item.Amount,
					PieID = item.Pie.PieID,
					Price = item.Pie.Price
				};

				_appDbContext.OrderDetails.Add(orderDetail);
			}

			_appDbContext.SaveChanges();
		}
	}
}
