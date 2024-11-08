using Microsoft.AspNetCore.Mvc;
using koreklarData.DatabaseLayer;
using koreklarAPI.Dtos;
using Models.Models;

namespace koreklarAPI.Controllers
{
    public class CarController
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
            Car? publicCar = _carAccess.GetCar(vin);
            // Evaluate
            if (publicCar != null)
            {
               if (publicCar.Year > 0)
                {
                    foundReturn = new StatusCodeResult(200);
                } else {
                    foundReturn = new StatusCodeResult(500);
                }
            }
            else
            {
                foundReturn = new StatusCodeResult(500);    // Internal server error
            }
            // Return result
            return foundReturn;
        }

    }
}
