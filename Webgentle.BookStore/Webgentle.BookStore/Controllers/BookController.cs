using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webgentle.BookStore.Models;
using Webgentle.BookStore.Repository;

namespace Webgentle.BookStore.Controllers
{
    public class BookController : Controller
    {
        public readonly BookRepository _bookrepository=null;
        public BookController()
        {
            _bookrepository = new BookRepository();
        }

        public List<BookModel> Getallbooks()
        {
            return _bookrepository.GetAllBooks();
        }
        //
        public BookModel Getbook(int ID)
        {
            return _bookrepository.GetBook(ID);
        }
        //
        public List<BookModel> Searchbook(String Title, String Author)
        {
            return _bookrepository.SearchBook(Title,Author);
        }
    }
}
