using System;
using System.Collections.Generic;
using LanguageFeature.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFeature.Controllers {
    public class HomeController : Controller {
        public ViewResult Index(){
            return View("Index", new string[] { "Bob", "Joe", "Alice"});
        }
    }
}