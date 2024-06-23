using Microsoft.AspNetCore.Mvc;
using ChaBook.Models;
using System.Collections.Generic;
using System.Linq;

namespace ChaBook.Controllers
{
    public class MagazinesController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult SubCategory(SubCategory subCategory)
        //{
        //    var filteredMagazines = magazines.Where(m => m.SubCategory == subCategory).ToList();
        //    ViewBag.SubCategory = subCategory.ToString();
        //    return View(filteredMagazines);
        //}
    }
}
