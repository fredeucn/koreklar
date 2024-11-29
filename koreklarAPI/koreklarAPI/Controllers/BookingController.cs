using Microsoft.AspNetCore.Mvc;
using koreklarData.DatabaseLayer;
using koreklarAPI.Dtos;
using Models.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace koreklarAPI.Controllers
{
    public class BookingController : ControllerBase
    {
        private readonly IBookingAccess _bookingAccess;
        public BookingController(IBookingAccess BookingAccess)
        {
            _bookingAccess = BookingAccess;
        }

        [HttpPost, Route("api/bookings")]
        public void Create([FromBody] Booking newBooking) // Ændres til ReadCarDTO i refactoring
        {
            _bookingAccess.CreateBooking(newBooking);
        }
    }
}
