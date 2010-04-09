using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FluentValidation.MvcSample.Controllers {
	using Models;

	[HandleError]
	public class HomeController : Controller {
		public ActionResult Step1() {
			ViewData["Message"] = "Welcome to ASP.NET MVC!";

			return View();
		}

		[AcceptVerbs(HttpVerbs.Post)]
		public ActionResult Step1(Step1 step1) {
			if (!ModelState.IsValid) {
				return View();
			}
			return Redirect("/Home/Step2");
		}
	}
}
