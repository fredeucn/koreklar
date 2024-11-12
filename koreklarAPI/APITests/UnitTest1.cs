using System.ComponentModel.DataAnnotations;
using Models.Models;
using koreklarAPI.Dtos;
using koreklarData.DatabaseLayer;

namespace APITests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetCar()
        {
            ICarAccess carAccess = new DbCarAccess();

            Car testCar = new Car(2019, 15000, 220, 25000.00, "Toyota", "Yaris", "LT", "image_url_1.jpg", "Excellent", "Sporty red sedan with low mileage and excellent condition.", "1HGCM82633A123456", "Red", "Petrol");

            Car? resultCarDto = carAccess.GetCarByVin("1HGCM82633A123456");

            Car resultCar = new Car(resultCarDto.Year, resultCarDto.Kilometers_Driven, resultCarDto.Top_Speed,
                                    resultCarDto.Price, resultCarDto.Brand, resultCarDto.Model, resultCarDto.Type, 
                                    resultCarDto.Image, resultCarDto.Condition, resultCarDto.Description,
                                    resultCarDto.Vin, resultCarDto.Color, resultCarDto.FuelType
                );

            Assert.AreEqual(resultCar, testCar);
        }

        [TestMethod]
        public void TestCarList()
        {
            ICarAccess carAccess = new DbCarAccess();

            Car testCar = new Car(2019, 15000, 220, 25000.00, "image_url_1.jpg", "Excellent", "Sporty red sedan with low mileage and excellent condition.", "1HGCM82633A123456", "Red", "Petrol", "Toyotas", "Yariss", "LTs");

            int targetListLength = 10;

            List<Car> resultList = carAccess.GetCars();

            Assert.IsTrue(resultList.Count >= targetListLength);
            Assert.AreEqual(resultList[0].Vin, testCar.Vin);
        }

        [TestMethod]
        public void TestCreateCar() {
            ICarAccess carAccess = new DbCarAccess();
            
            Car testCar = new Car(2029, 15000, 220, 25000.00, "image_url_1.jpg", "Excellent", "Sporty red sedan with low mileage and excellent condition.", "1HGCM82633B123459",  "Red", "Petrol", "Toyotas", "Yariss", "LTs");
            
            carAccess.CreateCar(testCar);

            Car? resultCarDto = carAccess.GetCarByVin(testCar.Vin);

            Car resultCar = new Car(resultCarDto.Year, resultCarDto.Kilometers_Driven, resultCarDto.Top_Speed,
                                    resultCarDto.Price, resultCarDto.Image, resultCarDto.Condition, resultCarDto.Description,
                                    resultCarDto.Vin, resultCarDto.Color, resultCarDto.FuelType,
                                    resultCarDto.Brand, resultCarDto.Model, resultCarDto.Type
                );

            Assert.AreEqual(resultCar.Vin, testCar.Vin);
        }
    }
}