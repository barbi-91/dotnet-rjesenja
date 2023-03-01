using Exercise_2.Models;
using Exercise_2.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exercise_2.Controllers
{
    public class CarController : Controller
    {
        DemoClass _dataCar;

        public CarController()
        {
            _dataCar = new DemoClass();
        }





        // GET: CarController
        public ActionResult Index()
        {
            List<Car> carsList = _dataCar.GetData().OrderBy(a =>a.Id).ToList();
            return View(carsList);
        }




        // GET: CarController/Details/5
        public ActionResult Details(int id)
        {
            var car = _dataCar.GetById(id);
            return View(car);
        }




        // GET: CarController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CarController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create (Car createCar)
        {
            try
            {
                _dataCar.CreateData(createCar);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }





        // GET: CarController/Edit/5
        public ActionResult Edit(int id)
        {
            Car carbyId = _dataCar.GetById(id);
            return View(carbyId);
        }

        // POST: CarController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Car carObj)
        {
            try
            {
                _dataCar.UpdateCar(carObj);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CarController/Delete/5
        public ActionResult Delete(int id)
        {
            Car car = _dataCar.GetById(id);
            return View(car);
        }

        // POST: CarController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _dataCar.DeleteCar(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
