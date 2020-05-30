using System;
using System.Collections.Generic;
using LanguageFeature.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFeature.Controllers {
    public class HomeController : Controller {
        public ViewResult Index() {
            object[] data = new object[] {275M, 29.95M, "apple", "oranges", 100, 10};
            decimal total = 0;
            for (int i = 0; i < data.Length; i++) {
                if (data[i] is decimal d) {
                    total += d;
                }
            }
            return View("Index", new string[] {$"Total: {total:C2}"});
        }
    }
}