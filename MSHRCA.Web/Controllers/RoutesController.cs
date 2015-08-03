using System.Web.Mvc;

namespace MSHRCA.Web.Controllers
{
	public class RoutesController : Controller
	{
		public ActionResult First()
		{
			return PartialView();
		}

		public ActionResult Second()
		{
			return PartialView();
		}

		[Authorize]
		public ActionResult Third()
		{
			return PartialView();
		}
	}
}