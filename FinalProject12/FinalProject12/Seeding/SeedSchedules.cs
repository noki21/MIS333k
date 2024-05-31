
using System;
using FinalProject12.Models;
using FinalProject12.DAL;
using FinalProject12.Utilities;

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalProject12.Seeding
{

    public static class SeedSchedules
    {
        public static void SeedAllSchedules(AppDbContext db)
        {
            //Create a counter and a flag so we will know which record is causing problems
            Int32 intScheduleID = 0;
            string strScheduleName = "Begin";

            //Add the list of books
            List<Schedule> AllSchedules = new List<Schedule>();


            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Fast and Furious 18: Anger Management"),
                StartDateTime = new DateTime(2023, 11, 23, 11, 00, 00),
                EndDateTime = new DateTime(2023, 11, 23, 13, 00, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Matinee),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Fast and Furious 18: Anger Management"),
                StartDateTime = new DateTime(2023, 11, 23, 15, 30, 00),
                EndDateTime = new DateTime(2023, 11, 23, 17, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Fast and Furious 18: Anger Management"),
                StartDateTime = new DateTime(2023, 11, 24, 11, 00, 00),
                EndDateTime = new DateTime(2023, 11, 24, 13, 00, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Matinee),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Fast and Furious 18: Anger Management"),
                StartDateTime = new DateTime(2023, 11, 24, 15, 30, 00),
                EndDateTime = new DateTime(2023, 11, 24, 17, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Fast and Furious 18: Anger Management"),
                StartDateTime = new DateTime(2023, 11, 25, 11, 00, 00),
                EndDateTime = new DateTime(2023, 11, 25, 13, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Fast and Furious 18: Anger Management"),
                StartDateTime = new DateTime(2023, 11, 26, 11, 00, 00),
                EndDateTime = new DateTime(2023, 11, 26, 13, 00, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Fast and Furious 18: Anger Management"),
                StartDateTime = new DateTime(2023, 11, 27, 11, 00, 00),
                EndDateTime = new DateTime(2023, 11, 27, 13, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Matinee),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Fast and Furious 18: Anger Management"),
                StartDateTime = new DateTime(2023, 11, 27, 15, 30, 00),
                EndDateTime = new DateTime(2023, 11, 27, 17, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Fast and Furious 18: Anger Management"),
                StartDateTime = new DateTime(2023, 11, 28, 11, 00, 00),
                EndDateTime = new DateTime(2023, 11, 28, 13, 00, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Matinee),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Fast and Furious 18: Anger Management"),
                StartDateTime = new DateTime(2023, 11, 28, 15, 30, 00),
                EndDateTime = new DateTime(2023, 11, 28, 17, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.DiscountTuesday),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Fast and Furious 18: Anger Management"),
                StartDateTime = new DateTime(2023, 11, 29, 11, 00, 00),
                EndDateTime = new DateTime(2023, 11, 29, 13, 00, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Matinee),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Fast and Furious 18: Anger Management"),
                StartDateTime = new DateTime(2023, 11, 29, 15, 30, 00),
                EndDateTime = new DateTime(2023, 11, 29, 17, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Fast and Furious 18: Anger Management"),
                StartDateTime = new DateTime(2023, 11, 30, 11, 00, 00),
                EndDateTime = new DateTime(2023, 11, 30, 13, 00, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Matinee),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Fast and Furious 18: Anger Management"),
                StartDateTime = new DateTime(2023, 11, 30, 15, 30, 00),
                EndDateTime = new DateTime(2023, 11, 30, 17, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Fast and Furious 18: Anger Management"),
                StartDateTime = new DateTime(2023, 12, 1, 11, 00, 00),
                EndDateTime = new DateTime(2023, 12, 1, 13, 00, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Matinee),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Fast and Furious 18: Anger Management"),
                StartDateTime = new DateTime(2023, 12, 1, 15, 30, 00),
                EndDateTime = new DateTime(2023, 12, 1, 17, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Fast and Furious 18: Anger Management"),
                StartDateTime = new DateTime(2023, 12, 2, 11, 00, 00),
                EndDateTime = new DateTime(2023, 12, 2, 13, 00, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Fast and Furious 18: Anger Management"),
                StartDateTime = new DateTime(2023, 12, 3, 11, 00, 00),
                EndDateTime = new DateTime(2023, 12, 3, 13, 00, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Fast and Furious 18: Anger Management"),
                StartDateTime = new DateTime(2023, 12, 4, 11, 00, 00),
                EndDateTime = new DateTime(2023, 12, 4, 13, 00, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Matinee),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Fast and Furious 18: Anger Management"),
                StartDateTime = new DateTime(2023, 12, 4, 15, 30, 00),
                EndDateTime = new DateTime(2023, 12, 4, 17, 00, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Fast and Furious 18: Anger Management"),
                StartDateTime = new DateTime(2023, 12, 5, 11, 00, 00),
                EndDateTime = new DateTime(2023, 12, 5, 13, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Matinee),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Fast and Furious 18: Anger Management"),
                StartDateTime = new DateTime(2023, 12, 5, 15, 30, 00),
                EndDateTime = new DateTime(2023, 12, 5, 17, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.DiscountTuesday),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Fast and Furious 18: Anger Management"),
                StartDateTime = new DateTime(2023, 12, 6, 11, 00, 00),
                EndDateTime = new DateTime(2023, 12, 6, 13, 00, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Matinee),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Fast and Furious 18: Anger Management"),
                StartDateTime = new DateTime(2023, 12, 6, 15, 30, 00),
                EndDateTime = new DateTime(2023, 12, 6, 17, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Fast and Furious 18: Anger Management"),
                StartDateTime = new DateTime(2023, 12, 7, 11, 00, 00),
                EndDateTime = new DateTime(2023, 12, 7, 13, 00, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Matinee),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Fast and Furious 18: Anger Management"),
                StartDateTime = new DateTime(2023, 12, 7, 15, 30, 00),
                EndDateTime = new DateTime(2023, 12, 7, 17, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Jurassic Park"),
                StartDateTime = new DateTime(2023, 11, 23, 9, 00, 00),
                EndDateTime = new DateTime(2023, 11, 23, 10, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Matinee),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Jurassic Park"),
                StartDateTime = new DateTime(2023, 11, 23, 11, 00, 00),
                EndDateTime = new DateTime(2023, 11, 23, 12, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Matinee),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Jurassic Park"),
                StartDateTime = new DateTime(2023, 11, 24, 9, 00, 00),
                EndDateTime = new DateTime(2023, 11, 24, 10, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Matinee),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Jurassic Park"),
                StartDateTime = new DateTime(2023, 11, 24, 11, 00, 00),
                EndDateTime = new DateTime(2023, 11, 24, 12, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Matinee),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Jurassic Park"),
                StartDateTime = new DateTime(2023, 11, 27, 9, 00, 00),
                EndDateTime = new DateTime(2023, 11, 27, 10, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Matinee),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Jurassic Park"),
                StartDateTime = new DateTime(2023, 11, 27, 11, 00, 00),
                EndDateTime = new DateTime(2023, 11, 27, 12, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Matinee),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Jurassic Park"),
                StartDateTime = new DateTime(2023, 11, 28, 9, 00, 00),
                EndDateTime = new DateTime(2023, 11, 28, 10, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Matinee),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Jurassic Park"),
                StartDateTime = new DateTime(2023, 11, 28, 11, 00, 00),
                EndDateTime = new DateTime(2023, 11, 28, 12, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Matinee),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Jurassic Park"),
                StartDateTime = new DateTime(2023, 11, 29, 9, 00, 00),
                EndDateTime = new DateTime(2023, 11, 29, 10, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Matinee),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Jurassic Park"),
                StartDateTime = new DateTime(2023, 11, 29, 11, 00, 00),
                EndDateTime = new DateTime(2023, 11, 29, 12, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Matinee),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Jurassic Park"),
                StartDateTime = new DateTime(2023, 11, 30, 9, 00, 00),
                EndDateTime = new DateTime(2023, 11, 30, 10, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Matinee),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Jurassic Park"),
                StartDateTime = new DateTime(2023, 11, 30, 11, 00, 00),
                EndDateTime = new DateTime(2023, 11, 30, 12, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Matinee),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Jurassic Park"),
                StartDateTime = new DateTime(2023, 12, 1, 9, 00, 00),
                EndDateTime = new DateTime(2023, 12, 1, 10, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Matinee),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Jurassic Park"),
                StartDateTime = new DateTime(2023, 12, 1, 11, 00, 00),
                EndDateTime = new DateTime(2023, 12, 1, 12, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Matinee),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Jurassic Park"),
                StartDateTime = new DateTime(2023, 12, 4, 9, 00, 00),
                EndDateTime = new DateTime(2023, 12, 4, 10, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Matinee),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Jurassic Park"),
                StartDateTime = new DateTime(2023, 12, 4, 11, 00, 00),
                EndDateTime = new DateTime(2023, 12, 4, 12, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Matinee),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Jurassic Park"),
                StartDateTime = new DateTime(2023, 12, 5, 9, 00, 00),
                EndDateTime = new DateTime(2023, 12, 5, 10, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Matinee),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Jurassic Park"),
                StartDateTime = new DateTime(2023, 12, 5, 11, 00, 00),
                EndDateTime = new DateTime(2023, 12, 5, 12, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Matinee),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Jurassic Park"),
                StartDateTime = new DateTime(2023, 12, 6, 9, 00, 00),
                EndDateTime = new DateTime(2023, 12, 6, 10, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Matinee),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Jurassic Park"),
                StartDateTime = new DateTime(2023, 12, 6, 11, 00, 00),
                EndDateTime = new DateTime(2023, 12, 6, 12, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Matinee),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Jurassic Park"),
                StartDateTime = new DateTime(2023, 12, 7, 9, 00, 00),
                EndDateTime = new DateTime(2023, 12, 7, 10, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Matinee),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Jurassic Park"),
                StartDateTime = new DateTime(2023, 12, 7, 11, 00, 00),
                EndDateTime = new DateTime(2023, 12, 7, 12, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Matinee),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Lord of the Rings: The Return of the King"),
                StartDateTime = new DateTime(2023, 11, 25, 19, 30, 00),
                EndDateTime = new DateTime(2023, 11, 25, 22, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.SpecialEvent),
                SpecialEvent = true

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Lord of the Rings: The Return of the King"),
                StartDateTime = new DateTime(2023, 11, 26, 19, 30, 00),
                EndDateTime = new DateTime(2023, 11, 26, 22, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.SpecialEvent),
                SpecialEvent = true

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Lord of the Rings: The Return of the King"),
                StartDateTime = new DateTime(2023, 12, 2, 19, 30, 00),
                EndDateTime = new DateTime(2023, 12, 2, 22, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Lord of the Rings: The Return of the King"),
                StartDateTime = new DateTime(2023, 12, 3, 19, 30, 00),
                EndDateTime = new DateTime(2023, 12, 3, 22, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.SpecialEvent),
                SpecialEvent = true

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Lord of the Rings: Fellowship of the Ring"),
                StartDateTime = new DateTime(2023, 11, 25, 13, 30, 00),
                EndDateTime = new DateTime(2023, 11, 25, 16, 00, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Lord of the Rings: Fellowship of the Ring"),
                StartDateTime = new DateTime(2023, 11, 26, 13, 30, 00),
                EndDateTime = new DateTime(2023, 11, 26, 16, 00, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Lord of the Rings: Fellowship of the Ring"),
                StartDateTime = new DateTime(2023, 12, 2, 13, 30, 00),
                EndDateTime = new DateTime(2023, 12, 2, 16, 00, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Lord of the Rings: Fellowship of the Ring"),
                StartDateTime = new DateTime(2023, 12, 3, 13, 30, 00),
                EndDateTime = new DateTime(2023, 12, 3, 16, 00, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Lord of the Rings: Two Towers"),
                StartDateTime = new DateTime(2023, 11, 25, 16, 30, 00),
                EndDateTime = new DateTime(2023, 11, 25, 19, 00, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Lord of the Rings: Two Towers"),
                StartDateTime = new DateTime(2023, 11, 26, 16, 30, 00),
                EndDateTime = new DateTime(2023, 11, 26, 19, 00, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Lord of the Rings: Two Towers"),
                StartDateTime = new DateTime(2023, 12, 2, 16, 30, 00),
                EndDateTime = new DateTime(2023, 12, 2, 19, 00, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Lord of the Rings: Two Towers"),
                StartDateTime = new DateTime(2023, 12, 3, 16, 30, 00),
                EndDateTime = new DateTime(2023, 12, 3, 19, 00, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Rocky Horror Picture Show"),
                StartDateTime = new DateTime(2023, 11, 23, 22, 00, 00),
                EndDateTime = new DateTime(2023, 11, 23, 23, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Rocky Horror Picture Show"),
                StartDateTime = new DateTime(2023, 11, 24, 22, 00, 00),
                EndDateTime = new DateTime(2023, 11, 24, 23, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Rocky Horror Picture Show"),
                StartDateTime = new DateTime(2023, 11, 27, 22, 00, 00),
                EndDateTime = new DateTime(2023, 11, 27, 23, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Rocky Horror Picture Show"),
                StartDateTime = new DateTime(2023, 11, 28, 22, 00, 00),
                EndDateTime = new DateTime(2023, 11, 28, 23, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Rocky Horror Picture Show"),
                StartDateTime = new DateTime(2023, 11, 29, 22, 00, 00),
                EndDateTime = new DateTime(2023, 11, 29, 23, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Rocky Horror Picture Show"),
                StartDateTime = new DateTime(2023, 11, 30, 22, 00, 00),
                EndDateTime = new DateTime(2023, 11, 30, 23, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Rocky Horror Picture Show"),
                StartDateTime = new DateTime(2023, 12, 1, 22, 00, 00),
                EndDateTime = new DateTime(2023, 12, 1, 23, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Rocky Horror Picture Show"),
                StartDateTime = new DateTime(2023, 12, 4, 22, 00, 00),
                EndDateTime = new DateTime(2023, 12, 4, 23, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Rocky Horror Picture Show"),
                StartDateTime = new DateTime(2023, 12, 5, 22, 00, 00),
                EndDateTime = new DateTime(2023, 12, 5, 23, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Rocky Horror Picture Show"),
                StartDateTime = new DateTime(2023, 12, 6, 22, 00, 00),
                EndDateTime = new DateTime(2023, 12, 6, 23, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Rocky Horror Picture Show"),
                StartDateTime = new DateTime(2023, 12, 7, 22, 00, 00),
                EndDateTime = new DateTime(2023, 12, 7, 23, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Goonies"),
                StartDateTime = new DateTime(2023, 11, 23, 21, 00, 00),
                EndDateTime = new DateTime(2023, 11, 23, 22, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Goonies"),
                StartDateTime = new DateTime(2023, 11, 23, 18, 00, 00),
                EndDateTime = new DateTime(2023, 11, 23, 19, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Goonies"),
                StartDateTime = new DateTime(2023, 11, 24, 21, 00, 00),
                EndDateTime = new DateTime(2023, 11, 24, 22, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Goonies"),
                StartDateTime = new DateTime(2023, 11, 24, 18, 00, 00),
                EndDateTime = new DateTime(2023, 11, 24, 19, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Goonies"),
                StartDateTime = new DateTime(2023, 11, 27, 21, 00, 00),
                EndDateTime = new DateTime(2023, 11, 27, 22, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Goonies"),
                StartDateTime = new DateTime(2023, 11, 27, 18, 00, 00),
                EndDateTime = new DateTime(2023, 11, 27, 19, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Goonies"),
                StartDateTime = new DateTime(2023, 11, 28, 21, 00, 00),
                EndDateTime = new DateTime(2023, 11, 28, 22, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Goonies"),
                StartDateTime = new DateTime(2023, 11, 28, 18, 00, 00),
                EndDateTime = new DateTime(2023, 11, 28, 19, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Goonies"),
                StartDateTime = new DateTime(2023, 11, 29, 21, 00, 00),
                EndDateTime = new DateTime(2023, 11, 29, 22, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Goonies"),
                StartDateTime = new DateTime(2023, 11, 29, 18, 00, 00),
                EndDateTime = new DateTime(2023, 11, 29, 19, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Goonies"),
                StartDateTime = new DateTime(2023, 11, 30, 21, 00, 00),
                EndDateTime = new DateTime(2023, 11, 30, 22, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Goonies"),
                StartDateTime = new DateTime(2023, 11, 30, 18, 00, 00),
                EndDateTime = new DateTime(2023, 11, 30, 19, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Goonies"),
                StartDateTime = new DateTime(2023, 12, 1, 21, 00, 00),
                EndDateTime = new DateTime(2023, 12, 1, 22, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.SpecialEvent),
                SpecialEvent = true

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Goonies"),
                StartDateTime = new DateTime(2023, 12, 1, 18, 00, 00),
                EndDateTime = new DateTime(2023, 12, 1, 19, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Goonies"),
                StartDateTime = new DateTime(2023, 12, 4, 21, 00, 00),
                EndDateTime = new DateTime(2023, 12, 4, 22, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Goonies"),
                StartDateTime = new DateTime(2023, 12, 4, 18, 00, 00),
                EndDateTime = new DateTime(2023, 12, 4, 19, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Goonies"),
                StartDateTime = new DateTime(2023, 12, 5, 21, 00, 00),
                EndDateTime = new DateTime(2023, 12, 5, 22, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Goonies"),
                StartDateTime = new DateTime(2023, 12, 5, 18, 00, 00),
                EndDateTime = new DateTime(2023, 12, 5, 19, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Goonies"),
                StartDateTime = new DateTime(2023, 12, 6, 21, 00, 00),
                EndDateTime = new DateTime(2023, 12, 6, 22, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Goonies"),
                StartDateTime = new DateTime(2023, 12, 6, 18, 00, 00),
                EndDateTime = new DateTime(2023, 12, 6, 19, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Goonies"),
                StartDateTime = new DateTime(2023, 12, 7, 21, 00, 00),
                EndDateTime = new DateTime(2023, 12, 7, 22, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Goonies"),
                StartDateTime = new DateTime(2023, 12, 7, 18, 00, 00),
                EndDateTime = new DateTime(2023, 12, 7, 19, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Hobbit: An Unexpected Journey"),
                StartDateTime = new DateTime(2023, 11, 25, 15, 00, 00),
                EndDateTime = new DateTime(2023, 11, 25, 17, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Hobbit: An Unexpected Journey"),
                StartDateTime = new DateTime(2023, 11, 26, 15, 00, 00),
                EndDateTime = new DateTime(2023, 11, 26, 17, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Hobbit: An Unexpected Journey"),
                StartDateTime = new DateTime(2023, 12, 2, 15, 00, 00),
                EndDateTime = new DateTime(2023, 12, 2, 17, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Hobbit: An Unexpected Journey"),
                StartDateTime = new DateTime(2023, 12, 3, 15, 00, 00),
                EndDateTime = new DateTime(2023, 12, 3, 17, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Hobbit: The Battle of Five Armies"),
                StartDateTime = new DateTime(2023, 11, 25, 21, 00, 00),
                EndDateTime = new DateTime(2023, 11, 25, 23, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.SpecialEvent),
                SpecialEvent = true

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Hobbit: The Battle of Five Armies"),
                StartDateTime = new DateTime(2023, 11, 26, 21, 00, 00),
                EndDateTime = new DateTime(2023, 11, 26, 23, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.SpecialEvent),
                SpecialEvent = true

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Hobbit: The Battle of Five Armies"),
                StartDateTime = new DateTime(2023, 12, 2, 21, 00, 00),
                EndDateTime = new DateTime(2023, 12, 2, 23, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Hobbit: The Battle of Five Armies"),
                StartDateTime = new DateTime(2023, 12, 3, 21, 00, 00),
                EndDateTime = new DateTime(2023, 12, 3, 23, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.SpecialEvent),
                SpecialEvent = true

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Hobbit: The Desolation of Smaug"),
                StartDateTime = new DateTime(2023, 11, 25, 18, 00, 00),
                EndDateTime = new DateTime(2023, 11, 25, 19, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Hobbit: The Desolation of Smaug"),
                StartDateTime = new DateTime(2023, 11, 26, 18, 00, 00),
                EndDateTime = new DateTime(2023, 11, 26, 19, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Hobbit: The Desolation of Smaug"),
                StartDateTime = new DateTime(2023, 12, 2, 18, 00, 00),
                EndDateTime = new DateTime(2023, 12, 2, 19, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Hobbit: The Desolation of Smaug"),
                StartDateTime = new DateTime(2023, 12, 3, 18, 00, 00),
                EndDateTime = new DateTime(2023, 12, 3, 19, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Sandlot"),
                StartDateTime = new DateTime(2023, 11, 23, 20, 00, 00),
                EndDateTime = new DateTime(2023, 11, 23, 21, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Sandlot"),
                StartDateTime = new DateTime(2023, 11, 24, 20, 00, 00),
                EndDateTime = new DateTime(2023, 11, 24, 21, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Sandlot"),
                StartDateTime = new DateTime(2023, 11, 27, 20, 00, 00),
                EndDateTime = new DateTime(2023, 11, 27, 21, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Sandlot"),
                StartDateTime = new DateTime(2023, 11, 28, 20, 00, 00),
                EndDateTime = new DateTime(2023, 11, 28, 21, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Sandlot"),
                StartDateTime = new DateTime(2023, 11, 29, 20, 00, 00),
                EndDateTime = new DateTime(2023, 11, 29, 21, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Sandlot"),
                StartDateTime = new DateTime(2023, 11, 30, 20, 00, 00),
                EndDateTime = new DateTime(2023, 11, 30, 21, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Sandlot"),
                StartDateTime = new DateTime(2023, 12, 1, 20, 00, 00),
                EndDateTime = new DateTime(2023, 12, 1, 21, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.SpecialEvent),
                SpecialEvent = true

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Sandlot"),
                StartDateTime = new DateTime(2023, 12, 4, 20, 00, 00),
                EndDateTime = new DateTime(2023, 12, 4, 21, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Sandlot"),
                StartDateTime = new DateTime(2023, 12, 5, 20, 00, 00),
                EndDateTime = new DateTime(2023, 12, 5, 21, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Sandlot"),
                StartDateTime = new DateTime(2023, 12, 6, 20, 00, 00),
                EndDateTime = new DateTime(2023, 12, 6, 21, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Sandlot"),
                StartDateTime = new DateTime(2023, 12, 7, 20, 00, 00),
                EndDateTime = new DateTime(2023, 12, 7, 21, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Secret Life of Walter Mitty"),
                StartDateTime = new DateTime(2023, 11, 23, 16, 30, 00),
                EndDateTime = new DateTime(2023, 11, 23, 18, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Secret Life of Walter Mitty"),
                StartDateTime = new DateTime(2023, 11, 23, 13, 00, 00),
                EndDateTime = new DateTime(2023, 11, 23, 15, 00, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Secret Life of Walter Mitty"),
                StartDateTime = new DateTime(2023, 11, 24, 16, 30, 00),
                EndDateTime = new DateTime(2023, 11, 24, 18, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Secret Life of Walter Mitty"),
                StartDateTime = new DateTime(2023, 11, 24, 13, 00, 00),
                EndDateTime = new DateTime(2023, 11, 24, 15, 00, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Secret Life of Walter Mitty"),
                StartDateTime = new DateTime(2023, 11, 27, 16, 30, 00),
                EndDateTime = new DateTime(2023, 11, 27, 18, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Secret Life of Walter Mitty"),
                StartDateTime = new DateTime(2023, 11, 27, 13, 00, 00),
                EndDateTime = new DateTime(2023, 11, 27, 15, 00, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Secret Life of Walter Mitty"),
                StartDateTime = new DateTime(2023, 11, 28, 16, 30, 00),
                EndDateTime = new DateTime(2023, 11, 28, 18, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.DiscountTuesday),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Secret Life of Walter Mitty"),
                StartDateTime = new DateTime(2023, 11, 28, 13, 00, 00),
                EndDateTime = new DateTime(2023, 11, 28, 15, 00, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.DiscountTuesday),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Secret Life of Walter Mitty"),
                StartDateTime = new DateTime(2023, 11, 29, 16, 30, 00),
                EndDateTime = new DateTime(2023, 11, 29, 18, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Secret Life of Walter Mitty"),
                StartDateTime = new DateTime(2023, 11, 29, 13, 00, 00),
                EndDateTime = new DateTime(2023, 11, 29, 15, 00, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Secret Life of Walter Mitty"),
                StartDateTime = new DateTime(2023, 11, 30, 16, 30, 00),
                EndDateTime = new DateTime(2023, 11, 30, 18, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Secret Life of Walter Mitty"),
                StartDateTime = new DateTime(2023, 11, 30, 13, 00, 00),
                EndDateTime = new DateTime(2023, 11, 30, 15, 00, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Secret Life of Walter Mitty"),
                StartDateTime = new DateTime(2023, 12, 1, 16, 30, 00),
                EndDateTime = new DateTime(2023, 12, 1, 18, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Secret Life of Walter Mitty"),
                StartDateTime = new DateTime(2023, 12, 1, 13, 00, 00),
                EndDateTime = new DateTime(2023, 12, 1, 15, 00, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Secret Life of Walter Mitty"),
                StartDateTime = new DateTime(2023, 12, 4, 16, 30, 00),
                EndDateTime = new DateTime(2023, 12, 4, 18, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Secret Life of Walter Mitty"),
                StartDateTime = new DateTime(2023, 12, 4, 13, 00, 00),
                EndDateTime = new DateTime(2023, 12, 4, 15, 00, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Secret Life of Walter Mitty"),
                StartDateTime = new DateTime(2023, 12, 5, 16, 30, 00),
                EndDateTime = new DateTime(2023, 12, 5, 18, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.DiscountTuesday),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Secret Life of Walter Mitty"),
                StartDateTime = new DateTime(2023, 12, 5, 13, 00, 00),
                EndDateTime = new DateTime(2023, 12, 5, 15, 00, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.DiscountTuesday),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Secret Life of Walter Mitty"),
                StartDateTime = new DateTime(2023, 12, 6, 16, 30, 00),
                EndDateTime = new DateTime(2023, 12, 6, 18, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Secret Life of Walter Mitty"),
                StartDateTime = new DateTime(2023, 12, 6, 13, 00, 00),
                EndDateTime = new DateTime(2023, 12, 6, 15, 00, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Secret Life of Walter Mitty"),
                StartDateTime = new DateTime(2023, 12, 7, 16, 30, 00),
                EndDateTime = new DateTime(2023, 12, 7, 18, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Secret Life of Walter Mitty"),
                StartDateTime = new DateTime(2023, 12, 7, 13, 00, 00),
                EndDateTime = new DateTime(2023, 12, 7, 15, 00, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Titanic"),
                StartDateTime = new DateTime(2023, 11, 23, 13, 30, 00),
                EndDateTime = new DateTime(2023, 11, 23, 16, 00, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Titanic"),
                StartDateTime = new DateTime(2023, 11, 25, 9, 00, 00),
                EndDateTime = new DateTime(2023, 11, 25, 11, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Titanic"),
                StartDateTime = new DateTime(2023, 11, 26, 9, 00, 00),
                EndDateTime = new DateTime(2023, 11, 26, 11, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Titanic"),
                StartDateTime = new DateTime(2023, 11, 27, 13, 30, 00),
                EndDateTime = new DateTime(2023, 11, 27, 16, 00, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Titanic"),
                StartDateTime = new DateTime(2023, 11, 28, 13, 30, 00),
                EndDateTime = new DateTime(2023, 11, 28, 16, 00, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.DiscountTuesday),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Titanic"),
                StartDateTime = new DateTime(2023, 11, 29, 13, 30, 00),
                EndDateTime = new DateTime(2023, 11, 29, 16, 00, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Titanic"),
                StartDateTime = new DateTime(2023, 12, 2, 9, 00, 00),
                EndDateTime = new DateTime(2023, 12, 2, 11, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Titanic"),
                StartDateTime = new DateTime(2023, 12, 3, 9, 00, 00),
                EndDateTime = new DateTime(2023, 12, 3, 11, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Titanic"),
                StartDateTime = new DateTime(2023, 12, 4, 13, 30, 00),
                EndDateTime = new DateTime(2023, 12, 4, 16, 00, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Titanic"),
                StartDateTime = new DateTime(2023, 12, 6, 13, 30, 00),
                EndDateTime = new DateTime(2023, 12, 6, 16, 00, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Titanic: Jack's Revenge"),
                StartDateTime = new DateTime(2023, 11, 24, 13, 30, 00),
                EndDateTime = new DateTime(2023, 11, 24, 16, 00, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Titanic: Jack's Revenge"),
                StartDateTime = new DateTime(2023, 11, 25, 12, 00, 00),
                EndDateTime = new DateTime(2023, 11, 25, 14, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Titanic: Jack's Revenge"),
                StartDateTime = new DateTime(2023, 11, 26, 12, 00, 00),
                EndDateTime = new DateTime(2023, 11, 26, 14, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Titanic: Jack's Revenge"),
                StartDateTime = new DateTime(2023, 11, 30, 13, 30, 00),
                EndDateTime = new DateTime(2023, 11, 30, 16, 00, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Titanic: Jack's Revenge"),
                StartDateTime = new DateTime(2023, 12, 1, 13, 30, 00),
                EndDateTime = new DateTime(2023, 12, 1, 16, 00, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Titanic: Jack's Revenge"),
                StartDateTime = new DateTime(2023, 12, 2, 12, 00, 00),
                EndDateTime = new DateTime(2023, 12, 2, 14, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Titanic: Jack's Revenge"),
                StartDateTime = new DateTime(2023, 12, 3, 12, 00, 00),
                EndDateTime = new DateTime(2023, 12, 3, 14, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Titanic: Jack's Revenge"),
                StartDateTime = new DateTime(2023, 12, 5, 13, 30, 00),
                EndDateTime = new DateTime(2023, 12, 5, 16, 00, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.DiscountTuesday),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Titanic: Jack's Revenge"),
                StartDateTime = new DateTime(2023, 12, 7, 13, 30, 00),
                EndDateTime = new DateTime(2023, 12, 7, 16, 00, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Toy Story 7"),
                StartDateTime = new DateTime(2023, 11, 23, 19, 00, 00),
                EndDateTime = new DateTime(2023, 11, 23, 20, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Toy Story 7"),
                StartDateTime = new DateTime(2023, 11, 23, 9, 00, 00),
                EndDateTime = new DateTime(2023, 11, 23, 10, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Matinee),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Toy Story 7"),
                StartDateTime = new DateTime(2023, 11, 24, 19, 00, 00),
                EndDateTime = new DateTime(2023, 11, 24, 20, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Toy Story 7"),
                StartDateTime = new DateTime(2023, 11, 24, 9, 00, 00),
                EndDateTime = new DateTime(2023, 11, 24, 10, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Matinee),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Toy Story 7"),
                StartDateTime = new DateTime(2023, 11, 25, 9, 00, 00),
                EndDateTime = new DateTime(2023, 11, 25, 10, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Toy Story 7"),
                StartDateTime = new DateTime(2023, 11, 26, 9, 00, 00),
                EndDateTime = new DateTime(2023, 11, 26, 10, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Toy Story 7"),
                StartDateTime = new DateTime(2023, 11, 27, 19, 00, 00),
                EndDateTime = new DateTime(2023, 11, 27, 20, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Toy Story 7"),
                StartDateTime = new DateTime(2023, 11, 27, 9, 00, 00),
                EndDateTime = new DateTime(2023, 11, 27, 10, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Matinee),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Toy Story 7"),
                StartDateTime = new DateTime(2023, 11, 28, 19, 00, 00),
                EndDateTime = new DateTime(2023, 11, 28, 20, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Toy Story 7"),
                StartDateTime = new DateTime(2023, 11, 28, 9, 00, 00),
                EndDateTime = new DateTime(2023, 11, 28, 10, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Matinee),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Toy Story 7"),
                StartDateTime = new DateTime(2023, 11, 29, 19, 00, 00),
                EndDateTime = new DateTime(2023, 11, 29, 20, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Toy Story 7"),
                StartDateTime = new DateTime(2023, 11, 29, 9, 00, 00),
                EndDateTime = new DateTime(2023, 11, 29, 10, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Matinee),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Toy Story 7"),
                StartDateTime = new DateTime(2023, 11, 30, 19, 00, 00),
                EndDateTime = new DateTime(2023, 11, 30, 20, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Toy Story 7"),
                StartDateTime = new DateTime(2023, 11, 30, 9, 00, 00),
                EndDateTime = new DateTime(2023, 11, 30, 10, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Matinee),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Toy Story 7"),
                StartDateTime = new DateTime(2023, 12, 1, 19, 00, 00),
                EndDateTime = new DateTime(2023, 12, 1, 20, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Toy Story 7"),
                StartDateTime = new DateTime(2023, 12, 1, 9, 00, 00),
                EndDateTime = new DateTime(2023, 12, 1, 10, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Matinee),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Toy Story 7"),
                StartDateTime = new DateTime(2023, 12, 2, 9, 00, 00),
                EndDateTime = new DateTime(2023, 12, 2, 10, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Toy Story 7"),
                StartDateTime = new DateTime(2023, 12, 3, 9, 00, 00),
                EndDateTime = new DateTime(2023, 12, 3, 10, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Weekends),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Toy Story 7"),
                StartDateTime = new DateTime(2023, 12, 4, 19, 00, 00),
                EndDateTime = new DateTime(2023, 12, 4, 20, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Toy Story 7"),
                StartDateTime = new DateTime(2023, 12, 4, 9, 00, 00),
                EndDateTime = new DateTime(2023, 12, 4, 10, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Matinee),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Toy Story 7"),
                StartDateTime = new DateTime(2023, 12, 5, 19, 00, 00),
                EndDateTime = new DateTime(2023, 12, 5, 20, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Toy Story 7"),
                StartDateTime = new DateTime(2023, 12, 5, 9, 00, 00),
                EndDateTime = new DateTime(2023, 12, 5, 10, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Matinee),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Toy Story 7"),
                StartDateTime = new DateTime(2023, 12, 6, 19, 00, 00),
                EndDateTime = new DateTime(2023, 12, 6, 20, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Toy Story 7"),
                StartDateTime = new DateTime(2023, 12, 6, 9, 00, 00),
                EndDateTime = new DateTime(2023, 12, 6, 10, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Matinee),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Toy Story 7"),
                StartDateTime = new DateTime(2023, 12, 7, 19, 00, 00),
                EndDateTime = new DateTime(2023, 12, 7, 20, 30, 00),
                TheaterNumber = TheaterNumber.Theater1,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.WeekdayBase),
                SpecialEvent = false

            });

            AllSchedules.Add(new Schedule
            {
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Toy Story 7"),
                StartDateTime = new DateTime(2023, 12, 7, 9, 00, 00),
                EndDateTime = new DateTime(2023, 12, 7, 10, 30, 00),
                TheaterNumber = TheaterNumber.Theater2,
                Price = db.Prices.FirstOrDefault(c => c.TicketPrice == TicketPrice.Matinee),
                SpecialEvent = false

            });

            try  //attempt to add or update the book
            {
                //loop through each of the books in the list
                foreach (Schedule scheduleToAdd in AllSchedules)
                {
                    //set the flag to the current title to help with debugging
                    strScheduleName = scheduleToAdd.ScheduleID.ToString();

                    //look to see if the book is in the database - this assumes that no
                    //two books have the same title
                    Schedule dbSchedule = db.Schedules.FirstOrDefault(m => m.ScheduleID == scheduleToAdd.ScheduleID);

                    //if the dbBook is null, this title is not in the database
                    if (dbSchedule == null)
                    {
                        db.Schedules.Add(scheduleToAdd);
                        db.SaveChanges();
                        intScheduleID += 1;
                    }
                    else //dbBook is not null - this title *is* in the database
                    {
                        //update all of the book's properties

                        dbSchedule.Movie = scheduleToAdd.Movie;
                        dbSchedule.StartDateTime = scheduleToAdd.StartDateTime;
                        dbSchedule.EndDateTime = scheduleToAdd.EndDateTime;
                        dbSchedule.TheaterNumber = scheduleToAdd.TheaterNumber;
                        dbSchedule.Price = scheduleToAdd.Price;
                        dbSchedule.SpecialEvent = scheduleToAdd.SpecialEvent;

                        db.Update(dbSchedule);
                        db.SaveChanges();
                        intScheduleID += 1;
                    } //this is the end of the else
                } //this is the end of the foreach loop for the books
            }//this is the end of the try block

            catch (Exception ex)//something went wrong with adding or updating
            {
                StringBuilder msg = new StringBuilder();
                msg.Append("There was a problem adding the job posting with the title: ");
                msg.Append(strScheduleName);
                msg.Append(" (intScheduleID: ");
                msg.Append(intScheduleID);
                msg.Append(")");
                throw new Exception(msg.ToString(), ex);
                //Build a messsage using the flags we created

                //throw the exception with the new message
                throw new InvalidOperationException(ex.Message + msg);
            }
        }
    }
}