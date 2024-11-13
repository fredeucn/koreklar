using KoreklarMVC.Models;
using KoreklarMVC.BusinessLogicLayer;

namespace MVCTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async void TestCarList()
        {
            ShowCars showCars = new ShowCars();

            Car testCar = new Car(2019, 15000, 220, 25000.00, "Toyota", "Yaris", "LT", "image_url_1.jpg", "Excellent", "Sporty red sedan with low mileage and excellent condition.", "1HGCM82633A123456", "Red", "Petrol");

            int targetListLength = 10;

            List<Car> resultList = await showCars.GetAllCars();

            Assert.AreEqual(resultList.Count, targetListLength);
            Assert.AreEqual(resultList[0], testCar);
        }
    }
}