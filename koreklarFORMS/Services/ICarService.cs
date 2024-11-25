using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koreklarFORMS.Services
{
    public interface ICarService
    {
        Task<List<Car>?> GetAllCars();
        void CreateCar(Car newCar);
    }
}
