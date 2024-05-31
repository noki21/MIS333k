using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace FinalProject12.Models
{
    public enum TheaterNumber { Theater1, Theater2 }

    public class Schedule
    {
        public Int32 ScheduleID { get; set; }

        [Required(ErrorMessage = "This is required!")]
        [Display(Name = "Starts at:")]
        [DisplayFormat(DataFormatString = "{0:dddd, d MMMM yyyy hh:mm tt}")]
        public DateTime StartDateTime { get; set; }

        [Required(ErrorMessage = "This is required!")]
        [Display(Name = "Ends at:")]
        [DisplayFormat(DataFormatString = "{0:dddd, d MMMM yyyy hh:mm tt}")]
        public DateTime EndDateTime { get; set; }

        [Display(Name = "Theater Number: ")]
        public TheaterNumber TheaterNumber { get; set; }

        [Display(Name = "Special Event?")]
        public Boolean? SpecialEvent { get; set; }

        //need to add nav property to transaction details, movies, and price

        public Movie Movie { get; set; }

        public Price Price { get; set; }



        public List<TransactionDetail> TransactionDetails { get; set; }



        public Schedule()
        {
            if (TransactionDetails == null)
            {
                TransactionDetails ??= new List<TransactionDetail>();
            }

            if (Movie != null)
            {
                EndDateTime = StartDateTime.AddMinutes(Movie.Runtime);
            }

            else
            {
                EndDateTime = DateTime.Parse("Jan 1, 2000");
            }

            if (Price != null)
            {
                if (StartDateTime.TimeOfDay < TimeSpan.FromHours(12) && (StartDateTime.DayOfWeek >= DayOfWeek.Monday && StartDateTime.DayOfWeek <= DayOfWeek.Friday))
                {
                    Price.TicketType = TicketType.Matinee;
                }

                if (StartDateTime.TimeOfDay > TimeSpan.FromHours(12) && (StartDateTime.TimeOfDay < TimeSpan.FromHours(17) && StartDateTime.DayOfWeek == DayOfWeek.Tuesday))
                    {
                    Price.TicketType = TicketType.DiscountTuesday;
                    }

                if (StartDateTime.TimeOfDay > TimeSpan.FromHours(12) && (StartDateTime.DayOfWeek == DayOfWeek.Monday || StartDateTime.DayOfWeek == DayOfWeek.Tuesday || StartDateTime.DayOfWeek == DayOfWeek.Wednesday || StartDateTime.DayOfWeek == DayOfWeek.Thursday))
                {
                    Price.TicketType = TicketType.WeekdayBase;
                }

                if (StartDateTime.TimeOfDay > TimeSpan.FromHours(12) && (StartDateTime.DayOfWeek == DayOfWeek.Friday || StartDateTime.DayOfWeek == DayOfWeek.Saturday || StartDateTime.DayOfWeek == DayOfWeek.Sunday))
                {
                    Price.TicketType = TicketType.Weekends;
                }


            }

        }
    }
}