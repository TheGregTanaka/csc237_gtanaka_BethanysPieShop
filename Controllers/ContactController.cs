using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csc237_gtanaka_Bethanys.Controllers
{
	public class ContactController : Controller
	{
		// GET: /<controller>/
		public IActionResult Index()
		{
			return View();
		}
	}
}
