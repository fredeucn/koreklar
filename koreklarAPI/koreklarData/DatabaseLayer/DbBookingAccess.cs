using Dapper;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koreklarData.DatabaseLayer
{
    public class DbBookingAccess : IBookingAccess
    {
        public string? ConnectionString { get; set; }

        public DbBookingAccess()
        {
            ConnectionString = "Data Source=hildur.ucn.dk;Initial Catalog=DMA-CSD-S232_10503078;Encrypt=False;User id=DMA-CSD-S232_10503078;Password=Password1!";
        }

        public void CreateBooking(Booking newBooking)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = @"
                    BEGIN TRANSACTION;
                    INSERT INTO subscriptions (start_date, end_date, price, discount)
                    VALUES (@StartDate, @EndDate, @Price, @Discount);

                    DECLARE @SubscriptionId INT;
                    SET @SubscriptionId = SCOPE_IDENTITY();

                    INSERT INTO bookings (status, total_Price, subscription_Id, vin)
                    VALUES (@Status, @TotalPrice, @SubscriptionId, @Vin);

                    UPDATE carIdentities SET availability = @Availability WHERE vin = @Vin;

                    COMMIT TRANSACTION;
                ";

                connection.Execute(query, new
                {
                    Status = newBooking.Status,
                    TotalPrice = newBooking.Total_Price,
                    Vin = newBooking.RegisteredCar.Vin,
                    StartDate = newBooking.ChosenSubscription.Start_Date,
                    EndDate = newBooking.ChosenSubscription.End_Date,
                    Price = newBooking.ChosenSubscription.Price,
                    Discount = newBooking.ChosenSubscription.Discount,
                    Availability = 0
                });
            }
        }
    } 
}
