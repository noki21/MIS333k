using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;

namespace FinalProject12.Models
{

    public enum MPAA_Rating { G=1, PG=2, [Display(Name = "PG-13")] thirteen=3, R=4 }


    public class Movie
    {
        public Int32 MovieID { get; set; }


        [Display(Name = "Movie Number")]
        public Int32 MovieNum { get; set; }

        [Display(Name = "Movie Name")]
        public String MovieName { get; set; }

        [Display(Name = "Movie Description")]
        public String MovieDescription { get; set; }

        [Display(Name = "Release Year")]
        public Int32 ReleaseYear { get; set; }

        [Display(Name = "MPAA Rating")]
        public MPAA_Rating MPAA_Rating { get; set; }

        [Display(Name = "Runtime")]
        public Int32 Runtime { get; set; }

        [Display(Name = "Actors")]
        public String Actor { get; set; }

        [Display(Name = "Tagline")]
        public String? Tagline { get; set; }

        [Display(Name="Movie Price")]
        public Decimal? MoviePrice { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.0}")]
        [Display(Name = "Ratings Average")]

        public string PosterFileName { get; set; }


        public Decimal RatingsAvg
        {
            get
            {
                List<Review> ApprovedReviews = new List<Review>();
                foreach (Review item in Reviews)
                {
                    if (item.Status == Status.Approved)
                    {
                        ApprovedReviews.Add(item);
                    }
                }

                if (ApprovedReviews.Count() == 0)
                {
                    return 0;
                }
                else
                {
                    Double dblAvg = ApprovedReviews.Average(m => m.MovieRating);
                    Decimal decAvg = Convert.ToDecimal(dblAvg);
                    return decAvg;
                }
            }
        }


        //navigational properties
        public Genre Genre { get; set; }

        public List<Review> Reviews { get; set; }

        public List<Schedule> Schedules { get; set; }

        public List<TransactionDetail> TransactionDetails { get; set; }


        // It will create new (empty) list of Books if the navigational property is null.
        // //This is helpful because you can’t iterate over a null list
        // //You can’t add or remove from a null list, and you can’t count a null list.
        // //Putting this code into a constructor prevents null reference errors throughout the application.

        public Movie() //need to fix, genres
        {

            if (Reviews == null)
            {
                Reviews = new List<Review>();
            }

            if (Schedules == null)
            {
                Schedules = new List<Schedule>();
            }

            if (TransactionDetails == null)
            {
                TransactionDetails = new List<TransactionDetail>();
            }


        }
    }
}