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
            EmployeeListVM empList = new EmployeeListVM();
            var model = empList.EmployeeList.Where(item => item.Id == id).FirstOrDefault();
            return View(model);
        }
    }
}