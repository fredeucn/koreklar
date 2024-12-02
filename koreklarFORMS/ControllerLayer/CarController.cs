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

        public async Task<List<Car>> GetAllCars()
        {
            CarService carService = new CarService();
            List<Car> cars = new List<Car>();

            cars = await carService.GetAllCars();

            return cars;
        }

        public void CreateCar(Car newCar)
        {
            CarService carService = new CarService();

            carService.CreateCar(newCar);
        }
    }
}
