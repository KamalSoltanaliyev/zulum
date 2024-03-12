using Microsoft.AspNetCore.Mvc;
using six_march.Contexts;
using six_march.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace six_march.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProniaDbContext _context;
        public HomeController(ProniaDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var Sliders = await _context.Sliders.ToListAsync();
            var shippings = await _context.Shippings.ToListAsync();

            HomeViewModel homeViewModel = new HomeViewModel
            {
                Sliders = Sliders,
                Shippings = shippings
            };

            return View(homeViewModel);
        }
    }
}