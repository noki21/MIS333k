using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace FinalProject12.Models

{
   
    public enum TicketPrice
    {
        SpecialEvent = 15,
        Matinee = 5,
        DiscountTuesday = 8,
        WeekdayBase = 10,
        Weekends = 12
    }

    public enum TicketType { SpecialEvent, Matinee, DiscountTuesday, WeekdayBase, Weekends }

    public class Price
	{
        public Int32 PriceId { get; set; }

        [Display(Name = "Ticket Price")]
        public TicketPrice TicketPrice { get; set; }

        [Display(Name = "Ticket Type")]
        public TicketType TicketType { get; set; }

        //nav property

        public List<Schedule> Schedules { get; set; }
    }
}

