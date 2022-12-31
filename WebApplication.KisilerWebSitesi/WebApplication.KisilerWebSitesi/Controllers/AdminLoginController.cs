using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebApplication.KisilerWebSitesi.Models;
using WebApplication.KisilerWebSitesi.Models.Entity;

namespace WebApplication.KisilerWebSitesi.Controllers
{
    public class AdminLoginController : Controller
    {
        AppDbContext app = null;
        public AdminLoginController()
        {
            app = new AppDbContext();
        }
     
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            var source = app.Admin.FirstOrDefault(x => x.username == admin.username && x.password == admin.password);
            if (source != null)
            {
                FormsAuthentication.SetAuthCookie(source.username, false);
                Session["username"] = source.username.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
                return View(admin);
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "AdminLogin");
        }

    }
}