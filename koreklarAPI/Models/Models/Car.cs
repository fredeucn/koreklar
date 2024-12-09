using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

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
        
        public byte[] Image { get; set; }
        public string Description { get; set; }
        public string Condition { get; set; }
        [Required(ErrorMessage = "VIN is required.")]
        [RegularExpression("^[A-HJ-NPR-Z0-9]{17}$", ErrorMessage = "VIN must be a 17-character mix of numbers and letters, excluding I, O, and Q.")]
        public string Vin { get; set; }
        public string Color { get; set; }
        public string Fuel_Type { get; set; }
        public string License_Plate { get; set; }

        public bool Availability { get; set; }

        public Car() { 

        }

        public Car(int Year, int KilometersDriven, int TopSpeed, double Price,  
                     byte[] Image, string Condition, string Description, string Vin, 
                    string Color, string FuelType, string Brand, string Model, string Type, string LicensePlate, bool Availability)
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
            this.Fuel_Type = FuelType;
            this.Brand = Brand;
            this.Model = Model;
            this.Type = Type;
            this.License_Plate = LicensePlate;
            this.Availability = Availability;
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
                   Fuel_Type == other.Fuel_Type;
        }

        public string GetName()
        {
            return $"{this.Brand} {this.Model} {this.Year}";
        }

        public override string ToString()
        {
            return $"{Year} {Kilometers_Driven} {Top_Speed} {Type} {Brand} {Model} {Image} {Condition} {Description} {Vin} {Color} {Fuel_Type} {License_Plate}";
        }
    }
}
