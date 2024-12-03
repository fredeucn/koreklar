using System.Diagnostics;

namespace KoreklarMVC.Models {
    public class Booking {
        public string Status { get; set; }
        public double Total_Price { get; set; }
        public Car RegisteredCar { get; set; }
        public Subscription ChosenSubscription { get; set; }
        public string Customer { get; set; }

        public Booking() { 
        
        }

        public Booking(string Status, Car RegisteredCar, Subscription ChosenSubscription, string Customer) {
            this.ChosenSubscription = ChosenSubscription;
            this.RegisteredCar = RegisteredCar;
            this.Status = Status;
            this.Customer = Customer;
            this.Total_Price = GetTotalPrice();
        }

        public double GetTotalPrice() {
            if (ChosenSubscription.Discount > 0) {
                double discountValue = ChosenSubscription.Discount / 100;

                double price = Math.Round((RegisteredCar.Price + ChosenSubscription.Price) - (RegisteredCar.Price + ChosenSubscription.Price) * discountValue, 2);
                System.Diagnostics.Debug.WriteLine(price);
                return price;
            } else {
                double price = RegisteredCar.Price + ChosenSubscription.Price;
                price = Math.Round(price, 2);
                Debug.WriteLine(price);
                return price;
            }
        }
    }

}
