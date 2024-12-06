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

        [HttpGet]
        public IActionResult Confirmation() {
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
            
            BookingLogic bookingLogic = new BookingLogic();

            bookingLogic.createBooking(foundCar, SelectedPeriod);

            return RedirectToAction("Confirmation");
            
        }
    }
}
        
