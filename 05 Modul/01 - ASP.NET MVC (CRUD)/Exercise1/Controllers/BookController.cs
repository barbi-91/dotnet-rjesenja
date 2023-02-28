using Exercise1.Models;
using Exercise1.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exercise1.Controllers
{

    public class BookController : Controller
    {
        DemoBook _testData; //ovim objketom pristupama metodama u samoj klasi iz koje je objekt

        //Ctor- upotreba polja u bilo kojem scenariju
        public BookController()
        {
            //fild klase zapravo postaje novi objekt kojim dohvacamo sve iz repository foldera
            _testData= new DemoBook();
        }


        
        // GET: BookController -dohvaca listu preko objekta testData koji poziva metodu za ispis liste u svojoj klasi
        public ActionResult Index()
        {
           var books = _testData.GetBooks().OrderBy(b => b.Id).ToList();

            return View(books);
        }



        // GET: BookController/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                Book findBook = _testData.GetById(id);
                if (findBook != null)
                {
                return View(findBook);

                }
                return RedirectToAction("Index");
            }
            catch 
            {
                return RedirectToAction("Index");
            }
            
        }



        // GET: BookController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
         
        public ActionResult Create(Book newBookObj)
        {
            try
            {
                int lastID = _testData.GetBooks().OrderBy(x => x.Id).Last().Id;
                newBookObj.Id = lastID + 1;
                _testData.CreateBook(newBookObj);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }




        // GET: BookController/Edit/5
        public ActionResult Edit(int id)
        {
            var bookById = _testData.GetById(id);
            return View(bookById);
        }

        // POST: BookController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Book book)
        {
            try
            {
                _testData.UpdateData(id, book);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookController/Delete/5
        public ActionResult Delete(int id)
        {
            var deleteBook = _testData.GetById(id);
            return View(deleteBook);
        }

        // POST: BookController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Book deleteBook)
        {
            try
            {
                _testData.DeleteBook(deleteBook);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
