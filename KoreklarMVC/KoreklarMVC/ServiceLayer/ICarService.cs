using KoreklarMVC.Models;

namespace KoreklarMVC.ServiceLayer
{
    public interface ICarService
    {
        Task<List<Car>?> GetAllCars();

        void CreateCar(Car newCar, IFormFile ImageFile);
    }
}
