using Microsoft.AspNetCore.Mvc;
using KoreklarMVC.BusinessLogicLayer;

namespace KoreklarMVC.Controllers {
    public class CarsController : Controller {
        public IActionResult Index() {
            ShowCars cars = new ShowCars();
            ViewData["cars"] = cars.getAllCars();
            return View();
        }
    }
}
