using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Booking
    {
        public string Status { get; set; }
        public double Total_Price { get; set; }
        public Car RegisteredCar { get; set; }
        public Subscription ChosenSubscription { get; set; }
        public string Customer {  get; set; }

        public Booking()
        {
           
        }

        public Booking(string Status, Car RegisteredCar, Subscription ChosenSubscription, string Customer)
        {
            this.ChosenSubscription = ChosenSubscription;
            this.RegisteredCar = RegisteredCar;
            this.Status = Status;
            this.Customer = Customer;
            this.Total_Price = GetTotalPrice();
        }
        
        public double GetTotalPrice()
        {
            double price = RegisteredCar.Price * ChosenSubscription.months + ChosenSubscription.Price;

            if(ChosenSubscription.Discount > 0)
            {
                double discountValue = ChosenSubscription.Discount / 100;
                price = price * discountValue;
            }

            return Math.Ceiling(price);
        }
    }
}
