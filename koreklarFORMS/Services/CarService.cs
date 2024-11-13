using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace koreklarFORMS.Services
{
    public class CarService : ICarService
    {

        readonly IServiceConnection _lineServiceConnection;
        readonly string? _serviceBaseUrl = "https://localhost:7228/api/cars";

        public CarService()
        {
            _lineServiceConnection = new ServiceConnection(_serviceBaseUrl);
        }
        public async Task<List<Car>> GetAllCars()
        {
            List<Car> cars = new List<Car>();

            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (message, cert, chain, sslErrors) => true
            };
            var httpClient = new HttpClient(handler)
            {
                Timeout = TimeSpan.FromSeconds(60)
            };

            _lineServiceConnection.UseUrl = _lineServiceConnection.BaseUrl;

            if (_lineServiceConnection != null)
            {
                try
                {
                    var serviceResponse = await _lineServiceConnection.CallServiceGet();
                    bool wasResponse = (serviceResponse != null);
                    if (wasResponse && serviceResponse.IsSuccessStatusCode)
                    {
                        var content = await serviceResponse.Content.ReadAsStringAsync();

                        if (!string.IsNullOrEmpty(content))
                        {
                            cars = JsonConvert.DeserializeObject<List<Car>>(content) ?? new List<Car>();
                            /*Car? foundCar = JsonConvert.DeserializeObject<Car>(content);
                            if (foundCar != null)
                            {
                                cars.Add(foundCar);
                            }*/


                        }


                    }
                    else
                    {
                        if (wasResponse && serviceResponse.StatusCode == System.Net.HttpStatusCode.NotFound)
                        {
                            cars = new List<Car>();
                        }
                        else
                        {
                            cars = new List<Car>();
                        }
                    }
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine($"HTTP Request error: {ex.Message}");
                    if (ex.InnerException != null)
                    {
                        Console.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                    }
                    cars = new List<Car>(); // Empty list on exception
                }
            }

            return cars;
        }

    }
}
