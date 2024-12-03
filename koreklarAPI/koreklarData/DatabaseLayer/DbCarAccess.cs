using Models.Models;
using Microsoft.Extensions.Configuration;
using Dapper;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;


namespace koreklarData.DatabaseLayer
{
    public class DbCarAccess : ICarAccess
    {
        public string? ConnectionString { get; set; }

        public DbCarAccess()
        {
            ConnectionString = "Data Source=hildur.ucn.dk;Initial Catalog=DMA-CSD-S232_10503078;Encrypt=False;User id=DMA-CSD-S232_10503078;Password=Password1!";
        }

        public Car GetCarByVin(string vin)
        {
            Car foundCar = null;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    foundCar = connection.QueryFirst<Car>("SELECT * FROM carIdentities FULL OUTER JOIN cars ON cars.id=carIdentities.car_id WHERE vin = @Vin", new { Vin = vin });
                    connection.Query("UPDATE carIdentities SET availability = 0 WHERE vin = @Vin");
                    Thread.Sleep(300000);
                    //transaction.Rollback();
                }
            }
                return foundCar;
        }

        public List<Car> GetCars()
        {
            List<Car> foundCars = new List<Car>();


            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlMapper.GridReader reader = connection.QueryMultiple("SELECT * FROM carIdentities FULL OUTER JOIN cars ON cars.id=carIdentities.car_id"))
                {
                    List<Car> cars = reader.Read<Car>().ToList();
                    foundCars.AddRange(cars); 
                }
            }

            return foundCars;
        }
        
        public void CreateCar(Car newCar)
        {

            

                //string query = "INSERT INTO cars (year, kilometers_driven, top_speed, price, image, condition, description, vin, color, fueltype, brand, model, type) " +
               //"VALUES (@Year, @KilometersDriven, @TopSpeed, @Price, @Image, @Condition, @Description, @Vin, @Color, @FuelType, @Brand, @Model, @Type)";

            using (SqlConnection connection = new SqlConnection(ConnectionString)) {
                string query = @"
                    BEGIN TRANSACTION;
                    INSERT INTO cars (brand, model, type)
                    VALUES (@Brand, @Model, @Type);

                    DECLARE @CarId INT;
                    SET @CarId = SCOPE_IDENTITY();

                    INSERT INTO carIdentities (year, color, fuel_type, kilometers_driven, top_speed, condition, vin, price, image, description, license_plate, availability, car_id)
                    VALUES (@Year, @Color, @FuelType, @KilometersDriven, @TopSpeed, @Condition, @Vin, @Price, @Image, @Description, @LicensePlate, @Availability, @CarId);

                    COMMIT TRANSACTION;
                ";
                connection.Execute(query, new
                {
                    Year = newCar.Year,
                    KilometersDriven = newCar.Kilometers_Driven,
                    TopSpeed = newCar.Top_Speed,
                    Price = newCar.Price,
                    Image = newCar.Image,
                    Condition = newCar.Condition,
                    Description = newCar.Description,
                    Vin = newCar.Vin,
                    Color = newCar.Color,
                    FuelType = newCar.Fuel_Type,
                    Brand = newCar.Brand,
                    Model = newCar.Model,
                    Type = newCar.Type,
                    LicensePlate = newCar.License_Plate,
                    Availability = 1


                });
            }

        }
    }
}
