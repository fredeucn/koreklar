namespace KoreklarMVC.Models {
    public class Car {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public string FuelType { get; set; }
        public int KilometersDriven { get; set; }
        public int TopSpeed { get; set; }
        public string Condition { get; set; }
        public string Vin {  get; set; }
        public double Price {  get; set; }

        public string LicensePlate { get; set; }

        public string Brand {  get; set; }

        public string Model {  get; set; }

        public string Type {  get; set; }
        public string image {  get; set; }

        public string getName() {
            return $"{this.Brand} {this.Model} {this.Year}";
        }
    }
}
