using Exercise_2.Models;

namespace Exercise_2.Repository
{
    public class DemoClass
    {
        private static List<Car> _cars;

        public DemoClass()
        {
            if (_cars == null)
            {
                _cars = new List<Car>();
                DataCar();
            }
        }

        public void DataCar()
        {
            _cars = new List<Car>
            { 
            new Car {Id = 11, Make = "Toyota", Model = "Corolla", Year = 2020, Color = "Gray", Price = 25000},
            new Car {Id = 12, Make = "Honda", Model = "Civic", Year = 2021, Color = "Red", Price = 28000},
            new Car {Id = 15, Make = "Ford", Model = "F-150", Year = 2018, Color = "Blue", Price = 35000},
            new Car {Id = 16, Make = "BMW", Model = "X5", Year = 2019, Color = "Black", Price = 50000},
            new Car {Id = 20, Make = "Chevrolet", Model = "Camaro", Year = 2016, Color = "Yellow", Price = 42000},
            };
        }

        //Metoda za dohvacanje liste i svih podataka uz njoj
        public List<Car> GetData()
        {
            return _cars;
        }

        // Metoda za kreiranje novog podatka
        public void CreateData(Car createCar)
        {
            _cars.Add(createCar);
        }

        //metoda za dohvacanje specificnog podatka
        public Car GetById(int id)
        {
            var carById = _cars.FirstOrDefault(x => x.Id == id);
            
            return carById;
        }

        internal void UpdateCar(Car carObj)
        {
            var carToUpdate = _cars.FirstOrDefault(c => c.Id == carObj.Id);

            if (carToUpdate != null)
            {
                carToUpdate.Price = carObj.Price;
                carToUpdate.Year = carObj.Year;
                carToUpdate.Make = carObj.Make;
                carToUpdate.Model = carObj.Model;
                carToUpdate.Color = carObj.Color;
            }
        }

        internal void DeleteCar(int id)
        {
            Car deleteCar = _cars.FirstOrDefault(c => c.Id == id);
            _cars.Remove(deleteCar);
        }
    }
}
