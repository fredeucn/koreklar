namespace KoreklarMVC.Models {
   
        public class Subscription {
            public DateTime Start_Date { get; set; }
            public DateTime End_Date { get; set; }
            public double Price { get; set; }
            public double Discount { get; set; }


            public Subscription() { }

            public Subscription(double discount, int choice) {
                this.Discount = discount;
                this.Price = CalculatePrice(choice);
                this.Start_Date = DateTime.Now;
                this.End_Date = CalculateEndDate(choice);

            }

            public double CalculatePrice(int choice) {
                switch (choice) {
                    case 1:
                        return 200;
                    case 2:
                        return 500;
                    case 3:
                        return 800;
                }

                return 0;
            }

            public DateTime CalculateEndDate(int choice) {
                switch (choice) {
                    case 1:
                        return DateTime.Now.AddMonths(1);
                    case 2:
                        return DateTime.Now.AddMonths(3);
                    case 3:
                        return DateTime.Now.AddMonths(6);
                }

                return DateTime.Now;
            }

        }
    
}
