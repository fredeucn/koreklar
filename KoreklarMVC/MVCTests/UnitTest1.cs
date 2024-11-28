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

            Car testCar = new Car(2019, 25000, 250, 35000.00, null, "Good", "A fast and stylish ride.", "1FAFP45X4XF123456", "Blue", "Petrol", "Ford", "Mustang", "GT", "BC23456");

            int targetListLength = 5;

            List<Car> resultList = await showCars.GetAllCars();

            Assert.IsTrue(resultList.Count >= targetListLength);
            Assert.AreEqual(resultList[0].Vin, testCar.Vin);
        }

        [TestMethod]
        public async void TestCreateCar() {
            CarLogic showCars = new CarLogic();

            Car testCar = new Car(2019, 25000, 250, 35000.00, null, "Good", "A fast and stylish ride.", "1FAFP45X4XF123457", "Blue", "Petrol", "Ford", "Mustang", "GT", "BC23456");

            List<Car> resultList = await showCars.GetAllCars();

            Assert.AreEqual(resultList[0].Vin, testCar.Vin);
        }
        [TestMethod]
        public void TestMVCInputs(Car car)
        {
            CarLogic showCars = new CarLogic();

            Car testCar = new Car(2019, 25000, 250, 35000.00, null, "Good", "A fast and stylish ride.", "1FAFP45X4XF123457", "Blue", "Petrol", "Ford", "Mustang", "GT", "BC23456");

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
            Assert.IsInstanceOfType(testCar.Fuel_Type, typeof(string));
            Assert.IsInstanceOfType(testCar.License_Plate, typeof(string));

        }
    }
}