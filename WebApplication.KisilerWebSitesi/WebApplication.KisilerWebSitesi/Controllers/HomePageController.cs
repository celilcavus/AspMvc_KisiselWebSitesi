using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.KisilerWebSitesi.Models;

namespace WebApplication.KisilerWebSitesi.Controllers
{
    public class HomePageController : Controller
    {
        AppDbContext app = null;
        public HomePageController()
        {
            app = new AppDbContext();
            //using (app)
            //{
            //    if (app.Database.Exists() != true)
            //    {
            //        app.Database.Create();
            //    }

            //}
        }

        // GET: HomePage
        public ActionResult Index()
        {
            var returnSource = app.Anasayfa.ToList();
            return View(returnSource);
        }
        public PartialViewResult icons()
        {
            var deger = app.iconlar.ToList();
            return PartialView(deger);
        }
    }
}