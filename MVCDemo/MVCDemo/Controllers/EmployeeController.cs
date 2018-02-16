using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            EmployeeListVM empList = new EmployeeListVM();
            return View(empList.EmployeeList);
        }

        public ActionResult Details(int id)
        {
            ViewData["DateTime"] = DateTime.Now;
            ViewBag.Date = DateTime.Now.DayOfWeek;
            var val = RouteData.Values["id"];
            EmployeeListVM empList = new EmployeeListVM();
            var model = empList.EmployeeList.FirstOrDefault(item => item.Id == id);
            return View(model);
        }

        public JsonResult JSon()
        {
            return Json(new { }, JsonRequestBehavior.AllowGet);
        }

        public PartialViewResult PartialView()
        {
            //comes without layout page
            //Doesn't incude viewstart page
            return PartialView();
        }

        public ContentResult Content()
        {
            return Content();
        }

        public RedirectToRouteResult Redirect()
        {
            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            ViewData["DateTime"] = DateTime.Now;// ((DateTime)TempData["TestTemp"]);
            ViewBag.Date = DateTime.Now.DayOfWeek;
            var test = ViewBag.TempDate;
            
            return View();
        }

        public ActionResult TestTemp()
        {
            ViewData["TempDateTime"] = DateTime.Now;
            ViewBag.TempDate = DateTime.Now.DayOfWeek;
            TempData["TestTemp"] = DateTime.Now.AddDays(-1);
            return RedirectToAction("About");
        }
    }
}