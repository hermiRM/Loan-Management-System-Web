﻿using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LoanManagementSystem.Models;
using Scrypt;
using Microsoft.AspNetCore.Http;
using LoanManagementSystem.Helpers;



namespace LoanManagementSystem.Controllers
{
    public class LoginController : Controller
    {
        private readonly LoanManagementContext _context;

        public LoginController(LoanManagementContext context)
        {
            _context = context;
        }

        // GET: CustomerLogin/Login
        public IActionResult Login()
        {
            if (HttpContext.Session.GetInt32("userId") != null && HttpContext.Session.GetInt32("isAdmin") == 1)
            {
                return RedirectToAction(actionName: "Index", controllerName: "Administrator");
            }
            if (HttpContext.Session.GetInt32("userId") != null && HttpContext.Session.GetInt32("isAdmin") == 0 )
            {
                return RedirectToAction(actionName: "Index", controllerName: "Customer");
            }
            return View();
        }

        // POST: CustomerLogin/Login
      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([Bind("Id,User_Name,User_Password")] UserAccount userAccount)
        {
            ScryptEncoder encoder = new ScryptEncoder();

            if (ModelState.IsValid)
            {
                //check Auth
                string username = userAccount.User_Name;
                string password = userAccount.User_Password;

                UserAccount User = new UserAccount();
                User = _context.Accounts.FirstOrDefault(e => e.User_Name == username);

                //FormsAuthentication.SetAuthCookie(User.Id,false);
                if (encoder.Compare(password, User.User_Password))
                {
                    //TempData["AlertType"] = "success";
                    //TempData["AlertMessage"] = "User Found";
                    int isAdmin = User.IsAdmin ? 1 : 0;
                    HttpContext.Session.SetInt32("userId", User.Id);
                    HttpContext.Session.SetInt32("isAdmin", isAdmin);
                    HttpContext.Session.SetString("username", User.User_Name);

                    UserAccount user = new UserAccount();
                    user.User_Name = User.User_Name;
                    user.User_Password = User.User_Password;

                    SessionHelper.SetObjectAsJson(HttpContext.Session, "user", user);

                    if (isAdmin == 1)
                    {
                        return RedirectToAction(actionName: "Index", controllerName: "Administrator");
                    }

                    return RedirectToAction(actionName: "Index", controllerName: "Customer");



                }

                else
                {
                    TempData["AlertType"] = "danger";
                    TempData["AlertMessage"] = "Incorrect Credential";
                    return View(userAccount);
                }
           
            }
            return View(userAccount);
        }

        // Get: CustomerLogin/Logout

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
