using KoreklarMVC.Models;

namespace KoreklarMVC.ServiceLayer
{
    public interface ICarService
    {
        Task<List<Car>?> getAllCars();
    }
}
