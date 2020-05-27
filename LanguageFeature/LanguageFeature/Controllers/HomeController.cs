using System;
using System.Collections.Generic;
using LanguageFeature.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFeature.Controllers {
    public class HomeController : Controller {
        public ViewResult Index(){
            
            string[] names = new string[3];
            names[0] = "Bob";
            names[1] = "Joe";
            names[2] = "Alice";
            return View("Index", names);
        }
    }
}