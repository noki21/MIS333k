using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;



namespace FinalProject12.Models
{

    public enum TransactionStatus
    {
        Purchased, Cancelled

    }

    public class Transaction
    {
        private const Decimal TAX_RATE = 0.0825m;

        public Int32 TransactionID { get; set; }

        [Display(Name = "Transaction Number:")]
        public Int32 TransactionNumber { get; set; }

        [Display(Name = "Number of Tickets")]
        public Int32 NumberOfTickets { get; set; }

        [Display(Name = "Purchase Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime OrderDate { get; set; }

        [Display(Name = "Subtotal")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal OrderSubtotal { get; set; }

        [Display(Name = "Order Tax")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal OrderTax
        {
            get { return OrderSubtotal * TAX_RATE; }
        }

        [Display(Name = "Total Price")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal OrderTotal
        {
            get { return OrderSubtotal + OrderTax; }
        }

        [Display(Name = "Popcorn Points")]
        public Int32 PopcornPoints { get; set; }

        //is it a gift?
        [Display(Name = "Is this a gift for someone?")]
        public Boolean? Gift { get; set; }

        //add status
        public TransactionStatus TransactionStatus { get; set; }

        //nav properties
        public AppUser AppUser { get; set; }

        public List<TransactionDetail> TransactionDetails { get; set; }

        public Transaction()
        {
            if (TransactionDetails == null)
            {
                TransactionDetails = new List<TransactionDetail>();
            }


        }
    }
}