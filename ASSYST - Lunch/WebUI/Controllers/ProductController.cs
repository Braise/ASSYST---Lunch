using Domain.Abstract;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _repositoryProduct;
        private IShopRepository _repositoryShop;

        public ProductController(IProductRepository repoProductParam, IShopRepository repoShopParam)
        {
            _repositoryProduct = repoProductParam;
            _repositoryShop = repoShopParam;
        }

        public ViewResult ListProduct()
        {
            return View(_repositoryProduct.Products.Where(p => p.IsActive));
        }

        public ViewResult CreateProduct()
        {
            EditProductViewModel model = new EditProductViewModel
            {
                Product = new Product(),
                Shops = _repositoryShop.Shops.Where(p => p.IsActive)
            };
            return View("EditProduct", model);
        }

        public ViewResult EditProduct(string guid)
        {
            Product product = _repositoryProduct.Products.FirstOrDefault(p => p.Guid.Equals(guid));
            EditProductViewModel model = new EditProductViewModel
            {
                Product = product,
                Shops = _repositoryShop.Shops.Where(p => p.IsActive)
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult EditProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                product.Shop = _repositoryShop.Shops.FirstOrDefault(s => s.Guid.Equals(product.Shop.Guid));
                _repositoryProduct.SaveProduct(product);
                return RedirectToAction("ListProduct");
            }
            else
            {
                return View(product);
            }
        }
    }
}