using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Subscription
    {
        public int months { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
       
        public Subscription() { }

        public Subscription(double discount, int months)
        {
            this.months = months;
            this.Discount = discount;
            this.Price = CalculatePrice(months);
            this.Start_Date = DateTime.Now;
            this.End_Date = CalculateEndDate(months);
            
        }

        public double CalculatePrice(int months)
        {
            switch (months) { 
                case 1:
                    return 200;
                case 3:
                    return 500;
                case 6:
                    return 800;
            }

            return 0;
        }

        public DateTime CalculateEndDate(int months)
        {
            return DateTime.Now.AddMonths(months);
        }

    }
}
