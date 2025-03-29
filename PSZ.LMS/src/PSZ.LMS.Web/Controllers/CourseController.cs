using Microsoft.AspNetCore.Mvc;

namespace PSZ.LMS.Web.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}
