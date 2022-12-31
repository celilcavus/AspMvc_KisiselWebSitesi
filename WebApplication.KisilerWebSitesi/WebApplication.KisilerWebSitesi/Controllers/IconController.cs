using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using WebApplication.KisilerWebSitesi.Models;
using WebApplication.KisilerWebSitesi.Models.Entity;
using WebGrease.Css.Ast;

namespace WebApplication.KisilerWebSitesi.Controllers
{
    public class IconController : Controller
    {
        AppDbContext app = null;
        public IconController()
        {
            app = new AppDbContext();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult iconList()
        {
            var returnSource = app.iconlar.ToList();
            return View(returnSource);
        }

        public ActionResult newIconAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult newIconAdd(iconlar icon)
        {
            if (icon != null)
            {
                iconlar icons = new iconlar();
                icons.icon = icon.icon;
                icons.iconlink = icon.iconlink;
                app.iconlar.Add(icons);
                app.SaveChanges();
                return RedirectToAction("iconList");
            }
            else
                return HttpNotFound();
           
        }
        public ActionResult getIcon(int id)
        {
            var source = app.iconlar.Find(id);
            return View("IconUpdate",source);
        }
        public ActionResult IconUpdate(iconlar icon)
        {
            var findIcon = app.iconlar.Find(icon.Id);
            findIcon.icon = icon.icon;
            findIcon.iconlink = icon.iconlink;
            app.SaveChanges();
            return RedirectToAction("iconList", "Icon");
        }
        public ActionResult IconDelete(int id)
        {
            var source = app.iconlar.Find(id);
            app.iconlar.Remove(source);
            app.SaveChanges();
            return RedirectToAction("iconList");
        }
    }
}