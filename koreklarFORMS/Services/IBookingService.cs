using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koreklarFORMS.Services
{
    public interface IBookingService
    {
        void CreateBooking(Booking newBooking);
    }
}
