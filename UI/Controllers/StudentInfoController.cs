using BLL;
using Model;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class StudentInfoController : Controller
    {
        StudentInfoBLL sbll = new StudentInfoBLL();
        ClassInfoBLL cbll = new ClassInfoBLL();
        // GET: StudetInfo
        public ActionResult Index()
        {
            //ViewData.Model = sbll.GetAll(5,1);
            return View();
        }
        public ActionResult LoadPageList(int pageSize,int pageIndex)
        {
            int elems = sbll.GetAll().Count();
            int pageCount =Convert.ToInt32( Math.Ceiling(elems*1.0/ pageSize));
            pageIndex = pageIndex < 1 ? 1 : pageIndex;
            pageIndex = pageIndex > pageCount ? pageCount : pageIndex;           
            var list = sbll.GetPageList(pageSize,pageIndex)
                .Select(x => new
                {
                    Id = x.sId,
                    Name = x.sName,
                    Gender = x.sGender,
                    DOB = x.sBirthday,
                    Phone = x.sPhone,
                    Email = x.sEMail,
                    Class = x.ClassInfo.cTitle
                })
                .ToList();
            string pgbar = PageBar.GetPageBar(pageIndex, pageCount);
            return Json(new { myList = list, myPageBar = pgbar }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Add()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            var l = cbll.GetAll();
            foreach (var item in l)
            {
                list.Add(new SelectListItem() {
                    Text = item.cTitle,
                    Value = item.cId.ToString()
                });
            }
            ViewBag.ClassList = list;
            
            return View();
        }
        [HttpPost]
        public ActionResult Add(StudentInfo s)
        {
            sbll.Add(s);
            return Redirect(Url.Action("Index"));
        }
    }
}