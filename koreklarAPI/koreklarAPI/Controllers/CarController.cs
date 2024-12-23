﻿using Microsoft.AspNetCore.Mvc;
using koreklarData.DatabaseLayer;
using koreklarAPI.Dtos;
using Models.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace koreklarAPI.Controllers
{
    public class CarController : ControllerBase
    {

        private readonly ICarAccess _carAccess;
        // Constructor with Dependency Injection
        public CarController(ICarAccess carAccess)
        {
            _carAccess = carAccess;
        }

        [HttpGet, Route("cars/{vin}")]
        public ActionResult<Car> Get(string vin) // Ændres til ReadCarDTO i refactoring
        {
            ActionResult<Car> foundReturn;
            // Get data and convert
            Car? publicCar = _carAccess.GetCarByVin(vin);
            // Evaluate
            if (publicCar != null)
            {
               if (publicCar.Year > 0)
                {
                    foundReturn = Ok(publicCar);
                } else {
                    foundReturn = StatusCode(500, "Car data is invalid.");
                }
            }
            else
            {
                foundReturn = NotFound("Car not found.");    // Internal server error
            }
            // Return result
            return foundReturn;
        }

        [HttpGet, Route("api/cars")]
        public ActionResult<List<Car>> Get() // Ændres til ReadCarDTO i refactoring
        {
            ActionResult<List<Car>> foundReturn;
            // Get data and convert
            List<Car> publicCars = _carAccess.GetCars();
            // Evaluate
            if (publicCars != null)
            {
                if (publicCars[0].Year > 0)
                {
                    foundReturn = Ok(publicCars);
                }
                else
                {
                    foundReturn = StatusCode(500, "Car data is invalid.");
                }
            }
            else
            {
                foundReturn = NotFound("Car not found.");    // Internal server error
            }
            // Return result
            return foundReturn;
        }

        [HttpPost, Route("api/car")]
        public void Create(int year, string color, string fuelType, int kilometersDriven, int topSpeed, double price, string image, string condition, string description, string vin, string model, string brand, string type) // Ændres til ReadCarDTO i refactoring
       {

            Car newCar = new Car(year, kilometersDriven, topSpeed, price,  image, condition, description, vin,  color, fuelType, model, brand, type);
            _carAccess.CreateCar(newCar);


 
        }
    }
}
