using KoreklarMVC.Models;

namespace KoreklarMVC.ServiceLayer {
    public class CarsService {
        public List<Car> getAllCars() {
            List<Car> cars = new List<Car>();
            Car car1 = new Car {
                Id = 1,
                Description = "A compact and fuel-efficient city car",
                Color = "Red",
                Year = 2019,
                FuelType = "Petrol",
                KilometersDriven = 15000,
                TopSpeed = 180,
                Condition = "Used",
                Vin = "1HGCM82633A123456",
                Price = 15000.00,
                LicensePlate = "AB123CD",
                Brand = "Toyota",
                Model = "Corolla",
                Type = "Sedan",
                image = "corolla_image.jpg"
            };

            Car car2 = new Car {
                Id = 2,
                Description = "A powerful SUV with off-road capabilities",
                Color = "Black",
                Year = 2022,
                FuelType = "Diesel",
                KilometersDriven = 5000,
                TopSpeed = 200,
                Condition = "New",
                Vin = "5YJ3E1EA5JF123456",
                Price = 45000.00,
                LicensePlate = "XY456ZW",
                Brand = "Jeep",
                Model = "Wrangler",
                Type = "SUV",
                image = "wrangler_image.jpg"
            };

            Car car3 = new Car {
                Id = 3,
                Description = "A luxury electric vehicle with cutting-edge features",
                Color = "White",
                Year = 2021,
                FuelType = "Electric",
                KilometersDriven = 10000,
                TopSpeed = 250,
                Condition = "Certified Pre-Owned",
                Vin = "3MW5R1J05K8A123456",
                Price = 60000.00,
                LicensePlate = "EV789GH",
                Brand = "Tesla",
                Model = "Model S",
                Type = "Sedan",
                image = "model_s_image.jpg"
            };

            cars.Add(car1);
            cars.Add(car2);
            cars.Add(car3);

            return cars;
        }
        
    }
}
