using System;
using System.Collections.Generic;
using LanguageFeature.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFeature.Controllers {
    public class HomeController : Controller {
        public ViewResult Index() {
            ShoppingCart cart = new ShoppingCart{Products = Product.GetProducts()};
            decimal cartTotal = cart.TotalPrices();
            return View("Index", new string[] {$"Total: {cartTotal:C2}"});
        }
    }
}