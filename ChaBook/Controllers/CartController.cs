using ChaBook.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChaBook.Controllers
{
    public class CartController : Controller
    {
        // Sepeti görüntüleme
        public ActionResult Cart()
        {
            var cartItems = new List<CartItemViewModel>
            {
                new CartItemViewModel { ProductId = 1, ProductName = "Product 1", Quantity = 1, Price = 10, Stock = 5, ImageUrl = "path_to_image1.jpg" },
                new CartItemViewModel { ProductId = 2, ProductName = "Product 2", Quantity = 2, Price = 15, Stock = 3, ImageUrl = "path_to_image2.jpg" }
            };

            var cart = new CartViewModel { Items = cartItems, TotalPrice = cartItems.Sum(item => item.Quantity * item.Price) };

            return View(cart);
        }

        // Sepete ürün ekleme
        public ActionResult AddToCart(int productId)
        {
            // Sepete ürün ekleme işlemlerini burada yapabilirsiniz
            // Örneğin, sepet modeline ürün ekleme kodları
            return RedirectToAction("Index");
        }

        // Sepetten ürün çıkarma
        public ActionResult RemoveFromCart(int productId)
        {
            // Sepetten ürün çıkarma işlemlerini burada yapabilirsiniz
            // Örneğin, sepet modelinden ürünü çıkarma kodları
            return RedirectToAction("Index");
        }
    }
}
