using Microsoft.AspNetCore.Mvc;
using KoreklarMVC.Models;
using KoreklarMVC.BusinessLogicLayer;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Net.Http.Headers;

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

        [Route("cars/CarDetails/{vin}")]
        public async Task<IActionResult> CarDetails(string? vin) {
            if (string.IsNullOrEmpty(vin))
            {
                return BadRequest("VIN is required");
            }

            CarLogic cars = new CarLogic();

            List<Car> carsList = await cars.GetAllCars();

            Car? car = carsList.FirstOrDefault(c => c.Vin?.Equals(vin, StringComparison.OrdinalIgnoreCase) == true);

            if (car == null)
            {
                return NotFound("Car not found");
            }

            return View(car);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Car car, [FromForm] IFormFile ImageFile) {
            CarLogic cars = new CarLogic();

            cars.createCar(car, ImageFile);

            
            return RedirectToAction("Index");

        }

        new public ActionResult NotFound() {
            return View(); 
        }
    }
}
