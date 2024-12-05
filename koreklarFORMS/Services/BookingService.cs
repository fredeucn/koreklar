using Models.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koreklarFORMS.Services
{
    public class BookingService : IBookingService
    {
        readonly IServiceConnection _bookingServiceConnection;
        readonly string? _serviceBaseUrl = "https://localhost:7228/api/bookings";

        public BookingService()
        {
            _bookingServiceConnection = new ServiceConnection(_serviceBaseUrl);
        }

        public void CreateBooking(Booking newBooking)
        {
            _bookingServiceConnection.UseUrl = _bookingServiceConnection.BaseUrl;

            if (_bookingServiceConnection != null)
            {
                try
                {
                    _bookingServiceConnection.CallServicePost(new StringContent(JsonConvert.SerializeObject(newBooking), Encoding.UTF8, "application/json"));

                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine($"HTTP Request error: {ex.Message}");
                    if (ex.InnerException != null)
                    {
                        Console.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                    }
                }
            }
        }
    }
}

