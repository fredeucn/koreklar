using KoreklarMVC.Models;
using KoreklarMVC.ServiceLayer;

namespace KoreklarMVC.BusinessLogicLayer {
    public class BookingLogic {
        public void createBooking(Car foundCar) {
            BookingService bookingService = new BookingService();

            bookingService.CreateBooking(foundCar);
           
           
        }
    }
}
