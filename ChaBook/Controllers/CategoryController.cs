//using Microsoft.AspNetCore.Mvc;

//public class CategoriesController : Controller
//{
//    private readonly ApplicationDbContext _context;

//    public CategoriesController(ApplicationDbContext context)
//    {
//        _context = context;
//    }

//    public async Task<IActionResult> Index()
//    {
//        var categories = await _context.Categories.ToListAsync();
//        return View(categories);
//    }
//}