using Excersice_04.Models;
using Microsoft.AspNetCore.Mvc;

namespace Excersice_04.Controllers
{
    public class BeerController : Controller
    {
        public IActionResult Index()
        {
            return View(BeerData());
        }

        public IActionResult FilterByPercentage()
        {
            List<Beer> filteredByAlcoholPercentage= BeerData().Where(b => b.AlcoholPercentage > 5).ToList();

            return View(filteredByAlcoholPercentage);
        }

        public IActionResult GroupByCountry()
        {
            var groupByCountry = BeerData().GroupBy(b => b.Country).ToList();
            return View(groupByCountry);
        }

        public IActionResult FilterByName()
        {
            var filteredByLetterS = BeerData().Where(b => b.Name.StartsWith("S")).ToList();
            return View(filteredByLetterS);
        }

        public IActionResult GroupByType()
        {
            var groupByType = BeerData().GroupBy(b => b.Type).ToList();
            return View(groupByType);
        }

        public IEnumerable<Beer> BeerData()
        {
            IEnumerable<Beer> beers = new List<Beer>
            {
                new Beer { Name = "Heineken", Type = "Lager", AlcoholPercentage = 5, Brewery = "Heineken International", Country = "Netherlands" },
                new Beer { Name = "Guinness", Type = "Stout", AlcoholPercentage = 4.2, Brewery = "Guinness & Co.", Country = "Ireland" },
                new Beer { Name = "Corona", Type = "Lager", AlcoholPercentage = 4.5, Brewery = "Grupo Modelo", Country = "Mexico" },
                new Beer { Name = "Budweiser", Type = "Lager", AlcoholPercentage = 5, Brewery = "Anheuser-Busch InBev", Country = "United States" },
                new Beer { Name = "Stella Artois", Type = "Pilsner", AlcoholPercentage = 5, Brewery = "Anheuser-Busch InBev", Country = "Belgium" },
                new Beer { Name = "Sapporo", Type = "Lager", AlcoholPercentage = 5, Brewery = "Sapporo Breweries Ltd.", Country = "Japan" },
                new Beer { Name = "Peroni", Type = "Lager", AlcoholPercentage = 5.1, Brewery = "Peroni Brewery", Country = "Italy" },
                new Beer { Name = "Asahi", Type = "Lager", AlcoholPercentage = 5, Brewery = "Asahi Breweries Ltd.", Country = "Japan" },
                new Beer { Name = "Hoegaarden", Type = "Witbier", AlcoholPercentage = 4.9, Brewery = "InBev Belgium", Country = "Belgium" },
                new Beer { Name = "Tsingtao", Type = "Lager", AlcoholPercentage = 4.7, Brewery = "Tsingtao Brewery Co. Ltd.", Country = "China" }
            };

            return beers;
        }
    }
}
