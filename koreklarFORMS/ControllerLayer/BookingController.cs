using koreklarFORMS.Services;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koreklarFORMS.ControllerLayer
{
    public class BookingController
    {
        readonly IBookingService _bookingService;

        public BookingController() 
        {
            _bookingService = new BookingService(); // ikke dependency injection
        }

        public void CreateBooking(Car car, int months)
        {
            Subscription subscription = new Subscription(0, months);
            Booking newBooking = new Booking("Active", car, subscription, "Yappesen");

            _bookingService.CreateBooking(newBooking);
        }
    }
}
