using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Models;

namespace koreklarData.DatabaseLayer
{
    public interface ICarAccess
    {
        Car? GetCar(string vin);
    }
}
