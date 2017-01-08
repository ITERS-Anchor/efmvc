using LoginDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginDemo.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account

        book_shopContext dbContext = new book_shopContext();
        [HttpGet]
        public ActionResult Login()
        {
            return View(new LoginFormModel { });
        }
        ////[HttpPost]
        ////public ActionResult Login(string username, string password,bool remember=false)
        ////{
        ////    var user = dbContext.Set<User>().FirstOrDefault(u => u.LoginId.Equals(username, System.StringComparison.InvariantCultureIgnoreCase));
        ////    if (user == null || user.LoginPwd != password)
        ////    {
        ////        ViewBag.Msg = "Wrong name or password!";
        ////        return View();
        ////    }
        ////    //return Redirect(string.IsNullOrEmpty(redirect)?"/": redirect);
        ////    ViewBag.Msg = "Login sucessufull!";
        ////    return View();
        ////}

        [HttpPost]
        public ActionResult Login(LoginFormModel login)
        {
            var user = dbContext.Set<User>().FirstOrDefault(u => u.LoginId.Equals(login.Username, System.StringComparison.InvariantCultureIgnoreCase));
            if (user == null || user.LoginPwd != login.Password)
            {
                ViewBag.Msg = "Wrong name or password!";
                return View(login);
            }
            //return Redirect(string.IsNullOrEmpty(redirect)?"/": redirect);
            ViewBag.Msg = "Login sucessufull!";
            return View(login);
        }

        protected override void Dispose(bool disposing)
        {
            dbContext.Dispose();
            base.Dispose(disposing);
        }
    }
}