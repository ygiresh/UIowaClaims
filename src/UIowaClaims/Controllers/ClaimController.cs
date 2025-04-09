using Microsoft.AspNetCore.Mvc;

namespace UIowaClaims.Web.Controllers
{
    public class ClaimController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            return View();
        }
    }
}
