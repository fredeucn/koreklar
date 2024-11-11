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
            ConnectionString = "data Source=localhost\\SQLEXPRESS; Initial Catalog=cars; integrated security=true; Encrypt=False;";
        }

        /*
        public Car? GetCar(string Vin)
        {

            Car? foundCar = null;

            // Prepare command
            string queryString = "SELECT * FROM cars WHERE vin = @Vin";

            // Get connection
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            using (SqlCommand readCommand = new SqlCommand(queryString, conn))
            {

                readCommand.Parameters.AddWithValue("Vin", Vin);

                if (conn != null)
                {
                    conn.Open();

                    SqlDataReader lineReader = readCommand.ExecuteReader();
                    List<Car> foundCar1 = GetCarObjects(lineReader);
                    if (foundCar1 != null)
                    {
                        if (foundCar1.Count > 0)
                        {
                            foundCar = foundCar1[0];
                        }
                        else
                        {
                            //foundLine = new Line { LineId = int.MinValue };
                        }
                    }
                }
            }
            return foundCar;
        }
        */

        public Car GetCarByVin(string vin)
        {
            Car foundCar = null;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                foundCar = connection.QueryFirst<Car>("SELECT * FROM cars WHERE vin = @Vin", new { Vin = vin });
            }

            return foundCar;
        }

        public List<Car> GetCars()
        {
            List<Car> foundCars = new List<Car>();


            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlMapper.GridReader reader = connection.QueryMultiple("SELECT * FROM cars"))
                {
                    List<Car> cars = reader.Read<Car>().ToList();
                    foundCars.AddRange(cars); 
                }
            }

            return foundCars;
        }

        /*
        private List<Car> GetCarObjects(SqlDataReader lineReader)
        {
            List<Car> foundCars = new List<Car>();
            Car tempCar;

            int tempId; int tempYear; int tempKilometersDriven; int tempTopSpeed;
            double tempPrice; decimal priceToConvert; string tempBrand; string tempModel; string tempType;
            string tempImage; string tempCondition; string tempDescription;
            string tempVin; string tempColor; string tempFuelType;

            while (lineReader.Read())
            {
                //tempId = lineReader.GetInt32(lineReader.GetOrdinal("id"));
                tempYear = lineReader.GetInt32(lineReader.GetOrdinal("year"));
                tempKilometersDriven = lineReader.GetInt32(lineReader.GetOrdinal("kilometers_driven"));
                tempTopSpeed = lineReader.GetInt32(lineReader.GetOrdinal("top_speed"));
                priceToConvert = lineReader.GetDecimal(lineReader.GetOrdinal("price"));
                tempPrice = Convert.ToDouble(priceToConvert);
                tempBrand = lineReader.GetString(lineReader.GetOrdinal("brand"));
                tempModel = lineReader.GetString(lineReader.GetOrdinal("model"));
                tempType = lineReader.GetString(lineReader.GetOrdinal("type"));
                tempImage = lineReader.GetString(lineReader.GetOrdinal("image"));
                tempCondition = lineReader.GetString(lineReader.GetOrdinal("condition"));
                tempDescription = lineReader.GetString(lineReader.GetOrdinal("description"));
                tempVin = lineReader.GetString(lineReader.GetOrdinal("vin"));
                tempColor = lineReader.GetString(lineReader.GetOrdinal("color"));
                tempFuelType = lineReader.GetString(lineReader.GetOrdinal("fueltype"));

                Car tempCar2 = new Car(tempYear, tempKilometersDriven, tempTopSpeed, tempPrice,
                    tempBrand, tempModel, tempType, tempImage, tempCondition, tempDescription, tempVin,
                    tempColor, tempFuelType);
                


                foundCars.Add(tempCar2);
            }
            return foundCars;
        }
        */
    }
}
