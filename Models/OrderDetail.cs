namespace csc237_gtanaka_Bethanys.Models
{
	public class OrderDetail
	{
		public int OrderDetailID { get; set; }
		public int OrderID { get; set; }
		public int PieID { get; set; }
		public int Amount { get; set; }
		public decimal Price { get; set; }
		public Pie Pie { get; set; }
		public Order Order { get; set; }
	}
}