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
           // car.ImageFile = null;

            string baseUrl = "https://localhost:7228/api/cars";

            if (ImageFile != null)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await ImageFile.CopyToAsync(memoryStream);
                    byte[] imageData = memoryStream.ToArray(); 
                    car.Image = imageData; 
                }
            }

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // Send the car object as a POST request to the API
                HttpResponseMessage response = await client.PostAsJsonAsync("", car);

                if (response.IsSuccessStatusCode)
                {
                    // Redirect to the Index page after successful creation
                    return RedirectToAction("Index");
                }
                else
                {
                    // Handle API errors
                    ModelState.AddModelError("", "Failed to create car in the database.");
                    return View(car);
                }


                /* if (ModelState.IsValid)
             {
                 cars.createCar(car);
                 Console.WriteLine("I made it");

                 return RedirectToAction("Index");
             }

             if (!ModelState.IsValid)
             {
                 foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                 {
                     Console.WriteLine(error.ErrorMessage);
                 }
             }*/


                //return View(car);

            }

        }

        new public ActionResult NotFound() {
            return View(); 
        }
    }
}
