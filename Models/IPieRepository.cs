using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csc237_gtanaka_Bethanys.Models
{
	public interface IPieRepository
	{
		IEnumerable<Pie> AllPies { get;  }
		IEnumerable<Pie> PiesOfTheWeek { get;  }
		Pie GetPieByID(int pieID);
	}
}
