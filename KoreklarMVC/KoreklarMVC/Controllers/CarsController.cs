using Microsoft.AspNetCore.Mvc;
using KoreklarMVC.Models;
using KoreklarMVC.BusinessLogicLayer;

namespace KoreklarMVC.Controllers {
    public class CarsController : Controller {
        public async Task<IActionResult> Index() {
            CarLogic cars = new CarLogic();
            List<Car> carsList = await cars.GetAllCars();

            if (carsList != null)
            {
                ViewData["cars"] = carsList;
            } else
            {
                ViewData["cars"] = new List<Car>();
            }

            return View();
        }

        /*public IActionResult CarDetails(int? id) {
            ShowCars cars = new ShowCars();

            var car = cars.getAllCars().FirstOrDefault(c => c.Id == id);
            
            return View(car);
        }
        */

        public IActionResult Create() {
            
            return View();
        }
    }
}
