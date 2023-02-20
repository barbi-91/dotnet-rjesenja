using Excersice_03.Models;
using Microsoft.AspNetCore.Mvc;

namespace Excersice_03.Controllers
{
    public class FootballController : Controller
    {
        public IActionResult Index()
        {
            return View(FotballData());
        }


        public List<Football> FotballData()
        {
            List<Football> footballs = new List<Football>();

            footballs.Add(new Football { Country = "UK", Founded = 1878, Stadium = "Old Trafford", TeamName = "Manchester United F.C." });
            footballs.Add(new Football { Country = "Spain", Founded = 1899, Stadium = "Camp Nou", TeamName = "FC Barcelona" });
            footballs.Add(new Football { Country = "Spain", Founded = 1902, Stadium = "Stadion Santiago Bernabéu", TeamName = "Real Madrid C.F." });
            footballs.Add(new Football { Country = "UK", Founded = 1892, Stadium = " Anfield", TeamName = "Liverpool F.C." });
            footballs.Add(new Football { Country = "France", Founded = 1970, Stadium = "Parc des Princesd", TeamName = "Paris Saint-Germain FC." });

            return footballs;
        }
    }
}
