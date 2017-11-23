using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RecipeForDisaster.Models;

namespace RecipeForDisaster.Controllers
{
    public class AccountController : Controller
    {
        //public ActionResult ConfirmLogin(string exampleInputEmail1, string exampleInputPassword1)
        //{

        //    //Username not email bad naming
        //    DatabaseEntities db = new DatabaseEntities();();
        //    if (string.IsNullOrWhiteSpace(exampleInputEmail1) || string.IsNullOrWhiteSpace(exampleInputPassword1))
        //    {
        //        return View("Error");
        //    }
        //    try
        //    {
        //        if (db.VerifyLogin(exampleInputEmail1, exampleInputPassword1))
        //        {
        //            Session["loggedIn"] = true;
        //            User u = db.GetUserByUsername(exampleInputEmail1);
        //            Session["user"] = u;

        //            return RedirectToAction("FrontPage", "FrontPage");
        //        }
        //        return View("Error");
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //    }
        //    return View("Error");
        //}

        [HttpPost]
        public ActionResult LogOff()
        {
            Session["loggedIn"] = false;
            Session["user"] = null;
            return RedirectToAction("FrontPage", "FrontPage");
        }

        //public ActionResult SignUp()
        //{
        //    Session["currentMethod"] = "SignUp";
        //    Session["currentController"] = "Account";
        //    return View();
        //}
        //[HttpGet]
        //public ActionResult LoginPage()
        //{
        //    Session["currentMethod"] = "LoginPage";
        //    Session["currentController"] = "Account";
        //    return View();
        //}


        [HttpPost]
        public ActionResult CreateAccount(string usernameSignup, string passwordSignup, string emailSignup)
        {
            DatabaseEntities db = new DatabaseEntities();
            if (string.IsNullOrWhiteSpace(usernameSignup) || string.IsNullOrWhiteSpace(emailSignup))
            {
                return View("Error");
            }
            try
            {

                //user usr = new user(usernameSignup, passwordSignup, emailSignup);

                db.user.Add(new user(usernameSignup, passwordSignup, emailSignup));
                db.SaveChanges();
                return RedirectToAction("FrontPage", "FrontPage");
                //if (test)
                //{
                //    return View("~/Views/Account/LoginPage.cshtml");

                //}
                //else
                //{
                //    return View("Error");
                //}
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return View("Error");
        }

        public ActionResult LoginPage()
        {
            return View();
        }

        public ActionResult SignUp()
        {
            DatabaseEntities db = new DatabaseEntities();

            return View();
        }

        public ActionResult UserProfil()
        {
            
            return View();
        }

    }
}