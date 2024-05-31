using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace FinalProject12.Models
{
    public enum RatingsRange { GreaterThan, LessThan }
    public class SearchViewModel
    {
        [Display(Name = "Search by Movie Name:")]
        public String? SearchTitle { get; set; }

        [Display(Name = "Search by Tagline:")]
        public String? SearchTagline { get; set; }

        [Display(Name = "Search by Description:")]
        public String? SearchDescription { get; set; }

        [Display(Name = "Search by Genre")]
        public Int32? SelectedGenre { get; set; }

        [Display(Name = "Search by Release Year:")]
        public Int32? SearchReleaseYear { get; set; }

        [Display(Name = "Search by Actors:")]
        public String? SearchActors { get; set; }

        [Display(Name = "Search by MPAA Rating:")]
        public MPAA_Rating? SelectedMPAARating { get; set; }

        [Display(Name = "Search by Movie Showtime:")]
        [DataType(DataType.Date)]
        public DateTime? SelectedDateTime { get; set; }

        [Display(Name = "Customer Rating:")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1-5.")]
        public Decimal? SearchRating { get; set; }

        [Display(Name = "")]
        public RatingsRange? RatingsRange { get; set; }
    }
}

