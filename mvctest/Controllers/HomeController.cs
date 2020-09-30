using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvctest.Models;

namespace mvctest.Controllers
{
    public class HomeController : Controller
    {
        EmpdbContext oe = new EmpdbContext();
        // GET: Home
        public ActionResult Index()
        {
            List<Emp> oe1 = oe.Emps.ToList();

            TempData["liemp"] = oe1;
            TempData.Keep();

            List<SelectListItem> li = new List<SelectListItem>();
            foreach (var item in oe.Depts.ToList())
            {
                li.Add(new SelectListItem() { Text = item.Dname, Value = item.Did.ToString() });
            }
            TempData["li"] = li;
            TempData.Keep();
            return View();

           // return View();
        }
        [HttpGet]
        public ActionResult Delete(string id)
        {


            Models.Emp c1 = oe.Emps.Find(id);
            oe.Emps.Remove(c1);
            oe.SaveChanges();
            //  EmpdbContext obj = new EmpdbContext();
            // Emp e2 = new Emp();
         //   Emp ee = new Emp();
         //   ee.EmpId = id;
         //   Emp e2 = new Emp();
         //   e2=oe.Emps.Find(ee);
         //oe.Emps.Remove(e2);
         //   oe.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}