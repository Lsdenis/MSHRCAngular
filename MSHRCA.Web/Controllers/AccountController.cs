using System.Web.Mvc;

namespace MSHRCA.Web.Controllers
{
	[Authorize]
	public class AccountController : Controller
	{
		[AllowAnonymous]
		public ActionResult Login()
		{
			return View();
		}
	}
}