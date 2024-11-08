using Models.Models;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("koreklarAPI")]

namespace koreklarData.DatabaseLayer
{
    public class DbCarAccess : ICarAccess
    {
        private enum SortParameter { none }
        private readonly SortParameter defaultSortParameter;

        public string? ConnectionString { get; set; }

        //public DbCarAccess(IConfiguration inConfiguration)
        //{
            // From configuration data get name of conn-string - and then fetch the conn-string
            //string? useConnectionString = inConfiguration["ConnectionStringToUse"];
            //ConnectionString = useConnectionString is not null ? inConfiguration.GetConnectionString(useConnectionString) : null;
            // Ensure some sorting
            //defaultSortParameter = SortParameter.none;
        //
        public DbCarAccess()
        {
            // From configuration data get name of conn-string - and then fetch the conn-string
            //? useConnectionString = inConfiguration["ConnectionStringToUse"];
            ConnectionString = "data Source=localhost\\SQLEXPRESS;Initial; Catalog=Cars; integrated security=true;Encrypt=False;";


        }
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

        private List<Car> GetCarObjects(SqlDataReader lineReader)
        {
            List<Car> foundCars = new List<Car>();
            Car tempCar;

            int tempId; int tempYear; int tempKilometersDriven; int tempTopSpeed;
            double tempPrice; string tempBrand; string tempModel; string tempType;
            string tempImage; string tempCondition; string tempDescription;
            string tempVin; string tempColor; string tempFuelType;

            while (lineReader.Read())
            {
                //tempId = lineReader.GetInt32(lineReader.GetOrdinal("id"));
                tempYear = lineReader.GetInt32(lineReader.GetOrdinal("year"));
                tempKilometersDriven = lineReader.GetInt32(lineReader.GetOrdinal("kilometers_driven"));
                tempTopSpeed = lineReader.GetInt32(lineReader.GetOrdinal("top_speed"));
                tempPrice = lineReader.GetDouble(lineReader.GetOrdinal("price"));
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
    }
}
