using Microsoft.AspNetCore.Mvc;
using PSZ.LMS.Web.Areas.Admin.Models;

namespace PSZ.LMS.Web.Controllers
{
    [Area("Admin")]
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

        [HttpPost]
        public IActionResult Add(AddCourseModel model)
        {
            foreach (var lesson in model.Lessons)
            {
                Console.WriteLine($"Lessson : {lesson.Name}");
                foreach (var topic in lesson.Topics)
                {
                    Console.WriteLine($"Topic : {topic.VideoLink}");
                }
            }
            return View(model);
        }
    }
}
