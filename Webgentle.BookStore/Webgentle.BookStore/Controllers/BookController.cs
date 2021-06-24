using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webgentle.BookStore.Controllers
{
    public class BookController : Controller
    {
        public string Getallbooks()
        {
            return "WebGentle";
        }
        //
        public string Getbook(int ID)
        {
            return $"WebGentle {ID}";
        }
        //
        public string Searchbook(String Title, String Author)
        {
            return $"Your Searched Book Is {Title} Written By Author {Author}";
        }
    }
}
