using KoreklarMVC.Models;
using KoreklarMVC.ServiceLayer;

namespace KoreklarMVC.BusinessLogicLayer {
    public class ShowCars {
        public List<Car> getAllCars() {
            CarsService carsService = new CarsService();

            return carsService.getAllCars();
        }

    }
}
