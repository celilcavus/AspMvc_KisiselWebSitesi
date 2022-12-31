using System.Linq;
using System.Web.Mvc;
using WebApplication.KisilerWebSitesi.Models;
using WebApplication.KisilerWebSitesi.Models.Entity;


namespace WebApplication.KisilerWebSitesi.Controllers
{
    public class AdminController : Controller
    {
        AppDbContext app = null;
        public AdminController()
        {
            app = new AppDbContext();
        }
        [Authorize]
        public ActionResult Index()
        {
            var returnSource = app.Anasayfa.ToList();
            return View(returnSource);
        }
        public ActionResult GetHomePage(int id)
        {
            var getHome = app.Anasayfa.Find(id);
            return View("GetHomePage",getHome);
        }
        [HttpPost]
        public ActionResult UpdateHomePage(Anasayfa i)
        {
            var homepage = app.Anasayfa.Find(i.Id);
            homepage.NameAndSurname = i.NameAndSurname;
            homepage.Image = i.Image;
            homepage.Title = i.Title;
            homepage.Abaout = i.Abaout;
            homepage.Contact = i.Contact;
            app.SaveChanges();
            return RedirectToAction("Index","HomePage");
        }
    }
}