﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.AspNetCore.Authorization;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

//TODO: Change this namespace to match your project
namespace FinalProject12.Models
{
    //NOTE: This is the view model used to allow the user to login
    //The user only needs teh email and password to login
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    //NOTE: This is the view model used to register a user
    //When the user registers, they only need to specify the
    //properties listed in this model
    public class RegisterViewModel
    {
        //NOTE: Here is the property for email
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        //NOTE: Here is the property for phone number
        [Required(ErrorMessage = "Phone number is required")]
        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }


        //TODO: Add any fields that you need for creating a new user
        //First name is provided as an example
        [Required(ErrorMessage = "First name is required.")]
        [Display(Name = "First Name")]
        public String FirstName { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [Display(Name = "Last Name")]
        public String LastName { get; set; }


        [Required(ErrorMessage = "Birthday is required.")]
        [Display(Name = "Birthday")]
        public DateTime Birthday { get; set; }

        [Required(ErrorMessage = "Street is required.")]
        [Display(Name = "Street")]
        public String? StreetAddress { get; set; }


        [Required(ErrorMessage = "City is required.")]
        [Display(Name = "City")]
        public String? City { get; set; }

        [Required(ErrorMessage = "State is required.")]
        [Display(Name = "State")]
        public String? State { get; set; }










        //NOTE: Here is the logic for putting in a password
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }





  

    //NOTE: This is the view model used to allow the user to 
    //change their password
    public class ChangePasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }


    public class ChangeBirthdateViewModel
    {

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "New Birthdate")]
        public String Email { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime NewBirthdate { get; set; }

    }


    public class ChangeAddressViewModel
    {

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "New Address")]
        public String Email { get; set; }
        public string NewStreet { get; set; }
        public string NewCity { get; set; }
        public string NewState { get; set; }



    }


    //NOTE: This is the view model used to allow the user to 
    //change their phone number
    public class ChangePhoneNumberViewModel
    {

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "New Phone Number")]
        public String Email { get; set; }
        public string NewPhoneNumber { get; set; }

    }






















    [Authorize(Roles = "Employee")]
    public class EditProfileViewModel
    {
        public String Email { get; set; }

        //NOTE: Here is the property for phone number
        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Birthdate")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [Display(Name = "Address")]
        public String Address { get; set; }

        //NOTE: Here is the logic for putting in a password
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
        public string SelectCustomerName { get; internal set; }
        public int SelectedCustomerID { get; internal set; }
    }


    //NOTE: This is the view model used to display basic user information
    //on the index page
    //public class IndexViewModel
    //{
    //    public bool HasPassword { get; set; }
    //    public String UserName { get; set; }
    //    public String Email { get; set; }
    //    public String UserID { get; set; }
    //}

    public class IndexViewModel
    {
        public bool HasPassword { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String UserName { get; set; }
        public String Email { get; set; }
        public String UserID { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        public String Address { get; set; }
        public String PhoneNumber { get; set; }
    }

}
