using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public  class Subscription
    {
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }

        public Subscription(DateTime startdate, DateTime enddate, double price, double discount)
        {
            this.Discount = discount;
            this.Price = price;
            this.Start_Date = startdate;
            this.End_Date = enddate;
        }

    }
}
