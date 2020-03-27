using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using csc237_gtanaka_Bethanys.Models;
using csc237_gtanaka_Bethanys.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace csc237_gtanaka_Bethanys.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PiesOfTheWeek = _pieRepository.PiesOfTheWeek
            };

            return View(homeViewModel);
        }
    }
}
