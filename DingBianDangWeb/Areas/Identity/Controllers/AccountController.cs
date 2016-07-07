using System.Web.Mvc;

namespace DingBianDangWeb.Areas.Identity.Controllers
{
    public class AccountController : Controller
    {
        // GET: Identity/Account

        public PartialViewResult LoginForm()
        {
            return PartialView("_LoginForm");
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}