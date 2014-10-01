using System.Web.Mvc;
using System.Web.Routing;

namespace ThinkingHomeSite
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
				name: "getting-started",
				url: "getting-started",
				defaults: new { controller = "Home", action = "GettingStarted" }
			);

			routes.MapRoute(
				name: "home-scripts",
				url: "home-scripts",
				defaults: new { controller = "Home", action = "Scripts" }
			);

			routes.MapRoute(
				name: "plugins",
				url: "plugins",
				defaults: new { controller = "Home", action = "Plugins" }
			);

			routes.MapRoute(
				name: "ui-for-plugins", 
				url: "ui-for-plugins",
				defaults: new { controller = "Home", action = "UiForPlugins" }
			);

			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
			);
		}
	}
}