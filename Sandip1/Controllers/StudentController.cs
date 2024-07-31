using Microsoft.AspNetCore.Mvc;

namespace Sandip1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}