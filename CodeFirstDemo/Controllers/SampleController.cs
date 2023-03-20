using CodeFirstDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstDemo.Controllers
{
    public class SampleController : Controller
    {
        private EnrollDbContext context;

        public SampleController(EnrollDbContext _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult SubView()
        {
            return PartialView(context.Courses);
        }
    }
}
