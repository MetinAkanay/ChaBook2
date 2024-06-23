using Microsoft.AspNetCore.Mvc;

namespace ChaBook.Controllers
{
    public class EducationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
        //public IActionResult Helpful()
        //{
        //    var books = GetBooksBySubCategory("Helpful"); // Yardımcı bir metot kullanarak ilgili alt kategorideki kitapları alın

        //    ViewBag.SubCategory = "Helpful"; // View'e alt kategori adını gönder

        //    return View("subcategory", books);
        //}

        //public IActionResult Exam()
        //{
        //    var books = GetBooksBySubCategory("Exam"); // Yardımcı bir metot kullanarak ilgili alt kategorideki kitapları alın

        //    ViewBag.SubCategory = "Exam"; // View'e alt kategori adını gönder

        //    return View("subcategory", books);
        //}

        //// Diğer alt kategori aksiyonları da benzer şekilde tanımlanır...

        //private IEnumerable<Book> GetBooksBySubCategory(string subCategory)
        //{
        //    // Burada ilgili alt kategorideki kitapları veritabanından alabilirsiniz
        //    // Örneğin:
        //    // return _context.Books.Where(b => b.SubCategory == subCategory).ToList();

        //    // Bu örnekte veritabanı kullanmadığımız için basit bir liste döndürüyoruz
        //    return new List<Book>
        //{
        //    new Book { Title = "Sample Book 1", Author = "Author 1" },
        //    new Book { Title = "Sample Book 2", Author = "Author 2" },
        //    new Book { Title = "Sample Book 3", Author = "Author 3" }
        //};
        
}

