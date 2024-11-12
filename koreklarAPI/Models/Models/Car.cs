using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Models
{
    public class Car
    {
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
        //public string LicensePlate { get; set; }

        public Car() { 

        }

        public Car(string Description)
        {
            this.Description = Description;
        }

        public Car(int Year, int KilometersDriven, int TopSpeed, double Price,  
                     string Image, string Condition, string Description, string Vin, 
                    string Color, string FuelType, string Brand, string Model, String Type)
        {
            this.Year = Year;
            this.Kilometers_Driven = KilometersDriven;
            this.Top_Speed = TopSpeed;
            this.Price = Price;
            this.Image = Image;
            this.Condition = Condition;
            this.Description = Description;
            this.Vin = Vin; 
            this.Color = Color;
            this.FuelType = FuelType;
            this.Brand = Brand;
            this.Model = Model;
            this.Type = Type;
            //this.LicensePlate = LicensePlate;
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
                   FuelType == other.FuelType
                   ;

        }
    }
}
