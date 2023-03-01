using Exercise_3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Exercise_3.Controllers
{
    public class FootballController : Controller
    {
        List<Football> listFootball = new List<Football>();

        public List<Football> GetData()
        {

            listFootball = new List<Football>();

            listFootball.Add(new Football { Id = 1, Country = "UK", Founded = 1878, Stadium = "Old Trafford", TeamName = "Manchester United F.C." });
            listFootball.Add(new Football { Id = 2, Country = "Spain", Founded = 1899, Stadium = "Camp Nou", TeamName = "FC Barcelona" });
            listFootball.Add(new Football { Id = 3, Country = "Spain", Founded = 1902, Stadium = "Stadion Santiago Bernabéu", TeamName = "Real Madrid C.F." });
            listFootball.Add(new Football { Id = 4, Country = "UK", Founded = 1892, Stadium = " Anfield", TeamName = "Liverpool F.C." });
            listFootball.Add(new Football { Id = 5, Country = "France", Founded = 1970, Stadium = "Parc des Princesd", TeamName = "Paris Saint-Germain FC." });

            return listFootball; 
        }

        // GET: FootballController
        public ActionResult Index()
        {
            return View(GetData());
        }


        // GET: FootballController/Details/5
        public ActionResult Details(int id)
        {
            Football? objectFooball = GetData().FirstOrDefault(x => x.Id == id);
            return View(objectFooball);
        }

       

        // GET: FootballController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FootballController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FootballController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FootballController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FootballController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FootballController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
