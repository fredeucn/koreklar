using KoreklarMVC.Models;
using System.Net.Http.Headers;

namespace KoreklarMVC.ServiceLayer {
    public class BookingService : IBookingService {

        readonly IServiceConnection _bookingServiceConnection;
        readonly string? _serviceBaseUrl = "https://localhost:7228/api/bookings";

        public BookingService() {
            _bookingServiceConnection = new ServiceConnection(_serviceBaseUrl);
        }

        public async void CreateBooking(Car foundCar) {

            Subscription newSubscription = new Subscription(0, 1);
            Booking newBooking = new Booking("Active", foundCar, newSubscription, "Børge");

            using (HttpClient client = new HttpClient()) {
                client.BaseAddress = new Uri(_serviceBaseUrl);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // Send the car object as a POST request to the API
                HttpResponseMessage response = await client.PostAsJsonAsync("", newBooking);

                
            }

        }
    }
}
