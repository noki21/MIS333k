using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;




//TODO: Change this using statement to match your project (LastName_FirstName_HW3)
using FinalProject12.DAL;
using Microsoft.AspNetCore.Mvc;
using FinalProject12.Models;
using Microsoft.EntityFrameworkCore;


//TODO: Update this namespace to match your project's name
namespace FinalProject12.Controllers
{
    public class SeedController : Controller
    {
        private AppDbContext _db;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;


        public SeedController(AppDbContext context, UserManager<AppUser> um, RoleManager<IdentityRole> rm)
        {
            _db = context;
            _userManager = um;
            _roleManager = rm;

        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> SeedRoles()
        {
            try
            {
                //call the method to seed the roles
                await Seeding.SeedRoles.AddAllRoles(_roleManager);
            }
            catch (Exception ex)
            {
                //add the error messages to a list of strings
                List<String> errorList = new List<String>();

                //Add the outer message
                errorList.Add(ex.Message);

                //Add the message from the inner exception
                errorList.Add(ex.InnerException.Message);

                //Add additional inner exception messages, if there are any
                if (ex.InnerException.InnerException != null)
                {
                    errorList.Add(ex.InnerException.InnerException.Message);
                }

                return View("Error", errorList);
            }

            //this is the happy path - seeding worked!
            return View("Confirm");
        }

        public async Task<IActionResult> SeedUsers()
        {
            try
            {
                //call the method to seed the users
                await Seeding.SeedUsers.SeedAllUsers(_userManager, _db);
            }
            catch (Exception ex)
            {
                //add the error messages to a list of strings
                List<String> errorList = new List<String>();

                //Add the outer message
                errorList.Add(ex.Message);

                if (ex.InnerException != null)
                {
                    //Add the message from the inner exception
                    errorList.Add(ex.InnerException.Message);

                    //Add additional inner exception messages, if there are any
                    if (ex.InnerException.InnerException != null)
                    {
                        errorList.Add(ex.InnerException.InnerException.Message);
                    }

                }


                return View("Error", errorList);
            }

            //this is the happy path - seeding worked!
            return View("Confirm");
        }



        public IActionResult SeedGenres()
        {
            try
            {
                Seeding.SeedGenres.SeedAllGenres(_db);
            }
            catch (Exception ex)
            {
                //create a new list for the error messages
                List<String> errors = new List<String>();

                //add a generic error message
                errors.Add("There was a problem adding genres to the database");

                //add message from the exception
                errors.Add(ex.Message);

                //add messages from inner exceptions, if there are any
                if (ex.InnerException != null)
                {
                    errors.Add(ex.InnerException.Message);
                    if (ex.InnerException.InnerException != null)
                    {
                        errors.Add(ex.InnerException.InnerException.Message);
                        if (ex.InnerException.InnerException.InnerException != null)
                        {
                            errors.Add(ex.InnerException.InnerException.InnerException.Message);
                        }
                    }
                }

                //return the error view with the errors
                return View("Error", errors);
            }

            //everything is okay - return the confirmation page
            return View("Confirm");
        }

        public IActionResult SeedMovies()
        {
            try
            {
                Seeding.SeedMovies.SeedAllMovies(_db);
            }
            catch (Exception ex)
            {
                //create a new list for the error messages
                List<String> errors = new List<String>();

                //add a generic error message
                errors.Add("There was a problem adding Movies to the database");

                //add message from the exception
                errors.Add(ex.Message);

                //add messages from inner exceptions, if there are any
                if (ex.InnerException != null)
                {
                    errors.Add(ex.InnerException.Message);
                    if (ex.InnerException.InnerException != null)
                    {
                        errors.Add(ex.InnerException.InnerException.Message);
                        if (ex.InnerException.InnerException.InnerException != null)
                        {
                            errors.Add(ex.InnerException.InnerException.InnerException.Message);
                        }
                    }
                }

                //return the error view with the errors
                return View("Error", errors);
            }

            //everything is okay - return the confirmation page
            return View("Confirm");
        }

        public IActionResult SeedTransactions()
        {
            try
            {
                Seeding.SeedTransactions.SeedTransactions2(_db);
            }
            catch (Exception ex)
            {
                //create a new list for the error messages
                List<String> errors = new List<String>();

                //add a generic error message
                errors.Add("There was a problem adding Movies to the database");

                //add message from the exception
                errors.Add(ex.Message);

                //add messages from inner exceptions, if there are any
                if (ex.InnerException != null)
                {
                    errors.Add(ex.InnerException.Message);
                    if (ex.InnerException.InnerException != null)
                    {
                        errors.Add(ex.InnerException.InnerException.Message);
                        if (ex.InnerException.InnerException.InnerException != null)
                        {
                            errors.Add(ex.InnerException.InnerException.InnerException.Message);
                        }
                    }
                }

                //return the error view with the errors
                return View("Error", errors);
            }

            //everything is okay - return the confirmation page
            return View("Confirm");
        }

        //Seed Schedules

        public IActionResult SeedSchedules()
        {
            try
            {
                Seeding.SeedSchedules.SeedAllSchedules(_db);
            }
            catch (Exception ex)
            {
                //create a new list for the error messages
                List<String> errors = new List<String>();

                //add a generic error message
                errors.Add("There was a problem adding Schedules to the database");

                //add message from the exception
                errors.Add(ex.Message);

                //add messages from inner exceptions, if there are any
                if (ex.InnerException != null)
                {
                    errors.Add(ex.InnerException.Message);
                    if (ex.InnerException.InnerException != null)
                    {
                        errors.Add(ex.InnerException.InnerException.Message);
                        if (ex.InnerException.InnerException.InnerException != null)
                        {
                            errors.Add(ex.InnerException.InnerException.InnerException.Message);
                        }
                    }
                }

                //return the error view with the errors
                return View("Error", errors);
            }

            //everything is okay - return the confirmation page
            return View("Confirm");
        }

        public IActionResult SeedPrices()
        {
            try
            {
                Seeding.SeedPrices.SeedAllPrices(_db);
            }
            catch (Exception ex)
            {
                //create a new list for the error messages
                List<String> errors = new List<String>();

                //add a generic error message
                errors.Add("There was a problem adding prices to the database");

                //add message from the exception
                errors.Add(ex.Message);

                //add messages from inner exceptions, if there are any
                if (ex.InnerException != null)
                {
                    errors.Add(ex.InnerException.Message);
                    if (ex.InnerException.InnerException != null)
                    {
                        errors.Add(ex.InnerException.InnerException.Message);
                        if (ex.InnerException.InnerException.InnerException != null)
                        {
                            errors.Add(ex.InnerException.InnerException.InnerException.Message);
                        }
                    }
                }

                //return the error view with the errors
                return View("Error", errors);
            }

            //everything is okay - return the confirmation page
            return View("Confirm");
        }



        public IActionResult SeedReviews()
        {
            try
            {
                Seeding.SeedReviews.SeedAllReviews(_db);
            }
            catch (Exception ex)
            {
                //create a new list for the error messages
                List<String> errors = new List<String>();

                //add a generic error message
                errors.Add("There was a problem adding reviews to the database");

                //add message from the exception
                errors.Add(ex.Message);

                //add messages from inner exceptions, if there are any
                if (ex.InnerException != null)
                {
                    errors.Add(ex.InnerException.Message);
                    if (ex.InnerException.InnerException != null)
                    {
                        errors.Add(ex.InnerException.InnerException.Message);
                        if (ex.InnerException.InnerException.InnerException != null)
                        {
                            errors.Add(ex.InnerException.InnerException.InnerException.Message);
                        }
                    }
                }

                //return the error view with the errors
                return View("Error", errors);
            }

            //everything is okay - return the confirmation page
            return View("Confirm");
        }

        public IActionResult SeedTransactionDetails()
        {
            try
            {
                Seeding.SeedTransactionDetails.SeedTransactionDetails2(_db);
            }
            catch (Exception ex)
            {
                //create a new list for the error messages
                List<String> errors = new List<String>();

                //add a generic error message
                errors.Add("There was a problem adding prices to the database");

                //add message from the exception
                errors.Add(ex.Message);

                //add messages from inner exceptions, if there are any
                if (ex.InnerException != null)
                {
                    errors.Add(ex.InnerException.Message);
                    if (ex.InnerException.InnerException != null)
                    {
                        errors.Add(ex.InnerException.InnerException.Message);
                        if (ex.InnerException.InnerException.InnerException != null)
                        {
                            errors.Add(ex.InnerException.InnerException.InnerException.Message);
                        }
                    }
                }

                //return the error view with the errors
                return View("Error", errors);
            }

            //everything is okay - return the confirmation page
            return View("Confirm");
        }








    }
}