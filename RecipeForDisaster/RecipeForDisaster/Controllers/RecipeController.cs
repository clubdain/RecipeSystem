using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RecipeForDisaster.Controllers
{
    public class RecipeController : Controller
    {
        public ActionResult Appetizers()
        {
            return View();
        }
        public ActionResult Desserts()
        {
            return View();
        }
        public ActionResult MainDishes()
        {
            return View();
        }

        public ActionResult CreateARecipe()
        {
            return View();
        }

    }
}