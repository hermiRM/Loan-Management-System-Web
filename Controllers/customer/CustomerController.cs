using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanManagementSystem.Controllers.customer
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.HomeActive = "active";
            return View();
        }
        public IActionResult Account()
        {
            ViewBag.AccountActive = "active";
            return View();
        }
        public IActionResult Loan()
        {
            ViewBag.LoanActive = "active";
            return View();
        }
        public IActionResult Payment()
        {
            return View();
        }
        public IActionResult Report()
        {
            return View();
        }
    }
}
