using System.Web.Mvc;

namespace SistemaDeRestaurantes.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        } 
    }
}