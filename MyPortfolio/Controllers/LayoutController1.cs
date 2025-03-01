using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Controllers
{
    public class LayoutController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
