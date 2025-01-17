using FullFiorellaProject.Data;
using FullFiorellaProject.Models;
using FullFiorellaProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FullFiorellaProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task <IActionResult> Index()
        {
            List<Slider>sliders = await _context.Sliders.ToListAsync();
            SliderInfo sliderInfos = await _context.SliderInfos.FirstOrDefaultAsync();
            List<Category>categories = await _context.Categories.ToListAsync();
            List<Product>products = await _context.Products.Include(m=>m.ProductImages).ToListAsync();  
            AboutVideo aboutVideo=await _context.AboutVideos.FirstOrDefaultAsync();
            AboutTitles aboutTitles=await _context.AboutTitles.FirstOrDefaultAsync();
            List<IconTitle>iconTitles=await _context.IconTitles.ToListAsync();
            FlowerExperts flowerExperts= await _context.FlowerExperts.FirstOrDefaultAsync();
            List<Experts> experts=await _context.Experts.ToListAsync();
            List<Blog>blogs= await _context.Blogs.Where(m=>!m.SoftDeleted).ToListAsync();
            HomeVm model = new()
            {
                Sliders = sliders,
                SliderInfos=sliderInfos,
                Categories = categories,
                Products = products,
                AboutVideos=aboutVideo,
                AboutTitles=aboutTitles,
                IconTitles=iconTitles,
                FlowerExperts=flowerExperts,
                Experts=experts,
                Blogs=blogs,
            };
            return View(model);
        }
    }
}
