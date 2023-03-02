using Exercise_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exercise_1.Controllers
{
    public class BookController : Controller
    {
        List<Book> listOfBook = new List<Book>();

        public IActionResult Index()
        {
            return View(GetDataBook());
        }


        public List<Book> GetDataBook()
        {
            listOfBook = new List<Book>
            {
                new Book { Author = "Antoine de Saint-Exupéry", Genre = "Basna", PublicationDate = 1943 - 04 - 06, Title = "Mali princ"},
                new Book { Author = "Ernest Hemingway", Genre = "Roman", PublicationDate = 1952 - 11 - 23, Title = "Starac i more" },
                new Book { Author = "Mark Twain", Genre = "Roman", PublicationDate = 1876 - 05 - 30, Title = "Pustolovine Toma Sawyera" },
                new Book { Author = "Mato Lovrak", Genre = "Roman", PublicationDate = 1976 - 06 - 10, Title = "Vlak u snijegu" }
            };
        
            return listOfBook;
        }
    }
}
