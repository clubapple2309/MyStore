using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClothesStore.DB.Abstract;
using ClothesStore.DB.Entities;

namespace ClothesStore.Web.Controllers
{
    public class MenuController : Controller
    {
        private IProductRepository repository;

        public MenuController(IProductRepository repo)
        {
            repository = repo;
        }
       public PartialViewResult Menu(string category = null)
        {
            ViewBag.SelectedCategory = category;
            IEnumerable<string> categories = repository.Products
              .Select(game => game.Category)
              .Distinct()
              .OrderBy(x => x);
            return PartialView(categories);
        }

    }
}