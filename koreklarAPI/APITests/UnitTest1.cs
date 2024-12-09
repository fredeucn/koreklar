using System.ComponentModel.DataAnnotations;
using Models.Models;
using koreklarAPI.Dtos;
using koreklarData.DatabaseLayer;

namespace APITests
{
    [TestClass]
    public class UnitTest1
    {
        /*[TestMethod]
        public void TestGetCar()
        {
            ICarAccess carAccess = new DbCarAccess();

            Car testCar = new Car(2019, 25000, 250, 35000.00, null, "Good", "A fast and stylish ride.", "1FAFP45X4XF123456", "Blue", "Petrol", "Ford", "Mustang", "GT", "BC23456");

            Car? resultCarDto = carAccess.GetCarByVin("1FAFP45X4XF123456");

            Car resultCar = new Car(resultCarDto.Year, resultCarDto.Kilometers_Driven, resultCarDto.Top_Speed,
                                    resultCarDto.Price, null, resultCarDto.Condition, resultCarDto.Description,
                                    resultCarDto.Vin, resultCarDto.Color, resultCarDto.Fuel_Type, resultCarDto.Model, resultCarDto.Type,
                                    resultCarDto.Brand, resultCarDto.License_Plate
                );

            Assert.AreEqual(resultCar, testCar);
        }*/

        [TestMethod]
        public void TestCarList()
        {
            ICarAccess carAccess = new DbCarAccess();

            Car testCar = new Car(2019, 25000, 250, 35000.00, null, "Good", "A fast and stylish ride.", "1FAFP45X4XF123456", "Blue", "Petrol", "Ford", "Mustang", "GT", "BC23456", true);

            int targetListLength = 5;

            List<Car> resultList = carAccess.GetCars();

            Assert.IsTrue(resultList.Count >= targetListLength);
            Assert.AreEqual(resultList[0].Vin, testCar.Vin);
        }

        [TestMethod]
        public void TestCreateCar() {
            ICarAccess carAccess = new DbCarAccess();

            Car testCar = new Car(2019, 25000, 250, 35000.00, null, "Good", "A fast and stylish ride.", "1FAFP45X4XF123457", "Blue", "Petrol", "Ford", "Mustang", "GT", "BC23456", true);

            carAccess.CreateCar(testCar);

            Car? resultCarDto = carAccess.GetCarByVin(testCar.Vin);

            Car resultCar = new Car(resultCarDto.Year, resultCarDto.Kilometers_Driven, resultCarDto.Top_Speed,
                                    resultCarDto.Price, resultCarDto.Image, resultCarDto.Condition, resultCarDto.Description,
                                    resultCarDto.Vin, resultCarDto.Color, resultCarDto.Fuel_Type,
                                    resultCarDto.Brand, resultCarDto.Model, resultCarDto.Type, resultCarDto.License_Plate, true
                );

            Assert.AreEqual(resultCar.Vin, testCar.Vin);
        }

        [TestMethod]
        public void TestCreateBooking()
        {
            IBookingAccess bookingAccess = new DbBookingAccess();

            Car testCar = new Car(2019, 25000, 250, 35000.00, null, "Good", "A fast and stylish ride.", "1FAFP45X4XF123457", "Blue", "Petrol", "Ford", "Mustang", "GT", "BC23456", true);

            Subscription testSubscription = new Subscription(5, 2);
            
            Booking testBooking = new Booking("Ongoing", testCar, testSubscription, "Lars");

            bookingAccess.CreateBooking(testBooking);
        }

        [TestMethod]
        public async Task TestCreateMultipleBooking()
        {
            // Initialize the booking access layer (use dependency injection or mock if needed)
            IBookingAccess bookingAccess = new DbBookingAccess();

            // Test data setup
            Car testCar = new Car(2019, 25000, 250, 3500.00, null, "Good", "A fast and stylish ride.", "WBS3C9C07MD58234", "Blue", "Petrol", "Ford", "Mustang", "GT", "BC23456", true);
            Subscription testSubscription = new Subscription(5, 3);
            Booking testBooking = new Booking("Ongoing", testCar, testSubscription, "Lars");

            // Create a list to hold the tasks
            List<Task> tasks = new List<Task>();

            // Launch 100 tasks to create bookings concurrently
            for (int i = 0; i < 100; i++)
            {
                tasks.Add(Task.Run(async () => bookingAccess.CreateBooking(testBooking)));
            }

            // Wait for all tasks to complete
            await Task.WhenAll(tasks);

            // Assert or validate any required outcome
            // In this case, we validate that 100 tasks were created and awaited
            Assert.AreEqual(100, tasks.Count);
        }
    }
}