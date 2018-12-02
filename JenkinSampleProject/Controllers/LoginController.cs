using JenkinSampleProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JenkinSampleProject.Controllers
{
    public class LoginController : Controller
    {
        //default index
        public ActionResult Login()
        {
            TempData["IsLoggedIn"] = false;
            return View();
        }

        [HttpPost]
        //posting user credentials
        public ActionResult Login(LogOn logininfo)
        {
            if (ModelState.IsValid)
            {
                if (logininfo.UserId == Constant.Id && logininfo.Password == Constant.Password)
                {
                    TempData["IsLoggedIn"] = true;
                    return RedirectToAction("UserHomeView");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid username or password");
                    TempData["IsLoggedIn"] = false;
                    return View("Login");
                }
            }
            TempData["IsLoggedIn"] = false;
            return View("Login");
        }

        public ActionResult Logout()
        {
            TempData["IsLoggedIn"] = false;
            return RedirectToAction("Login", "Login");
        }
        //If login success navigate to LandingPage
        public ActionResult UserHomeView()
        {
            TempData["IsLoggedIn"] = true;
            return View();
        }
    }
}
