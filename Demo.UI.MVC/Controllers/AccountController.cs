using Demo.BLL.Abstract;
using Demo.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Demo.UI.MVC.Controllers
{
    public class AccountController : Controller
    {
        IUserService userService;
        public AccountController(IUserService userService)
        {
            this.userService = userService;
        }
        public ActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
        [HttpPost,ValidateAntiForgeryToken]
        public ActionResult Login(string email, string password, bool rememberme)
        {
            if (ModelState.IsValid)
            {
                User currentUser = userService.GetUserByLogin(email, password);

                if (currentUser != null)
                {
                    FormsAuthentication.SetAuthCookie(currentUser.Name, rememberme);
                    return RedirectToAction("Index", "Home");
                }
            }
            ViewBag.Error = "Giriş başarısız";
            return View("Login");
        }
    }
}