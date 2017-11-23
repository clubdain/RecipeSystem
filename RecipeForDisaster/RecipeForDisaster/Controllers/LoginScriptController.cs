using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RecipeForDisaster.Controllers
{
    public class LoginScriptController : Controller
    {
        // GET: LoginScript
        public ActionResult LoginScript(string usernameLogIn, string passwordLogIn)
        {
            //Mongo db = new Mongo();

            //if (db.VerifyLogin(usernameLogIn, passwordLogIn))
            //{
            //    Session["user"] = db.GetUserByUsername(usernameLogIn);
            //    Session["loggedIn"] = true;
            //}
            //else
            //{
            //    Session["loggedIn"] = false;
            //    return RedirectToAction("LoginPage", "Account");
            //}

            //return RedirectToAction((string)Session["currentMethod"], (string)Session["currentController"]);
            return View();
        }
    }
}