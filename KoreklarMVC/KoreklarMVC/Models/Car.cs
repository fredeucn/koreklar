namespace KoreklarMVC.Models {
    public class Car {
        public int Year { get; set; }
        public int Kilometers_Driven { get; set; }
        public int Top_Speed { get; set; }
        public double Price { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Condition { get; set; }
        public string Vin { get; set; }
        public string Color { get; set; }
        public string FuelType { get; set; }

        public Car()
        {

        }

        public Car(string Description)
        {
            this.Description = Description;
        }

        public Car(int Year, int KilometersDriven, int TopSpeed, double Price, string Brand,
                    string Model, string Type, string Image, string Condition, string Description, string Vin,
                    string Color, string FuelType)
        {
            this.Year = Year;
            this.Kilometers_Driven = KilometersDriven;
            this.Top_Speed = TopSpeed;
            this.Price = Price;
            this.Brand = Brand;
            this.Model = Model;
            this.Type = Type;
            this.Image = Image;
            this.Condition = Condition;
            this.Description = Description;
            this.Vin = Vin;
            this.Color = Color;
            this.FuelType = FuelType;
        }

        public override bool Equals(object? obj)
        {
            if (obj is not Car other) return false;

            return Year == other.Year &&
                   Kilometers_Driven == other.Kilometers_Driven &&
                   Top_Speed == other.Top_Speed &&
                   Price == other.Price &&
                   Brand == other.Brand &&
                   Model == other.Model &&
                   Type == other.Type &&
                   Image == other.Image &&
                   Condition == other.Condition &&
                   Description == other.Description &&
                   Vin == other.Vin &&
                   Color == other.Color &&
                   FuelType == other.FuelType;
        }

        public string getName() {
            return $"{this.Brand} {this.Model} {this.Year}";
        }
    }
}
