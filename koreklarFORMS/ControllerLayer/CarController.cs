using koreklarFORMS.Services;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koreklarFORMS.ControllerLayer
{
    public class CarController
    {

        readonly ICarService _carService;

        public CarController()
        {
            _carService = new CarService();
        }

        public async Task<List<Car>> GetAllCars()
        {
            List<Car> cars = new List<Car>();

            cars = await _carService.GetAllCars();

            return cars;
        }

        public void CreateCar(Car newCar)
        {
            _carService.CreateCar(newCar);
        }
    }
}
