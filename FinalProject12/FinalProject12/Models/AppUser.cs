using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace FinalProject12.Models
{
    public enum EmployeeStatus { Active, Inactive }

    public class AppUser : IdentityUser
    {
        [Display(Name = "First Name:")]
        [Required(ErrorMessage = "First name is required.")]
        public String FirstName { get; set; }

        [Display(Name = "Last Name:")]
        [Required(ErrorMessage = "Last name is required.")]
        public String LastName { get; set; }

        [Display(Name = "User Name:")]
        public String FullName
        {
            get { return FirstName + " " + LastName; }
        }

        [Display(Name = "Birthday")]
        [Required(ErrorMessage = "Birthday is required")]
        [DisplayFormat(DataFormatString ="{0:MMM dd, yyyy}")]
        public DateTime Birthday { get; set; }

        public String? StreetAddress { get; set; }

        public String? City { get; set; }

        public String? State { get; set; }

        public Int32? ZipCode { get; set; }

        public EmployeeStatus Status { get; set; }


    //navigational property b/c user can have many registrations

        public List<Transaction> Transactions { get; set; }

        public List<Review> Reviews { get; set; }

        // It will create new (empty) list of Books if the navigational property is null.
        // //This is helpful because you can’t iterate over a null list
        // //You can’t add or remove from a null list, and you can’t count a null list.
        // //Putting this code into a constructor prevents null reference errors throughout the application.

        // how do one for review?
        public AppUser()
        {
            if (Transactions == null)
            {
                Transactions = new List<Transaction>();
            }

            if (Reviews == null)
            {
                Reviews = new List<Review>();
            }

        }

    }
}