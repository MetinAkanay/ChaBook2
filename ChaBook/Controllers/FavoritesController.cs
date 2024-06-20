using Microsoft.AspNetCore.Mvc;
using ChaBook.Models;

namespace ChaBook.Controllers
{
    public class FavoritesController : Controller
    {
        //private readonly ApplicationDbContext _context;

        //public FavoritesController(ApplicationDbContext context)
        //{
        //    _context = context;
        //}

        // Favori ürünleri listele
        public IActionResult Favorites()
        {
            //var favoriteItems = _context.FavoriteItems.ToList();
            return View(/*favoriteItems*/);
        }

        //[HttpPost]
        //public IActionResult AddToFavorites(int productId)
        //{
        //    var product = _context.Products.Find(productId);
        //    if (product != null)
        //    {
        //        _context.FavoriteItems.Add(new FavoriteItem { ProductId = productId });
        //        _context.SaveChanges();
        //    }
        //    return RedirectToAction("Index");
        //}

        //[HttpPost]
        //public IActionResult RemoveFromFavorites(int productId)
        //{
        //    var favoriteItem = _context.FavoriteItems.FirstOrDefault(fi => fi.ProductId == productId);
        //    if (favoriteItem != null)
        //    {
        //        _context.FavoriteItems.Remove(favoriteItem);
        //        _context.SaveChanges();
        //    }
        //    return RedirectToAction("Index");
        //}
    }
}
