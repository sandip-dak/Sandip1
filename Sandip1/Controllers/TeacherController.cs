using Microsoft.AspNetCore.Mvc;

namespace Sandip1.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
