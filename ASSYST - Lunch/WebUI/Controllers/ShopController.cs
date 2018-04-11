using Domain.Abstract;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class ShopController : Controller
    {
        private IShopRepository _repository;

        public ShopController(IShopRepository repoParam)
        {
            _repository = repoParam;
        }

        public ViewResult ListShop()
        {
            return View(_repository.Shops);
        }

        public ActionResult AddShop(Shop shop)
        {
            if (ModelState.IsValid)
            {
                _repository.SaveShop(shop);
                TempData["Message"] = string.Format("\"{0}\" a été enregistré!", shop.Name);
                return RedirectToAction("ListShop");
            }
            else
            {
                ModelState.AddModelError("", "Les informations entrées ne sont pas correctes!");
                return View(shop);
            }
        }
    }
}