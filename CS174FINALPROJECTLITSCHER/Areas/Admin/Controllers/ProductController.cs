using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CS174FINALPROJECTLITSCHER.Models;
using Microsoft.AspNetCore.Authorization;
namespace CS174FINALPROJECTLITSCHER.Areas.Admin.Controllers
{
        [Authorize(Roles = "Admin")]
        [Area("Admin")]
    public class ProductController : Controller
    {
        private ICS174FinalProjectLitscherUnitOfWork data { get; set; }

        public ProductController(ICS174FinalProjectLitscherUnitOfWork unit)
        {
            data = unit;
        }

        public IActionResult Index()
        {

            List<Product> products = (List<Product>)data.Products.List(new QueryOptions<Product> { });
            return View(products);
        }

        public IActionResult Edit()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Appearances = data.Appearances.List(new QueryOptions<Appearance> {Where = d => d.AppearanceID != "all"}); ;
            ViewBag.Hardnesses = data.Hardnesses.List(new QueryOptions<Hardness> { Where = d => d.HardnessID != "all" }); ;
            return View("Edit", new Product());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Appearances = data.Appearances.List(new QueryOptions<Appearance> { Where = d => d.AppearanceID != "all" });
            ViewBag.Hardnesses = data.Hardnesses.List(new QueryOptions<Hardness> { Where = d => d.HardnessID != "all" });
            var product = data.Products.Get(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                if (product.productID == 0)
                    data.Products.Insert(product);
                else
                    data.Products.Update(product);

                data.Products.Save();
                return RedirectToAction("Index", "Product");
            }
            else
            {
                ViewBag.Appearances = data.Appearances.List(new QueryOptions<Appearance> { Where = d => d.AppearanceID != "all" }); 
                ViewBag.Hardnesses = data.Hardnesses.List(new QueryOptions<Hardness> { Where = d => d.HardnessID != "all" }); 
                return View(product);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var product = data.Products.Get(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Delete(Product product)
        {
            data.Products.Delete(product);
            data.Products.Save();
            return RedirectToAction("Index", "Product");
        }
    }
}
