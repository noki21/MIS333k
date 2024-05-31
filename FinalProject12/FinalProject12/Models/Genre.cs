using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalProject12.Models
{
    public class Genre
    {
        public Int32 GenreID { get; set; }

        [Display(Name = "Genre Name")]
        public String GenreName { get; set; }

        //navigatioanal property
        public List<Movie> Movies { get; set; }


        // It will create new (empty) list of Books if the navigational property is null.
        // //This is helpful because you can’t iterate over a null list
        // //You can’t add or remove from a null list, and you can’t count a null list.
        // //Putting this code into a constructor prevents null reference errors throughout the application.

        public Genre()
        {
            if (Movies == null)
            {
                Movies = new List<Movie>();
            }
        }

    }
}