﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webgentle.BookStore.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
             //return "WebGentle";
        }
        public ViewResult AboutUs()
        {
            return View();
            //return "WebGentle";
        }

        public ViewResult ContactUs()
        {
            return View();
            //return "WebGentle";
        }
    }
}
