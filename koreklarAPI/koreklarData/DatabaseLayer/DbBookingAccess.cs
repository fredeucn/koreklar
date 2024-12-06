using Dapper;
using Models.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
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
                connection.Open();
                //using (SqlTransaction transaction = connection.BeginTransaction())
                //{
                    
                        
                    string updateQuery = @"
                    SET TRANSACTION ISOLATION LEVEL REPEATABLE READ;
                    BEGIN TRANSACTION
                    SET NOCOUNT OFF

                    SELECT * FROM carIdentities WITH (ROWLOCK)
                    WHERE availability = 1 AND vin = @Vin

                    IF @@ROWCOUNT = 0
                    BEGIN
                        ROLLBACK TRANSACTION;
                        RETURN;
                    END

                    INSERT INTO subscriptions (start_date, end_date, price, discount)
                    VALUES (@StartDate, @EndDate, @Price, @Discount);

                    DECLARE @SubscriptionId INT;
                    SET @SubscriptionId = SCOPE_IDENTITY();

                    INSERT INTO bookings (status, total_Price, subscription_Id, vin)
                    VALUES (@Status, @TotalPrice, @SubscriptionId, @Vin);

                    UPDATE carIdentities SET availability = 0 WHERE vin = @Vin
                    COMMIT TRANSACTION"
                    ;
                    //try {

                        var rowsAffected = connection.Execute(updateQuery, new
                        {
                            Status = newBooking.Status,
                            TotalPrice = newBooking.Total_Price,
                            Vin = newBooking.RegisteredCar.Vin,
                            StartDate = newBooking.ChosenSubscription.Start_Date,
                            EndDate = newBooking.ChosenSubscription.End_Date,
                            Price = newBooking.ChosenSubscription.Price,
                            Discount = newBooking.ChosenSubscription.Discount,
                        });

                        Console.WriteLine($"Rows affected: {rowsAffected}");

                        /*connection.Execute(updateQuery, new
                        {
                            Status = newBooking.Status,
                            TotalPrice = newBooking.Total_Price,
                            Vin = newBooking.RegisteredCar.Vin,
                            StartDate = newBooking.ChosenSubscription.Start_Date,
                            EndDate = newBooking.ChosenSubscription.End_Date,
                            Price = newBooking.ChosenSubscription.Price,
                            Discount = newBooking.ChosenSubscription.Discount,
                            Availability = 0
                        }, transaction: transaction*/
                    //}

                    /*using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection, transaction))
                    {
                        updateCommand.Parameters.AddWithValue("@Vin", newBooking.RegisteredCar.Vin);
                        updateCommand.Parameters.AddWithValue("@Status", newBooking.Status);
                        updateCommand.Parameters.AddWithValue("@TotalPrice", newBooking.Total_Price);
                        updateCommand.Parameters.AddWithValue("@StartDate", newBooking.ChosenSubscription.Start_Date);
                        updateCommand.Parameters.AddWithValue("@EndDate", newBooking.ChosenSubscription.End_Date);
                        updateCommand.Parameters.AddWithValue("@Price", newBooking.ChosenSubscription.Price);
                        updateCommand.Parameters.AddWithValue("@Discount", newBooking.ChosenSubscription.Discount);
                        updateCommand.Parameters.AddWithValue("@Availability", 0);


                        updateCommand.ExecuteNonQuery();
                    }*/


                    /*catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine("Transaction rolled back. " + ex.Message);
                        throw;
                    }*/
                //}
            }
                
        }
    }



            /*using (SqlConnection connection = new SqlConnection(ConnectionString))
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
            }*/
        
    } 

