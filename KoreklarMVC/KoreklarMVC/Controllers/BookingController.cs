using KoreklarMVC.BusinessLogicLayer;
using KoreklarMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace KoreklarMVC.Controllers {
    public class BookingController : Controller {
        public IActionResult Index() {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(string CarVin, string SelectedPeriod) {
            CarLogic cars = new CarLogic();
            var allCars = await cars.GetAllCars();
            Car foundCar = null;
            
            if(allCars != null && allCars.Count > 0) {
                foreach (var car in allCars) {
                    if (CarVin == car.Vin) {
                        foundCar = car;
                    }
                }
            }
            // car.ImageFile = null;

            Subscription newSubscription = new Subscription(0, 1);
            Booking newBooking = new Booking("Active", foundCar, newSubscription, "Børge");  
            string baseUrl = "https://localhost:7228/api/bookings";


            using (HttpClient client = new HttpClient()) {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // Send the car object as a POST request to the API
                HttpResponseMessage response = await client.PostAsJsonAsync("", newBooking);

                if (response.IsSuccessStatusCode) {
                    // Redirect to the Index page after successful creation
                    return RedirectToAction("Index", "Cars");
                } else {
                    // Handle API errors
                    ModelState.AddModelError("", "Failed to create booking");
                    return RedirectToAction("Index");
                }
            }
        }
    }
}
        
