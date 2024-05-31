using System;
using FinalProject12.Models;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject12.Models
{

    public enum Status
    {
        Pending,
        Approved
    }

    public class Review
    {
        public Int32 ReviewID { get; set; }

        [Required(ErrorMessage = "Please select a rating from 1-5")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1-5.")]
        [Display(Name = "Movie Rating")]
        public Int32 MovieRating { get; set; }

        [Display(Name = "Description:")]
        [StringLength(280, ErrorMessage = "Character limit is 280 characters.")]
        public String? Description { get; set; }

        [Display(Name = "Status:")]
        public Status Status { get; set; }

        //navigational properties

        public AppUser AppUser { get; set; }

        public Movie Movie { get; set; }
        
    }
}
  