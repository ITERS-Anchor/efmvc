using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{//CRUD
    public class ClassInfoController : Controller
    {
        ClassInfoBLL bll = new ClassInfoBLL();
        // GET: ClassInfo
        public ActionResult Index()
        {
            ViewData.Model= bll.GetAll();
            return View();
        }
        //CREATE
        public ActionResult Add()
        {
            return View();
        }
        //ADD POST
        [HttpPost]
        public ActionResult Add(ClassInfo c)
        {
            bll.Add(c);
            return Redirect(Url.Action("Index"));
        }
        //UPDATE 
        public ActionResult Edit(int id)
        {          
            ClassInfo EditContent = bll.GetById(id);                     
            return View(EditContent);
        }
        [HttpPost]
        public ActionResult Edit(ClassInfo c)
        {
            bll.Edit(c);
            return Redirect(Url.Action("Index"));
        }
        //DELETE
        public ActionResult Delete(int id)
        {
            bll.Delete(id);
            return Redirect(Url.Action("Index"));
        }
    }
}