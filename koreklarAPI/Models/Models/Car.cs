namespace Models.Models
{
    public class Car
    {
        public int Year { get; set; }
        public int KilometersDriven { get; set; }
        public int TopSpeed { get; set; }
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

        public Car() { 

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
            this.KilometersDriven = KilometersDriven;
            this.TopSpeed = TopSpeed;
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
        
       
    }
}
