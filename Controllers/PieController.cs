using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using csc237_gtanaka_Bethanys.Models;
using csc237_gtanaka_Bethanys.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace csc237_gtanaka_Bethanys.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            PiesListViewModel piesListViewModel = new PiesListViewModel();
            piesListViewModel.Pies = _pieRepository.AllPies;

            piesListViewModel.CurrentCategory = "Cheese cakes";
            return View(piesListViewModel);
        }
    }
}