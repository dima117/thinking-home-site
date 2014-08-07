using System.Web.Mvc;

namespace ThinkingHomeSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

		public ActionResult GettingStarted()
		{
			return View();
		}

		public ActionResult Scripts()
		{
			return View();
		}

		public ActionResult Plugins()
	    {
			return View();
	    }

	    public ActionResult UiForPlugins()
	    {
			return View();
	    }
    }
}
