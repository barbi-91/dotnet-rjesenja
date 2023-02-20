using Excersice_02.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using System.Diagnostics.Metrics;
using System.Drawing;

namespace Excersice_02.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View(CarData());
        }
        public IActionResult FilterByYear()
        {
            //In the "FilterByYear" action, retrieve a list of cars older then 2020, and pass it to the corresponding view to display
            List<Car> carOlderThen2020 = CarData().Where(c => c.Year > 2020).ToList();

            return View(carOlderThen2020);
        }
        public IActionResult FilterByColor()
        {
            List<Car> carLetter = CarData().Where(c => c.Color.Contains("L")).ToList();
            //n the "FilterByColor" action, retrieve a list of cars where color contains letter "L", and pass it to the corresponding view to display.
            return View(carLetter);
        }

        public List<Car> CarData()
        {
            List<Car> demoCarData = new List<Car>
            {
                new Car { Make = "Toyota", Model = "Corolla", Year = 2020, Color = "Gray", Price = 25000 },
                new Car { Make = "Honda", Model = "Civic", Year = 2021, Color = "Red", Price = 28000 },
                new Car { Make = "Ford", Model = "F - 150", Year = 2018, Color = "Blue", Price = 35000 },
                new Car { Make = "BMW", Model = "X5", Year = 2019, Color = "Black", Price = 50000 },
                new Car { Make = "Chevrolet", Model = "Camaro", Year = 2016, Color = "Yellow", Price = 42000 }

            };
            return demoCarData;
        }
    }

}
