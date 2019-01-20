using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Matt_Kwiecien_MVC.Models;

namespace Matt_Kwiecien_MVC.Controllers {
	public class HomeController : Controller {
		public IActionResult Index() {
			return View();
		}

		public IActionResult About() {
			ViewData["Message"] = "All about me.";

			return View();
		}

        public IActionResult Projects() {
            ViewData["Message"] = "Current projects.";

            return View();
        }

        public IActionResult Contact() {
			ViewData["Message"] = "Contact me.";

			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error() {
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
