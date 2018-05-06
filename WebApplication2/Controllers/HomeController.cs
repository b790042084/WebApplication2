using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
		// GET: /<controller>/
		public IActionResult Index()
		{
			ViewBag.Title ="人员信息输入";
			return View();
		}
		[HttpPost]
		public IActionResult Index(Person p)
		{
			return View("PersonInfo", p);
		}

	}
}
