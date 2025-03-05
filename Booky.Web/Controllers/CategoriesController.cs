using Booky.Web.Data;
using Microsoft.AspNetCore.Mvc;

namespace Booky.Web.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //TODO : Use viewModel
            var categories = _context.Categories.ToList();
            return View(categories);
        }
    }
}
