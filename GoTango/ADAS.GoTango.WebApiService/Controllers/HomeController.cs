using System.Web.Mvc;

namespace ADAS.GoTango.WebApiService.Controllers
{
   
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
