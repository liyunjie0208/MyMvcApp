using Microsoft.AspNetCore.Mvc;
using MyMvcApp.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace MyMvcApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public async Task<IActionResult> Index()
        {
            var products = await _context.Products.ToListAsync();
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
