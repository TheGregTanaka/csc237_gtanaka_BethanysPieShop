using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using csc237_gtanaka_Bethanys.Models;

namespace csc237_gtanaka_Bethanys.ViewModels
{
    public class PiesListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }
        public string CurrentCategory { get; set; }
    }
}

