using Microsoft.AspNetCore.Mvc;

namespace Graduate_Project.Controllers
{
    public class SamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
