using System;
using System.Collections.Generic;
using LanguageFeature.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFeature.Controllers {
    public class HomeController : Controller {
        public ViewResult Index(){
            Dictionary<string, Product> products = new Dictionary<string, Product> {
                { "Kayak", new Product{Name = "Kayak", Price = 275M}},
                { "Lifejacket" , new Product{ Name = "Lifejacket", Price = 48.95M}}
            };
            return View("Index", products.Keys);
        }
    }
}