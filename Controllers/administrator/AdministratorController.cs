using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using LoanManagementSystem.Helpers;

namespace LoanManagementSystem.Controllers.administrator
{
    public class AdministratorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Loan()
        {
            return View();
        }
        public IActionResult Payment()
        {
            return View();
        }
        public IActionResult LoanPlan()
        {
            ViewBag.LoanPlanActive = "active";
            return View();
        }
        public IActionResult LoanType()
        {
            return View();
        }
        public IActionResult Report()
        {
            return View();
        }
        public IActionResult Customers()
        {
            return View();
        }
        public IActionResult Users()
        {
            return View();
        }
        public RedirectToActionResult Logout()
        {
            HttpContext.Session.SetInt32("userId", -1);
            HttpContext.Session.SetInt32("isAdmin", -1);
            HttpContext.Session.SetString("username", "");
            SessionHelper.SetObjectAsJson(HttpContext.Session, "user", null);

            //Redirects to Index Action Method from HomeController
            return RedirectToAction(actionName: "Index", controllerName: "Home");


        }
    }
}
