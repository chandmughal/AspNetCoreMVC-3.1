using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webgentle.BookStore.Models;

namespace Webgentle.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
           return Datasource();
        }
        //
        public BookModel GetBook(int ID)
        {
            return Datasource().Where(x => x.Id == ID).FirstOrDefault() ;
        }
        //
        public List<BookModel> SearchBook(String Title,String Author)
        {
            return Datasource().Where(x => x.Title.Contains(Title) || x.Author.Contains(Author)).ToList();
        }

        private List<BookModel> Datasource()
        {
            return new List<BookModel>()
         {
             new BookModel(){ Id = 1 ,Title = "mvc",Author = "nitish"},
             new BookModel(){ Id = 2 ,Title = "java",Author = "nitish"},
             new BookModel(){ Id = 3 ,Title = "csharp",Author = "nitish"},
             new BookModel(){ Id = 4 ,Title = "core",Author = "nitish"},
             new BookModel(){ Id = 5 ,Title = "dotnet",Author = "nitish"}
         };

        }

    }
}
