using KoreklarMVC.Models;
using System.Configuration;
using Microsoft.Extensions.DependencyInjection;
using static System.Net.WebRequestMethods;
using Newtonsoft.Json;

namespace KoreklarMVC.ServiceLayer {
    public class CarsService : ICarService {

        readonly IServiceConnection _lineServiceConnection;
        readonly string? _serviceBaseUrl = "https://localhost:7228/api/cars";

        public CarsService()
        {
            _lineServiceConnection = new ServiceConnection(_serviceBaseUrl);
        }
        public async Task<List<Car>> getAllCars() {
            List<Car> cars = new List<Car>();

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
                       /* if (hasValidId)
                        {
                            Car? foundCar = JsonConvert.DeserializeObject<Car>(content);
                            if (foundCar != null)
                            {
                                cars = new List<Car>() { foundCar };
                            }
                        }*/
                        
                        
                         cars = JsonConvert.DeserializeObject<List<Car>>(content);
                        
                    }
                    else
                    {
                        if (wasResponse && serviceResponse.StatusCode == System.Net.HttpStatusCode.NotFound)
                        {
                            cars = new List<Car>();
                        }
                        else
                        {
                            cars = null;
                        }
                    }
                }
                catch
                {
                    cars = null;
                }
            }

            return cars;
        }
        
    }
}
