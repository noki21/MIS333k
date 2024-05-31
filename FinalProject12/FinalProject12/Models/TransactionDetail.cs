using System.ComponentModel.DataAnnotations;

namespace FinalProject12.Models


{
    public enum PaymentMethod
    {
        [Display(Name = "Cash/Card")]
        CashCard,
        Points

    }


    public class TransactionDetail
    {
        public Int32 TransactionDetailID { get; set; }

        [Display(Name = "Seat Number")]
        public String SeatNumber { get; set; }

        public Boolean? SeniorDiscount { get; set; }

        public Boolean? TuesdayDiscount { get; set; }

        //need a copy of the price

        [Display(Name = "Payment Method")]
        public PaymentMethod PaymentMethod { get; set; }

        //add price at the time of purchase
        public Decimal? TicketPrice { get; set; }

        //
        [Display(Name = "Total Fees")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal? TotalFees { get; set; }

        public Int32 PopcornPointsPerOrder { get; set; }

        //Need to add nav property to transaction and schedule
        public Transaction Transaction { get; set; }

        public Movie Movie { get; set; }

        public Schedule Schedule { get; set; }

    }
}
