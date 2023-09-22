using AppCRUDMVC.Database;
using AppCRUDMVC.Database.ProductContext;
using AppCRUDMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace AppCRUDMVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductContext _productContext;
        public ProductController(ProductContext productContext)
        {
            this._productContext = productContext;
        }
        public IActionResult List()
        {
            var listResult = _productContext.Products.ToList();

            ProductListViewModel model = new ProductListViewModel();
            model.List = (from c in listResult select new ProductViewModel() { 
                Id = c.Id,
                Name = c.Name,
                Stock = c.Stock,
                Status = c.Status,
                Price = c.Price,
            }).ToList();
            return View(model);
        }

        public IActionResult Add()
        {
            ProductViewModel model = new ProductViewModel();
            return View(model);
        }

        public IActionResult  AddSavedAction(ProductViewModel model)
        {
            //VIENE MI LOGICA
            ProductEntity entity = new ProductEntity();

            entity.Name = model.Name;
            entity.Stock = model.Stock.HasValue? model.Stock.Value : 0;
            entity.Price = model.Price.HasValue ? model.Price.Value : 0;
            entity.DateAdded = DateTime.Now;
            entity.Status = "A";
            _productContext.Products.Add(entity);
            _productContext.SaveChanges();
            return RedirectToAction("List", "Product");
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}
