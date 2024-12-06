using KoreklarMVC.Models;
using System.Linq.Expressions;
using System.Net.Http.Headers;

namespace KoreklarMVC.ServiceLayer {
    public class BookingService : IBookingService {

        readonly IServiceConnection _bookingServiceConnection;
        readonly string? _serviceBaseUrl = "https://localhost:7228/api/bookings";

        public BookingService() {
            _bookingServiceConnection = new ServiceConnection(_serviceBaseUrl);
        }

        public async void CreateBooking(Car foundCar, string selectedPeriod) {
            int choice = 1;
            System.Diagnostics.Debug.WriteLine(selectedPeriod);
            switch (selectedPeriod) {
                case "1Month":
                    choice = 1;
                    break;
                case "3Months":
                    choice = 2;
                    break;
                case "6Months":
                    choice = 3;
                    break;
                default:
                    // code block
                    break;
            }

            Subscription newSubscription = new Subscription(0, choice);
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
