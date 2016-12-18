using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClothesStore.Web.Models;
using System.Web.Security;

namespace ClothesStore.Web.Controllers
{
    public class AccountController : Controller
    {
        //IAuthProvider authProvider;
        //public AccountController(IAuthProvider auth)
        //{
        //    authProvider = auth;
        //}

        public ViewResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {

            if (ModelState.IsValid)
            {
                if (FormsAuthentication.Authenticate(model.UserName, model.Password))
                {
                    FormsAuthentication.SetAuthCookie(model.UserName, false);
                    return Redirect(returnUrl ?? Url.Action("Index", "Admin"));
                }
                else
                {
                    ModelState.AddModelError("", "We can not find an account with that Login and Password ");
                    return View();
                }
            }
            else
            {
                return View();
            }
        }
    }
}