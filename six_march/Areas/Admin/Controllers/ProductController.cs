using Microsoft.AspNetCore.Mvc;
using six_march.Contexts;

namespace six_march.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        //public ProductController(ProniaDbContext context)
        //{
        //    _context = context;
        //}
    }
}
