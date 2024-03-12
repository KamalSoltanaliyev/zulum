using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using six_march.Areas.Admin.ViewModels;
using six_march.Contexts;
using six_march.Models;

namespace six_march.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        private readonly ProniaDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public SliderController(ProniaDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            var sliders = await _context.Sliders.ToListAsync();
            return View(sliders);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(SliderCreateViewModel slider)
        {
            if (ModelState.IsValid)
            {
                string fileName = $"{Guid.NewGuid()}-{slider.Image.FileName}";
                string path = Path.Combine(_webHostEnvironment.WebRootPath, "assets", "images", "website-images", fileName);

                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    await slider.Image.CopyToAsync(stream);
                }

                Slider newSlider = new Slider()
                {
                    Image = fileName,
                    Title = slider.Title,
                    Offer = slider.Offer,
                    Description = slider.Description
                };

                await _context.Sliders.AddAsync(newSlider);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return View(slider);
        }
    }
}
