using CodeFirstDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstDemo.Controllers
{
    public class CourseController : Controller
    {
        private EnrollDbContext _context;

        public CourseController(EnrollDbContext context)
        {
            _context= context;
        }
        public IActionResult Index()
        {
            return View(_context.Courses);
            
            
        }
    }
}
