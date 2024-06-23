using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace Chabook.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult Novel()
        {
            // Burada Novel alt kategorisine ait verileri alabilir ve View'e gönderebilirsiniz.
            return View();
        }
        //public IActionResult SubCategory(SubCategory subCategory)
        //{
        //    var filteredBooks = books.Where(b => b.SubCategory == subCategory).ToList();
        //    ViewBag.SubCategory = subCategory.ToString();
        //    return View(filteredBooks);
        //}
    }
}



//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using ChaBook.Data;
//using ChaBook.Models.Category;

//public class BooksController : Controller
//{
//    private readonly ApplicationDbContext _context;

//    public BooksController(ApplicationDbContext context)
//    {
//        _context = context;
//    }

//    public async Task<IActionResult> Index(int subCategoryId)
//    {
//        var books = await _context.Books
//            .Where(b => b.SubCategoryId == subCategoryId)
//            .ToListAsync();
//        return View(books);
//    }

//    public async Task<IActionResult> Details(int id)
//    {
//        var book = await _context.Books
//            .Include(b => b.SubCategory)
//            .ThenInclude(sc => sc.Category)
//            .FirstOrDefaultAsync(b => b.BookDetailId == id);

//        if (book == null)
//        {
//            return NotFound();
//        }

//        return View(book);
//    }
//}
