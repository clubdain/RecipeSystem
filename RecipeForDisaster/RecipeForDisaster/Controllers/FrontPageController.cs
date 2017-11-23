using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RecipeForDisaster.Controllers
{
    public class FrontPageController : Controller
    {
        public ActionResult FrontPage()
        {
            return View();
        }
    }
}