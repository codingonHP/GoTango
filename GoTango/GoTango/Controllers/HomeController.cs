using System.Web.Mvc;

namespace ADAS.GoTango.WebClient.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
