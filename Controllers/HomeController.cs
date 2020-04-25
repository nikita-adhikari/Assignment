using Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment.Controllers
{
    public class HomeController : Controller
    {
        [Route("Home/UserRegistration")]
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View(new RegisterBindingModel() );


        }

        [Route("Home/login")]
        public ActionResult Login()
        {
            

            return View();
        }

        [Route("Home/UserList")]
        public ActionResult UserList()
        {


            return View();
        }
    }
}
