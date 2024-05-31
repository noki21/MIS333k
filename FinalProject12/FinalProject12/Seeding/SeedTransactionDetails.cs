using System;
using FinalProject12.Models;
using FinalProject12.DAL;
using FinalProject12.Utilities;

using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace FinalProject12.Seeding
{

    public static class SeedTransactionDetails
    {
        public static void SeedTransactionDetails2(AppDbContext db)
        {
            //Create a counter and a flag so we will know which record is causing problems
            Int32 intTransactionDetailID = 0;
            string strSeatNumber = "Begin";

            //Add the list of books
            List<TransactionDetail> TransactionDetails = new List<TransactionDetail>();



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "A1",
                TicketPrice = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 5,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 1),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 28)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "A2",
                TicketPrice = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 5,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 1),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 28)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "A3",
                TicketPrice = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 5,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 1),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 28)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "A4",
                TicketPrice = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 5,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 1),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 28)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "A5",
                TicketPrice = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 5,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 1),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 28)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "B1",
                TicketPrice = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 5,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 1),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 28)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "B2",
                TicketPrice = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 5,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 1),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 28)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "B3",
                TicketPrice = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 5,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 1),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 28)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "B4",
                TicketPrice = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 5,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 1),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 28)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "B5",
                TicketPrice = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 5,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 1),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 28)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "A1",
                TicketPrice = 10,
                SeniorDiscount = true,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 10,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 2),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 119)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "A2",
                TicketPrice = 10,
                SeniorDiscount = true,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 10,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 2),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 119)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "A3",
                TicketPrice = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 12,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 2),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 119)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "A4",
                TicketPrice = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 12,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 2),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 119)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "A5",
                TicketPrice = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 12,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 2),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 119)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "B1",
                TicketPrice = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 12,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 2),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 119)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "B2",
                TicketPrice = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 12,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 2),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 119)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "B3",
                TicketPrice = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 12,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 2),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 119)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "B4",
                TicketPrice = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 12,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 2),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 119)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "B5",
                TicketPrice = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 12,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 2),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 119)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "C2",
                TicketPrice = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 5,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 3),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 28)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "C3",
                TicketPrice = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 5,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 3),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 28)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "C4",
                TicketPrice = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 5,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 4),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 28)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "C5",
                TicketPrice = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 5,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 4),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 28)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "A1",
                TicketPrice = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 12,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 5),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 74)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "A2",
                TicketPrice = 10,
                SeniorDiscount = true,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 10,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 6),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 74)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "A3",
                TicketPrice = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 12,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 7),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 74)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "A4",
                TicketPrice = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 12,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 8),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 74)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "A5",
                TicketPrice = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 12,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 9),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 74)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "B1",
                TicketPrice = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 12,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 10),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 74)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "B2",
                TicketPrice = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 12,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 11),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 74)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "B3",
                TicketPrice = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 12,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 12),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 74)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "B4",
                TicketPrice = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 12,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 13),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 74)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "B5",
                TicketPrice = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 12,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 14),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 74)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "E1",
                TicketPrice = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 12,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 15),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 74)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "E2",
                TicketPrice = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 12,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 16),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 74)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "E3",
                TicketPrice = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 12,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 17),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 74)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "E4",
                TicketPrice = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 12,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 18),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 74)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "E5",
                TicketPrice = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 12,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 19),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 74)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "C4",
                TicketPrice = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 12,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 20),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 74)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "C5",
                TicketPrice = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 12,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 21),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 74)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "D1",
                TicketPrice = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 15,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 22),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 98)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "A2",
                TicketPrice = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 15,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 23),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 98)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "A3",
                TicketPrice = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 15,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 24),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 98)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "A4",
                TicketPrice = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 15,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 25),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 98)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "A5",
                TicketPrice = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 15,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 26),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 98)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "B1",
                TicketPrice = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 15,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 27),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 98)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "B2",
                TicketPrice = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 15,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 28),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 98)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "B3",
                TicketPrice = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 15,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 29),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 98)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "B4",
                TicketPrice = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 15,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 30),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 98)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "B5",
                TicketPrice = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 15,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 31),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 98)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "E1",
                TicketPrice = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 15,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 32),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 98)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "E2",
                TicketPrice = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 15,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 33),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 98)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "E3",
                TicketPrice = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 15,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 34),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 98)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "E4",
                TicketPrice = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 15,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 35),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 98)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "E5",
                TicketPrice = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 15,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 36),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 98)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "C4",
                TicketPrice = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 15,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 37),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 98)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "C5",
                TicketPrice = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 15,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 38),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 98)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "D1",
                TicketPrice = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 15,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 39),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 49)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "A2",
                TicketPrice = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 15,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 39),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 49)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "A3",
                TicketPrice = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 15,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 39),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 49)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "A4",
                TicketPrice = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 15,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 40),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 49)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "A5",
                TicketPrice = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 15,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 40),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 49)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "B1",
                TicketPrice = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 15,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 40),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 49)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "B2",
                TicketPrice = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 15,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 40),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 49)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "B3",
                TicketPrice = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 15,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 40),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 49)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "B4",
                TicketPrice = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 15,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 40),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 49)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "B5",
                TicketPrice = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 15,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 41),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 49)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "E1",
                TicketPrice = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 15,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 41),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 49)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "E2",
                TicketPrice = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 15,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 42),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 49)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "E3",
                TicketPrice = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 15,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 42),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 49)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "E4",
                TicketPrice = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 15,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 43),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 49)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "E5",
                TicketPrice = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 15,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 43),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 49)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "C4",
                TicketPrice = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 15,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 43),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 49)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "C5",
                TicketPrice = 15,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 15,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 43),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 49)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "B2",
                TicketPrice = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 12,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 44),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 150)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "B3",
                TicketPrice = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 12,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 44),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 150)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "B4",
                TicketPrice = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 12,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 44),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 150)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "B5",
                TicketPrice = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 12,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 45),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 150)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "E1",
                TicketPrice = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 12,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 46),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 150)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "E2",
                TicketPrice = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 12,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 46),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 150)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "E3",
                TicketPrice = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 12,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 47),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 150)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "E4",
                TicketPrice = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 12,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 47),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 150)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "E5",
                TicketPrice = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 12,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 48),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 150)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "E5",
                TicketPrice = 12,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 12,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 49),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 162)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "A4",
                TicketPrice = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 5,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 50),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 7)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "E1",
                TicketPrice = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 5,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 50),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 7)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "E2",
                TicketPrice = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 5,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 50),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 7)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "E3",
                TicketPrice = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 5,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 50),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 7)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "E4",
                TicketPrice = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 5,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 50),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 7)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "E5",
                TicketPrice = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 5,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 50),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 7)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "B3",
                TicketPrice = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 5,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 50),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 7)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "B4",
                TicketPrice = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 5,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 50),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 7)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "B5",
                TicketPrice = 5,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.CashCard,
                PopcornPointsPerOrder = 5,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 50),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 7)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "C3",
                TicketPrice = 0,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.Points,
                PopcornPointsPerOrder = -100,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 51),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 68)
            });



            TransactionDetails.Add(new TransactionDetail
            {
                SeatNumber = "C4",
                TicketPrice = 0,
                SeniorDiscount = false,
                PaymentMethod = PaymentMethod.Points,
                PopcornPointsPerOrder = -100,
                Transaction = db.Transactions.FirstOrDefault(g => g.TransactionID == 51),
                Schedule = db.Schedules.FirstOrDefault(g => g.ScheduleID == 68)
            });


            try  //attempt to add or update the book
            {
                //loop through each of the books in the list
                foreach (TransactionDetail seedTransactionDetail in TransactionDetails)
                {
                    //set the flag to the current title to help with debugging
                    strSeatNumber = seedTransactionDetail.SeatNumber;
                    intTransactionDetailID = seedTransactionDetail.TransactionDetailID;

                    //look to see if the book is in the database - this assumes that no
                    //two books have the same title
                    TransactionDetail dbTransactionDetail = db.TransactionDetails.FirstOrDefault(b => b.TransactionDetailID == seedTransactionDetail.TransactionDetailID);

                    //if the dbBook is null, this title is not in the database
                    if (dbTransactionDetail == null)
                    {
                        //add the book to the database and save changes
                        db.TransactionDetails.Add(seedTransactionDetail);
                        db.SaveChanges();

                        //update the counter to help with debugging
                        intTransactionDetailID += 1;
                    }
                    else //dbBook is not null - this title *is* in the database
                    {
                        //update all of the book's properties

                        dbTransactionDetail.SeatNumber = dbTransactionDetail.SeatNumber;
                        dbTransactionDetail.TicketPrice = dbTransactionDetail.TicketPrice;
                        dbTransactionDetail.SeniorDiscount = dbTransactionDetail.SeniorDiscount;
                        dbTransactionDetail.PaymentMethod = dbTransactionDetail.PaymentMethod;


                        //since we found the correct genre object in a previous step,
                        //this update is easy - both dbBook and bookToAdd have a Genre
                        //object for this property
                        dbTransactionDetail.Schedule.Movie.MovieName = dbTransactionDetail.Schedule.Movie.MovieName;
                        dbTransactionDetail.Schedule.TheaterNumber = dbTransactionDetail.Schedule.TheaterNumber;
                        dbTransactionDetail.Transaction.PopcornPoints = dbTransactionDetail.Transaction.PopcornPoints;
                        dbTransactionDetail.Transaction.OrderDate = dbTransactionDetail.Transaction.OrderDate;

                        //update the database and save the changes
                        db.Update(dbTransactionDetail);
                        db.SaveChanges();

                        //update the counter to help with debugging
                        intTransactionDetailID += 1;
                    } //this is the end of the else
                } //this is the end of the foreach loop for the books
            }//this is the end of the try block

            catch (Exception ex)//something went wrong with adding or updating
            {
                StringBuilder msg = new StringBuilder();
                msg.Append("There was a problem adding the job posting with the title: ");
                msg.Append(strSeatNumber);
                msg.Append(" (intTransactionDetailID: ");
                msg.Append(intTransactionDetailID);
                msg.Append(")");
                throw new Exception(msg.ToString(), ex);
                //Build a messsage using the flags we created

                //throw the exception with the new message
                throw new InvalidOperationException(ex.Message + msg);
            }
        }
    }
}