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
        public IActionResult Create([FromBody] Booking newBooking) // Ændres til ReadCarDTO i refactoring
        {
            if (newBooking == null)
            {
                return BadRequest("Booking object is null.");
            }

            _bookingAccess.CreateBooking(newBooking);
            return Ok();
        }
    }
}
