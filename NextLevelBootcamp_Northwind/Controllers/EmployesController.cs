using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using NextLevelBootcamp_Northwind.Models;
namespace NextLevelBootcamp_Northwind.Controllers
{
    public class EmployesController : Controller
    {
        // GET: Employes
        NORTHWNDC context = new NORTHWNDC();
        public ActionResult Index()
        {
            var employes = context.Employees.ToList();
            return View(employes);
        }
        [HttpGet]
        public ActionResult EmployesAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EmployesAdd(Employees employes)
        {
            context.Employees.Add(employes);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Sales(int id)
        {
            var sales = context.Orders.Where(x => x.EmployeeID ==id).ToList();
            return View(sales);
        }
    }
    
}