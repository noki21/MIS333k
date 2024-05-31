using FinalProject12.DAL;
using FinalProject12.Models;
using Microsoft.SqlServer.Server;

using FinalProject12.Models;
using FinalProject12.DAL;
using System.Text;

namespace FinalProject12.Seeding
{
    //make this class static so you can use the dbContext
    public static class SeedPrices
    {
        //You will call this method from the SeedController to add categories
        public static void SeedAllPrices(AppDbContext db)
        {
            Int32 intPriceId = 0;
            //String strPriceName = "Begin";

            List<Price> AllPrices = new List<Price>();

            AllPrices.Add(new Price 
            { 
                 
                TicketPrice = TicketPrice.SpecialEvent,
                TicketType = TicketType.SpecialEvent
            });
            AllPrices.Add(new Price 
            { 

            
                TicketPrice = TicketPrice.Matinee,
                TicketType = TicketType.Matinee
            });
            AllPrices.Add(new Price 
            { 
            
            
                TicketPrice = TicketPrice.DiscountTuesday,
                TicketType = TicketType.DiscountTuesday
            });
            AllPrices.Add(new Price

            {
                TicketPrice = TicketPrice.WeekdayBase,
                TicketType = TicketType.WeekdayBase
            });
            AllPrices.Add(new Price

            {
                TicketPrice = TicketPrice.Weekends,
                TicketType = TicketType.Weekends
            });

            try
            {
                //loop through each of the categories
                foreach (Price seedPrice in AllPrices)
                {
                    //updates the counters to get info on where the problem is
                    intPriceId = seedPrice.PriceId;
                    //strPriceName = seedPrice.TicketPrice;

                    //try to find the category in the database
                    Price dbPrice = db.Prices.FirstOrDefault(c => c.TicketPrice == seedPrice.TicketPrice);

                    //if the category isn't in the database, dbCategory will be null
                    if (dbPrice == null)
                    {
                        //add the Category to the database
                        db.Prices.Add(seedPrice);
                        db.SaveChanges();
                    }
                    else //the record is in the database
                    {
                        //update all the fields
                        //this isn't really needed for category because it only has one field
                        //but you will need it to re-set seeded data with more fields
                        dbPrice.TicketPrice = seedPrice.TicketPrice;
                        //you would add other fields here
                        db.SaveChanges();
                    }

                }
            }
            catch (Exception ex)  //something about adding to the database caused a problem
            {
                //create a new instance of the string builder to make building out 
                //our message neater - we don't want a REALLY long line of code for this
                //so we break it up into several lines
                StringBuilder msg = new StringBuilder();

                msg.Append("There was an error adding the ");
                //msg.Append(strPriceName);
                msg.Append(" Price (PriceID = ");
                msg.Append(intPriceId);
                msg.Append(")");

                //have this method throw the exception to the calling method
                //this code wraps the exception from the database with the 
                //custom message we built above.  The original error from the
                //database becomes the InnerException
                throw new Exception(msg.ToString(), ex);
            }






        }

    }
}
