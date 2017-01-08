using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Models;

namespace Test.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View(new Register());
        }
        [HttpGet]
        public ActionResult Test()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Test(Register r)
        {
            if (Request.IsAjaxRequest())
            {
                return Json(new { });
            }            
            return View(r);
        }
        public ActionResult CheckUsername(string username)
        {
            string[] exists = { "helen","chris"};
            
            return Json(!exists.Contains(username),JsonRequestBehavior.AllowGet);
        }
    }
}