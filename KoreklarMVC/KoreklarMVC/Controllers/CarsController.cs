using Microsoft.AspNetCore.Mvc;
using KoreklarMVC.BusinessLogicLayer;

namespace KoreklarMVC.Controllers {
    public class CarsController : Controller {
        public IActionResult Index() {
            ShowCars cars = new ShowCars();
            ViewData["cars"] = cars.getAllCars();
            return View();
        }

        public IActionResult CarDetails(int? id) {
            ShowCars cars = new ShowCars();

            var car = cars.getAllCars().FirstOrDefault(c => c.Id == id);
            
            return View(car);
        }
    }
}
