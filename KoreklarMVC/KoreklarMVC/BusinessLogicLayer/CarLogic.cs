﻿using KoreklarMVC.Models;
using KoreklarMVC.ServiceLayer;

namespace KoreklarMVC.BusinessLogicLayer {
    public class CarLogic {
        public async Task<List<Car>> GetAllCars() {
            CarsService carsService = new CarsService();

            List<Car> cars = await carsService.GetAllCars();

            return cars;
        }

        public void createCar(Car newCar) {
            CarsService carsService = new CarsService();

            carsService.CreateCar(newCar);
            Console.WriteLine("CarLogic Check");
        }

        public async Task<Car> GetCarByVin(string vin)
        {
            CarsService carsService = new CarsService();
            Car car = await carsService.GetCarByVin(vin);
            return car;
        }

    }
}
