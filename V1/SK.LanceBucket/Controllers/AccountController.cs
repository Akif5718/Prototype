using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SK.LanceBucket.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(object obj)
        {
            return View();
        }
        
        [HttpGet]
        [Route("Account/Register/Catagory")]
        public ActionResult Catagory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Catagory(object obj)
        {
            return View();
        }
        [HttpGet]
        [Route("Account/Register/Catagory/CatagoryDetails")]
        public ActionResult CatagoryDetails()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CatagoryDetails(object obj)
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(object obj)
        {
            return View();
        }
    }
}