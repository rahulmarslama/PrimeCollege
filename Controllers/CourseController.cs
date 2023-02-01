using Microsoft.AspNetCore.Mvc;

namespace PrimeCollege.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
