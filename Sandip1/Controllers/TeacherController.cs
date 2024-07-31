using Microsoft.AspNetCore.Mvc;

namespace Sandip1.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Contact()
        {
            string str = "Hello World";
            return View();
        }


        public IActionResult Feedback()
        {
            string str = "Hello World";
            return View();
        }
    }
}
