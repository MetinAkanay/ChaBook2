using Microsoft.AspNetCore.Mvc;
using ChaBook.Models;
using System.Collections.Generic;

namespace Chabo.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            // Örnek veri
            var books = new List<Book>
            {
                new Book
                {
                    Id = 1,
                    Title = "Book Title 1",
                    Description = "Description 1",
                    Author = "Author 1",
                    Price = 10.99m,
                    Rating = 4,
                    ImageUrl = "path_to_image1"
                },
                new Book
                {
                    Id = 2,
                    Title = "Book Title 2",
                    Description = "Description 2",
                    Author = "Author 2",
                    Price = 12.99m,
                    Rating = 5,
                    ImageUrl = "path_to_image2"
                },
                // Diğer kitaplar
            };

            return View(books);
        }
    }
}
