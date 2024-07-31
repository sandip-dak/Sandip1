using Microsoft.AspNetCore.Mvc;

namespace Sandip1.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            string str = "Hello World";
            return View();
        }


        public IActionResult Contact()
        {
            string str = "Hello World";
            return View();
        }
    }
}
