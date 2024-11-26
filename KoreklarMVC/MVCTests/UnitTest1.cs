using KoreklarMVC.Models;
using KoreklarMVC.BusinessLogicLayer;

namespace MVCTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task TestCarList()
        {
            CarLogic showCars = new CarLogic();

            Car testCar = new Car(2019, 15000, 220, 25000.00, "Toyota", "Yaris", "LT", "image_url_1.jpg", "Excellent", "Sporty red sedan with low mileage and excellent condition.", "1HGCM82633A123456", "Red", "Petrol");

            int targetListLength = 10;

            List<Car> resultList = await showCars.GetAllCars();

            Assert.AreEqual(resultList.Count, targetListLength);
            Assert.AreEqual(resultList[0], testCar);
        }

        [TestMethod]
        public async void TestCreateCar() {
            CarLogic showCars = new CarLogic();

            Car testCar = new Car(2022, 15000, 220, 25000.00, "Toyota", "Yaris", "LT", "image_url_1.jpg", "Excellent", "Sporty red sedan with low mileage and excellent condition.", "1HGCM82633A123456", "Red", "Petrol");


            List<Car> resultList = await showCars.GetAllCars();

            Assert.AreEqual(resultList[0].Vin, testCar.Vin);
        }
        [TestMethod]
        public void TestMVCInputs(Car car)
        {
            CarLogic showCars = new CarLogic();

            Car testCar = new Car(2022, 15000, 220, 25000.00, "Toyota", "Yaris", "LT", null, "Excellent", "Sporty red sedan with low mileage and excellent condition.", "1HGCM82633A123456", "Red", "Petrol");

            // test if types are correct
            Assert.IsInstanceOfType(testCar.Year, typeof(int));
            Assert.IsInstanceOfType(testCar.Top_Speed, typeof(int));
            Assert.IsInstanceOfType(testCar.Price, typeof(double));
            Assert.IsInstanceOfType(testCar.Brand, typeof(string));
            Assert.IsInstanceOfType(testCar.Model, typeof(string));
            Assert.IsInstanceOfType(testCar.Type, typeof(string));
            Assert.IsInstanceOfType(testCar.Description, typeof(string));
            Assert.IsInstanceOfType(testCar.Condition, typeof(string));
            Assert.IsInstanceOfType(testCar.Vin, typeof(string));
            Assert.IsInstanceOfType(testCar.Color, typeof(string));
            Assert.IsInstanceOfType(testCar.FuelType, typeof(string));

        }
    }
}