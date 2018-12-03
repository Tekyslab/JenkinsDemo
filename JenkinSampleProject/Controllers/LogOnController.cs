using JenkinSampleProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JenkinSampleProject.Controllers
{
    public class LogOnController : Controller
    {
        //default index
        public ActionResult LogOn()
        {
            return View();
        }

        [HttpPost]
        //posting user credentials
        public ActionResult LogOn(LogOn logininfo)
        {
            if (ModelState.IsValid)
            {
                if (logininfo.UserId == Constant.Id && logininfo.Password == Constant.Password)
                {
                    ViewBag.UserName = logininfo.UserId;
                    return RedirectToAction("UserHomeView");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid username or password");
                    return View("Login");
                }
            }
            return View("Login");
        }
        //If login success navigate to LandingPage
        public ActionResult UserHomeView()
        {
            return View();
        }
    }
}