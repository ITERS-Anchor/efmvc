using MVCWeb.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWeb.Controllers
{
    public class UserInfoController : Controller
    {
        // GET: UserInfo
        public ActionResult Index()
        {
            //dbtestEntities entity = new dbtestEntities();
            //1.Use LinQ select
            //var userList = from info in entity.UserInfo select info;

            //2.Use Select() Method
            //var userList = entity.UserInfo.Select(u=>u);

            //ViewData.Model = userList;

            //引用父类指向子类
            DbContext context = new dbtestEntities();
            IQueryable<UserInfo> userList;

            //userList = from info in context.Set<UserInfo>() select info;
            userList = from info in context.Set<UserInfo>()
                       where info.UserId==3//一定是"=="号
                       select info;

            return View(userList);
        }
    }
}