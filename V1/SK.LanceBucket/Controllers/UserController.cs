using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SK.LanceBucket.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        [HttpGet]
        public ActionResult Profile()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Profile(object obj)
        {
            return View();
        }
        [HttpGet]
        public ActionResult JobHome()
        {
            return View();
        }
        [HttpPost]
        public ActionResult JobHome(object obj)
        {
            return View();
        }
        [HttpGet]
        public ActionResult JobPost()
        {
            return View();
        }
        [HttpPost]
        public ActionResult JobPost(object obj)
        {
            return View();
        }
        public ActionResult Project_Description()
        {
            return View();
        }
        public ActionResult RequestedWorker()
        {
            return View();
        }
        public ActionResult WorkerProgress()
        {
            return View();
        }
    }
}