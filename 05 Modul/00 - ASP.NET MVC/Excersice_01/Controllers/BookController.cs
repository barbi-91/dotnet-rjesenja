using Excersice_01.Models;
using Microsoft.AspNetCore.Mvc;

namespace Excersice_01.Controllers
{
    public class BookController : Controller
    {
        //RUTA: book/
        //RUTA: book/index
        public IActionResult Index()
        {
            return View(DemoBookCollection());
        }

        public List<Book> DemoBookCollection()
        {
            List<Book> bookList = new List<Book>();
            bookList.Add(new Book { Author = "Antoine de Saint-Exupéry", Genre = "Basna", PublicationDate = new DateTime(1943,04,06), Title = "Mali princ"});
            bookList.Add(new Book { Author = "Ernest Hemingway", Genre = "Roman", PublicationDate = new DateTime(1952,11,23), Title = "Starac i more" });
            bookList.Add(new Book { Author = "Mark Twain", Genre = "Roman", PublicationDate = new DateTime(1876,05,30), Title = "Pustolovine Toma Sawyera" });
            bookList.Add(new Book { Author = "Mato Lovrak", Genre = "Roman", PublicationDate = new DateTime(1976,06,10), Title = "Vlak u snijegu" });

            return bookList;
        }
    }
}
