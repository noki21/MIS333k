using System;
using FinalProject12.Models;
using FinalProject12.DAL;
using FinalProject12.Utilities;

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalProject12.Seeding
{

    public static class SeedTransactions
    {
        public static void SeedTransactions2(AppDbContext db)
        {
            //Create a counter and a flag so we will know which record is causing problems
            Int32 intTransactionID = 0;
            string strCustomerName = "Begin";

            //Add the list of books
            List<Transaction> Transactions = new List<Transaction>();


            Transactions.Add(new Transaction
            {
                TransactionNumber = 3001,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Michelle " && g.LastName == "Banks"),
                OrderDate = new DateTime(2023, 11, 01),
                OrderSubtotal = 50m,
                PopcornPoints = 50,
                NumberOfTickets = 10,
                TransactionStatus = TransactionStatus.Purchased

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3002,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Christopher" && g.LastName == "Baker"),
                OrderDate = new DateTime(2023, 11, 05),
                OrderSubtotal = 116m,
                PopcornPoints = 116,
                NumberOfTickets = 10,
                TransactionStatus = TransactionStatus.Purchased

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3003,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Brad" && g.LastName == "White"),
                OrderDate = new DateTime(2023, 11, 20),
                OrderSubtotal = 10m,
                PopcornPoints = 10,
                NumberOfTickets = 2,
                TransactionStatus = TransactionStatus.Purchased

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3004,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Michelle" && g.LastName == "Banks"),
                OrderDate = new DateTime(2023, 11, 14),
                OrderSubtotal = 10m,
                PopcornPoints = 12,
                NumberOfTickets = 1,
                TransactionStatus = TransactionStatus.Purchased

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3005,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Franco" && g.LastName == "Broccolo"),
                OrderDate = new DateTime(2023, 11, 05),
                OrderSubtotal = 12m,
                PopcornPoints = 12,
                NumberOfTickets = 1,
                TransactionStatus = TransactionStatus.Purchased

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3006,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Wendy" && g.LastName == "Chang"),
                OrderDate = new DateTime(2023, 11, 20),
                OrderSubtotal = 10m,
                PopcornPoints = 10,
                NumberOfTickets = 1,
                TransactionStatus = TransactionStatus.Purchased

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3007,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Lim " && g.LastName == "Chou"),
                OrderDate = new DateTime(2023, 11, 14),
                OrderSubtotal = 12m,
                PopcornPoints = 12,
                NumberOfTickets = 1,
                TransactionStatus = TransactionStatus.Purchased

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3008,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Brad" && g.LastName == "White"),
                OrderDate = new DateTime(2023, 11, 20),
                OrderSubtotal = 12m,
                PopcornPoints = 12,
                NumberOfTickets = 1,
                TransactionStatus = TransactionStatus.Purchased

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3009,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Shan" && g.LastName == "Dixon"),
                OrderDate = new DateTime(2023, 11, 05),
                OrderSubtotal = 12m,
                PopcornPoints = 12,
                NumberOfTickets = 1,
                TransactionStatus = TransactionStatus.Purchased

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3010,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Jim Bob" && g.LastName == "Evans"),
                OrderDate = new DateTime(2023, 11, 20),
                OrderSubtotal = 12m,
                PopcornPoints = 12,
                NumberOfTickets = 1,
                TransactionStatus = TransactionStatus.Purchased

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3011,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Lou Ann" && g.LastName == "Feeley"),
                OrderDate = new DateTime(2023, 11, 14),
                OrderSubtotal = 12m,
                PopcornPoints = 12,
                NumberOfTickets = 1,
                TransactionStatus = TransactionStatus.Purchased

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3012,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Brad" && g.LastName == "White"),
                OrderDate = new DateTime(2023, 11, 20),
                OrderSubtotal = 12m,
                PopcornPoints = 12,
                NumberOfTickets = 1,
                TransactionStatus = TransactionStatus.Purchased

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3013,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Victoria" && g.LastName == "Lawrence"),
                OrderDate = new DateTime(2023, 11, 05),
                OrderSubtotal = 12m,
                PopcornPoints = 12,
                NumberOfTickets = 1,
                TransactionStatus = TransactionStatus.Purchased

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3014,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Erik" && g.LastName == "Lineback"),
                OrderDate = new DateTime(2023, 11, 20),
                OrderSubtotal = 12m,
                PopcornPoints = 12,
                NumberOfTickets = 1,
                TransactionStatus = TransactionStatus.Cancelled

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3015,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Ernest" && g.LastName == "Lowe"),
                OrderDate = new DateTime(2023, 11, 14),
                OrderSubtotal = 12m,
                PopcornPoints = 12,
                NumberOfTickets = 1,
                TransactionStatus = TransactionStatus.Purchased

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3016,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Brad" && g.LastName == "White"),
                OrderDate = new DateTime(2023, 11, 20),
                OrderSubtotal = 12m,
                PopcornPoints = 12,
                NumberOfTickets = 1,
                TransactionStatus = TransactionStatus.Purchased

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3017,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Brad" && g.LastName == "White"),
                OrderDate = new DateTime(2023, 11, 20),
                OrderSubtotal = 12m,
                PopcornPoints = 12,
                NumberOfTickets = 1,
                TransactionStatus = TransactionStatus.Purchased

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3018,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Brad" && g.LastName == "White"),
                OrderDate = new DateTime(2023, 11, 20),
                OrderSubtotal = 12m,
                PopcornPoints = 12,
                NumberOfTickets = 1,
                TransactionStatus = TransactionStatus.Purchased

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3019,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Brad" && g.LastName == "White"),
                OrderDate = new DateTime(2023, 11, 20),
                OrderSubtotal = 12m,
                PopcornPoints = 12,
                NumberOfTickets = 1,
                TransactionStatus = TransactionStatus.Purchased

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3020,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Brad" && g.LastName == "White"),
                OrderDate = new DateTime(2023, 11, 20),
                OrderSubtotal = 12m,
                PopcornPoints = 12,
                NumberOfTickets = 1,
                TransactionStatus = TransactionStatus.Purchased

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3021,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Brad" && g.LastName == "White"),
                OrderDate = new DateTime(2023, 11, 20),
                OrderSubtotal = 12m,
                PopcornPoints = 12,
                NumberOfTickets = 1,
                TransactionStatus = TransactionStatus.Purchased

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3022,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Michelle" && g.LastName == "Banks"),
                OrderDate = new DateTime(2023, 11, 24),
                OrderSubtotal = 15m,
                PopcornPoints = 15,
                NumberOfTickets = 1,
                TransactionStatus = TransactionStatus.Purchased

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3023,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Christopher" && g.LastName == "Baker"),
                OrderDate = new DateTime(2023, 11, 24),
                OrderSubtotal = 15m,
                PopcornPoints = 15,
                NumberOfTickets = 1,
                TransactionStatus = TransactionStatus.Purchased

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3024,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Brad" && g.LastName == "White"),
                OrderDate = new DateTime(2023, 11, 24),
                OrderSubtotal = 15m,
                PopcornPoints = 15,
                NumberOfTickets = 1,
                TransactionStatus = TransactionStatus.Purchased

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3025,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Michelle" && g.LastName == "Banks"),
                OrderDate = new DateTime(2023, 11, 24),
                OrderSubtotal = 15m,
                PopcornPoints = 15,
                NumberOfTickets = 1,
                TransactionStatus = TransactionStatus.Purchased

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3026,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Franco" && g.LastName == "Broccolo"),
                OrderDate = new DateTime(2023, 11, 24),
                OrderSubtotal = 15m,
                PopcornPoints = 15,
                NumberOfTickets = 1,
                TransactionStatus = TransactionStatus.Purchased

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3027,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Wendy" && g.LastName == "Chang"),
                OrderDate = new DateTime(2023, 11, 24),
                OrderSubtotal = 15m,
                PopcornPoints = 15,
                NumberOfTickets = 1,
                TransactionStatus = TransactionStatus.Purchased

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3028,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Lim" && g.LastName == "Chou"),
                OrderDate = new DateTime(2023, 11, 24),
                OrderSubtotal = 15m,
                PopcornPoints = 15,
                NumberOfTickets = 1,
                TransactionStatus = TransactionStatus.Purchased

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3029,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Shan" && g.LastName == "Dixon"),
                OrderDate = new DateTime(2023, 11, 24),
                OrderSubtotal = 15m,
                PopcornPoints = 15,
                NumberOfTickets = 1,
                TransactionStatus = TransactionStatus.Cancelled

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3030,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Jim Bob" && g.LastName == "Evans"),
                OrderDate = new DateTime(2023, 11, 24),
                OrderSubtotal = 15m,
                PopcornPoints = 15,
                NumberOfTickets = 1,
                TransactionStatus = TransactionStatus.Purchased

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3031,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Lou Ann" && g.LastName == "Feeley"),
                OrderDate = new DateTime(2023, 11, 24),
                OrderSubtotal = 15m,
                PopcornPoints = 15,
                NumberOfTickets = 1,
                TransactionStatus = TransactionStatus.Purchased

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3032,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Victoria" && g.LastName == "Lawrence"),
                OrderDate = new DateTime(2023, 11, 24),
                OrderSubtotal = 15m,
                PopcornPoints = 15,
                NumberOfTickets = 1,
                TransactionStatus = TransactionStatus.Purchased

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3033,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Erik" && g.LastName == "Lineback"),
                OrderDate = new DateTime(2023, 11, 24),
                OrderSubtotal = 15m,
                PopcornPoints = 15,
                NumberOfTickets = 1,
                TransactionStatus = TransactionStatus.Cancelled

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3034,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Ernest" && g.LastName == "Lowe"),
                OrderDate = new DateTime(2023, 11, 24),
                OrderSubtotal = 15m,
                PopcornPoints = 15,
                NumberOfTickets = 1,
                TransactionStatus = TransactionStatus.Purchased

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3035,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Christopher" && g.LastName == "Baker"),
                OrderDate = new DateTime(2023, 11, 24),
                OrderSubtotal = 15m,
                PopcornPoints = 15,
                NumberOfTickets = 1,
                TransactionStatus = TransactionStatus.Purchased

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3036,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Christopher" && g.LastName == "Baker"),
                OrderDate = new DateTime(2023, 11, 24),
                OrderSubtotal = 15m,
                PopcornPoints = 15,
                NumberOfTickets = 1,
                TransactionStatus = TransactionStatus.Purchased

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3037,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Christopher" && g.LastName == "Baker"),
                OrderDate = new DateTime(2023, 11, 24),
                OrderSubtotal = 15m,
                PopcornPoints = 15,
                NumberOfTickets = 1,
                TransactionStatus = TransactionStatus.Purchased

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3038,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Christopher" && g.LastName == "Baker"),
                OrderDate = new DateTime(2023, 11, 24),
                OrderSubtotal = 15m,
                PopcornPoints = 15,
                NumberOfTickets = 1,
                TransactionStatus = TransactionStatus.Purchased

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3039,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Christopher" && g.LastName == "Baker"),
                OrderDate = new DateTime(2023, 11, 24),
                OrderSubtotal = 45m,
                PopcornPoints = 45,
                NumberOfTickets = 3,
                TransactionStatus = TransactionStatus.Purchased

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3040,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Brad" && g.LastName == "White"),
                OrderDate = new DateTime(2023, 11, 01),
                OrderSubtotal = 90m,
                PopcornPoints = 90,
                NumberOfTickets = 6,
                TransactionStatus = TransactionStatus.Purchased

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3041,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Michelle" && g.LastName == "Banks"),
                OrderDate = new DateTime(2023, 11, 01),
                OrderSubtotal = 30m,
                PopcornPoints = 30,
                NumberOfTickets = 2,
                TransactionStatus = TransactionStatus.Cancelled

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3042,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Jim Bob" && g.LastName == "Evans"),
                OrderDate = new DateTime(2023, 11, 01),
                OrderSubtotal = 30m,
                PopcornPoints = 30,
                NumberOfTickets = 2,
                TransactionStatus = TransactionStatus.Purchased

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3043,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Lou Ann" && g.LastName == "Feeley"),
                OrderDate = new DateTime(2023, 11, 01),
                OrderSubtotal = 60m,
                PopcornPoints = 60,
                NumberOfTickets = 4,
                TransactionStatus = TransactionStatus.Purchased

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3044,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Brad" && g.LastName == "White"),
                OrderDate = new DateTime(2023, 11, 01),
                OrderSubtotal = 36m,
                PopcornPoints = 36,
                NumberOfTickets = 3,
                TransactionStatus = TransactionStatus.Purchased

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3045,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Victoria" && g.LastName == "Lawrence"),
                OrderDate = new DateTime(2023, 11, 01),
                OrderSubtotal = 12m,
                PopcornPoints = 12,
                NumberOfTickets = 1,
                TransactionStatus = TransactionStatus.Purchased

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3046,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Franco" && g.LastName == "Broccolo"),
                OrderDate = new DateTime(2023, 11, 01),
                OrderSubtotal = 24m,
                PopcornPoints = 24,
                NumberOfTickets = 2,
                TransactionStatus = TransactionStatus.Purchased

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3047,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Wendy" && g.LastName == "Chang"),
                OrderDate = new DateTime(2023, 11, 01),
                OrderSubtotal = 20m,
                PopcornPoints = 20,
                NumberOfTickets = 2,
                TransactionStatus = TransactionStatus.Purchased

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3048,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Christopher" && g.LastName == "Baker"),
                OrderDate = new DateTime(2023, 11, 01),
                OrderSubtotal = 10m,
                PopcornPoints = 10,
                NumberOfTickets = 1,
                TransactionStatus = TransactionStatus.Purchased

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3049,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Lim" && g.LastName == "Chou"),
                OrderDate = new DateTime(2023, 11, 15),
                OrderSubtotal = 12m,
                PopcornPoints = 12,
                NumberOfTickets = 1,
                TransactionStatus = TransactionStatus.Purchased

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3050,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Jim Bob" && g.LastName == "Evans"),
                OrderDate = new DateTime(2023, 11, 24),
                OrderSubtotal = 45m,
                PopcornPoints = 45,
                NumberOfTickets = 9,
                TransactionStatus = TransactionStatus.Cancelled

            });

            Transactions.Add(new Transaction
            {
                TransactionNumber = 3051,
                AppUser = db.Users.FirstOrDefault(g => g.FirstName == "Brad" && g.LastName == "White"),
                OrderDate = new DateTime(2023, 11, 26),
                OrderSubtotal = 0m,
                PopcornPoints = 200,
                NumberOfTickets = 2,
                TransactionStatus = TransactionStatus.Purchased

            });


            try  //attempt to add or update the book
            {
                //loop through each of the books in the list
                foreach (Transaction seedTransaction in Transactions)
                {
                    //set the flag to the current title to help with debugging
                    intTransactionID = seedTransaction.TransactionID;
                    strCustomerName = seedTransaction.AppUser.FirstName;

                    //look to see if the book is in the database - this assumes that no
                    //two books have the same title
                    Transaction dbTransaction = db.Transactions.FirstOrDefault(b => b.TransactionID == seedTransaction.TransactionID);

                    //if the dbBook is null, this title is not in the database
                    if (dbTransaction == null)
                    {
                        //add the book to the database and save changes
                        db.Transactions.Add(seedTransaction);
                        db.SaveChanges();

                        //update the counter to help with debugging
                        intTransactionID += 1;
                    }
                    else //dbBook is not null - this title *is* in the database
                    {
                        //update all of the book's properties

                        dbTransaction.TransactionNumber = seedTransaction.TransactionNumber;
                        dbTransaction.OrderDate = seedTransaction.OrderDate;
                        dbTransaction.OrderSubtotal = seedTransaction.OrderSubtotal;
                        dbTransaction.PopcornPoints = seedTransaction.PopcornPoints;
                        dbTransaction.NumberOfTickets = seedTransaction.NumberOfTickets;


                        //since we found the correct genre object in a previous step,
                        //this update is easy - both dbBook and bookToAdd have a Genre
                        //object for this property
                        dbTransaction.AppUser = dbTransaction.AppUser;

                        //update the database and save the changes
                        db.Update(dbTransaction);
                        db.SaveChanges();

                        //update the counter to help with debugging
                        intTransactionID += 1;
                    } //this is the end of the else
                } //this is the end of the foreach loop for the books
            }//this is the end of the try block

            catch (Exception ex)//something went wrong with adding or updating
            {
                StringBuilder msg = new StringBuilder();
                msg.Append("There was a problem adding the transaction with the title: ");
                msg.Append(strCustomerName);
                msg.Append(" (intTransactionID: ");
                msg.Append(intTransactionID);
                msg.Append(")");
                throw new Exception(msg.ToString(), ex);
                //Build a messsage using the flags we created

                //throw the exception with the new message
                throw new InvalidOperationException(ex.Message + msg);
            }
        }
    }
}