//using Microsoft.AspNetCore.Mvc;

//public class SubCategoriesController : Controller
//{
//    private readonly ApplicationDbContext _context;

//    public SubCategoriesController(ApplicationDbContext context)
//    {
//        _context = context;
//    }

//    public async Task<IActionResult> Index(int categoryId)
//    {
//        var subCategories = await _context.SubCategories
//            .Where(sc => sc.CategoryId == categoryId)
//            .ToListAsync();
//        return View(subCategories);
//    }
//}