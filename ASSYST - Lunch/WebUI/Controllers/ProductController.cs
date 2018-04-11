using Domain.Abstract;
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
        private IProductRepository _repository;

        public ProductController(IProductRepository repoParam)
        {
            _repository = repoParam;
        }

        public ViewResult ListProduct()
        {
            ProductListViewModel model = new ProductListViewModel();
            model.Products = _repository.Products.Where(p => p.IsActive);
            return View(model);
        }
    }
}