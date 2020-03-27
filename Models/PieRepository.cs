using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csc237_gtanaka_Bethanys.Models
{
	public class PieRepository: IPieRepository
	{
		private readonly AppDbContext _appDbContext;

		public PieRepository(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
		}

		public IEnumerable<Pie> AllPies
		{
			get
			{
				return _appDbContext.Pies.Include(c => c.Category);
			}
		}

		public IEnumerable<Pie> PiesOfTheWeek
		{
			get
			{
				return _appDbContext.Pies.Include(c => c.Category).Where(p => p.IsPieOfTheWeek);
			}
		}

		public Pie GetPieByID(int pieID)
		{
			return _appDbContext.Pies.FirstOrDefault(p => p.PieID == pieID);
		}
	}
}
