using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClothesStore.DB.Abstract;
using ClothesStore.DB.Entities;

namespace ClothesStore.Web.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        IProductRepository repository;

        public AdminController(IProductRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index()
        {
            return View(repository.Products);
        }

        public ViewResult Edit(int ProductId)
        {
            Product product = repository.Products
                .FirstOrDefault(g => g.ProductId == ProductId);
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product, HttpPostedFileBase image = null)
        {
            if (ModelState.IsValid)
            {
                if (image != null)
                {
                    product.ImageMimeType = image.ContentType;
                    product.ImageData = new byte[image.ContentLength];
                    image.InputStream.Read(product.ImageData, 0, image.ContentLength);
                }   
                repository.SaveProduct(product);
                TempData["message"] = string.Format("Changes in product \"{0}\" are made ", product.Name);
                return RedirectToAction("Index");
            }
            else
            {
                return View(product);
            }
        }
        public ViewResult Create()
        {
            return View("Edit",new Product());
        }

        [HttpPost]
        public ActionResult Delete(int productId)
        {
            Product nameOfproduct = repository.Products.Where(x=>x.ProductId==productId).FirstOrDefault();
            repository.DeleteProduct(productId);
            
                TempData["message"] = string.Format("Product \"{0}\" was deleted",
                    nameOfproduct.Name);
            return RedirectToAction("Index");
        }
    }
}

