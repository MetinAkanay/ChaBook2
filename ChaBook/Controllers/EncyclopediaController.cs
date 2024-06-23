using Microsoft.AspNetCore.Mvc;

namespace ChaBook.Controllers
{
    public class EncyclopediaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult General()
        //{
        //    var model = new List<EncyclopediaItem>
        //    {
        //        new EncyclopediaItem { Id = 1, Title = "General Encyclopedia", Description = "Information about various topics" },
        //        new EncyclopediaItem { Id = 2, Title = "Encyclopedia of Knowledge", Description = "A comprehensive guide to knowledge" }
        //    };

        //    return View(model);
        //}

        //public IActionResult Children()
        //{
        //    var model = new List<EncyclopediaItem>
        //    {
        //        new EncyclopediaItem { Id = 1, Title = "Children's Encyclopedia", Description = "Educational content for kids" },
        //        new EncyclopediaItem { Id = 2, Title = "Illustrated Encyclopedia", Description = "Richly illustrated encyclopedia for children" }
        //    };

        //    return View(model);
        //}
    }
}
