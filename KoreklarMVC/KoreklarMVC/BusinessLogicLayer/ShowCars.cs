using KoreklarMVC.Models;
using KoreklarMVC.ServiceLayer;

namespace KoreklarMVC.BusinessLogicLayer {
    public class ShowCars {
        public async Task<List<Car>> getAllCars() {
            CarsService carsService = new CarsService();

            List<Car> cars = await carsService.getAllCars();

            return cars;
        }

    }
}
