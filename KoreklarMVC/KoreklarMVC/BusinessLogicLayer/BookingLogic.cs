using KoreklarMVC.Models;
using KoreklarMVC.ServiceLayer;

namespace KoreklarMVC.BusinessLogicLayer {
    public class BookingLogic {
        public void createBooking(Car foundCar, string selectedPeriod) {
            BookingService bookingService = new BookingService();

            bookingService.CreateBooking(foundCar, selectedPeriod);

        }
    }
}
