using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

//TODO: Change these using statements to match your project
using FinalProject12.DAL;
using FinalProject12.Models;
using FinalProject12.Utilities;
using System;

//TODO: Change this namespace to match your project
namespace FinalProject12.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly PasswordValidator<AppUser> _passwordValidator;
        private readonly AppDbContext _context;

        public AccountController(AppDbContext appDbContext, UserManager<AppUser> userManager, SignInManager<AppUser> signIn)
        {
            _context = appDbContext;
            _userManager = userManager;
            _signInManager = signIn;
            //user manager only has one password validator
            _passwordValidator = (PasswordValidator<AppUser>)userManager.PasswordValidators.FirstOrDefault();
        }

        // GET: /Account/Register
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        // POST: /Account/Register
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterViewModel rvm)
        {
            DateTime currentDate = DateTime.Now;
            DateTime DateOfBirth = rvm.Birthday; 

            int age = currentDate.Year - DateOfBirth.Year;

            if (currentDate.Month < DateOfBirth.Month || (currentDate.Month == DateOfBirth.Month && currentDate.Day < DateOfBirth.Day))
            {
                age--;
            }

            if (age < 13)
            {
                ModelState.AddModelError(string.Empty, "You must be at least 13 years old to register.");
            }


            if (await _userManager.FindByEmailAsync(rvm.Email) != null)
            {
                ModelState.AddModelError(string.Empty, "This email address is already registered.");
            }



            //if registration data is valid, create a new user on the database
            if (ModelState.IsValid == false)
            {
                //this is the sad path - something went wrong, 
                //return the user to the register page to try again
                return View(rvm);
            }

            //this code maps the RegisterViewModel to the AppUser domain model
            AppUser newUser = new AppUser
            {
                UserName = rvm.Email,
                Email = rvm.Email,
                PhoneNumber = rvm.PhoneNumber,

                //TODO: Add the rest of the custom user fields here
                //FirstName is included as an example
                FirstName = rvm.FirstName,
                LastName = rvm.LastName,
                
                






    };

            //create AddUserModel
            AddUserModel aum = new AddUserModel()
            {
                User = newUser,
                Password = rvm.Password,

                //TODO: You will need to change this value if you want to 
                //add the user to a different role - just specify the role name.
                RoleName = "Customer"
            };

          

            //This code uses the AddUser utility to create a new user with the specified password
            IdentityResult result = await Utilities.AddUser.AddUserWithRoleAsync(aum, _userManager, _context);

            if (result.Succeeded) //everything is okay
            {
                //NOTE: This code logs the user into the account that they just created
                //You may or may not want to log a user in directly after they register - check
                //the business rules!
                Microsoft.AspNetCore.Identity.SignInResult result2 = await _signInManager.PasswordSignInAsync(rvm.Email, rvm.Password, false, lockoutOnFailure: false);

                //Send the user to the home page
                return RedirectToAction("Index", "Home");
            }
            else  //the add user operation didn't work, and we need to show an error message
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                //send user back to page with errors
                return View(rvm);
            }
        }

        // GET: /Account/Login
        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            if (User.Identity.IsAuthenticated) //user has been redirected here from a page they're not authorized to see
            {
                return View("Error", new string[] { "Access Denied" });
            }
            _signInManager.SignOutAsync(); //this removes any old cookies hanging around
            ViewBag.ReturnUrl = returnUrl; //pass along the page the user should go back to
            return View();
        }

        public IActionResult CheckFired()
        {
            if (User.IsInRole("FiredEmployee"))
            {
                return View("Error", new String[] { "You are fired!" });
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel lvm, string returnUrl)
        {
            //if user forgot to include user name or password,
            //send them back to the login page to try again

            if (lvm.Email == null || lvm.Password == null)
            {
                Console.WriteLine(lvm.Email);
                Console.WriteLine(lvm.Password);
                return View(lvm);
            }



          

            //attempt to sign the user in using the SignInManager
            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(lvm.Email, lvm.Password, lvm.RememberMe, lockoutOnFailure: false);

            //if the login worked, take the user to either the url
            //they requested OR the homepage if there isn't a specific url
            if (result.Succeeded)
            {
                //return ?? "/" means if returnUrl is null, substitute "/" (home)
                return Redirect(returnUrl ?? "/");
            }
            else //log in was not successful
            {
                //add an error to the model to show invalid attempt
                ModelState.AddModelError("", "Invalid login attempt.");
                //send user back to login page to try again
                return View(lvm);
            }
        }

        public IActionResult AccessDenied()
        {
            return View("Error", new string[] { "You are not authorized for this resource" });
        }

        ////GET: Account/Index
        //public IActionResult Index()
        //{
        //    IndexViewModel ivm = new IndexViewModel();

        //    //get user info
        //    String id = User.Identity.Name;
        //    AppUser user = _context.Users.FirstOrDefault(u => u.UserName == id);

        //    //populate the view model
        //    //(i.e. map the domain model to the view model)
        //    ivm.Email = user.Email;
        //    ivm.HasPassword = true;
        //    ivm.UserID = user.Id;
        //    ivm.UserName = user.UserName;

        //    //send data to the view
        //    return View(ivm);
        //}


        



        // GET: /Account/ChangeAddress
        [Authorize(Roles = "Employee, Manager, Customer")]
        [HttpGet]
        public ActionResult ChangeAddress(string email)
        {
            ChangeAddressViewModel newavm = new ChangeAddressViewModel();
            {
                newavm.Email = email;

            };

            return View(newavm);
        }

        //GET: Account/Index
        [Authorize(Roles = "Employee, Manager, Customer")]
        public IActionResult Index()
        {

            IndexViewModel ivm = new IndexViewModel();

            //get user info
            String id = User.Identity.Name;
            AppUser user = _context.Users.FirstOrDefault(u => u.UserName == id);
            ViewBag.UserInfo = user;
            //populate the view model
            //(i.e. map the domain model to the view model)
            ivm.Email = user.Email;
            ivm.HasPassword = true;
            ivm.UserID = user.Id;
            ivm.FirstName = user.FirstName;
            ivm.LastName = user.LastName;
            ivm.UserName = user.UserName;
            ivm.Birthday = user.Birthday;
            ivm.PhoneNumber = user.PhoneNumber;
            ivm.Address = user.StreetAddress;
            ivm.Address = user.City;
            ivm.Address = user.StreetAddress;



            return View(ivm);
        }


        // post change address
        [Authorize(Roles = "Employee, Manager, Customer")]
        [HttpPost]
        public async Task<ActionResult> ChangeAddress([Bind("Email, NewStreet, NewState, NewCity")] ChangeAddressViewModel avm)
        {
            if (User.Identity.Name != avm.Email)
            {
                return View("Error", new String[] { "There was a problem editing this customer. Try again!" });
            }

            AppUser userLoggedIn = await _userManager.FindByNameAsync(User.Identity.Name);

            if (ModelState.IsValid == false)
            {
                return View(avm);
            }

            try
            {
                //find the record in the database
                AppUser dbUsers = _context.Users.Where(u => u.Email == avm.Email).FirstOrDefault();

                //update the notes
                dbUsers.StreetAddress = avm.NewStreet;

                dbUsers.City = avm.NewCity;

                dbUsers.State = avm.NewState;



                _context.Update(dbUsers);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was an error updating this order!", ex.Message });
            }

            //send the user to the Account Index page.
            return RedirectToAction(nameof(Index));

        }

        //Logic for change birthdate
        // GET: /Account/ChangeBirthdate
        [Authorize(Roles = "Employee, Manager, Customer")]
        [HttpGet]
        public ActionResult ChangeBirthdate(string email)
        {
            ChangeBirthdateViewModel newcbvm = new ChangeBirthdateViewModel();
            {
                newcbvm.Email = email;

            };

            return View(newcbvm);
        }

        [HttpPost]
        [Authorize(Roles = "Employee, Manager, Customer")]
        public async Task<ActionResult> ChangeBirthdate([Bind("Email, NewBirthdate")] ChangeBirthdateViewModel cbvm)
        {
            if (User.Identity.Name != cbvm.Email)
            {
                return View("Error", new String[] { "There was a problem editing this customer. Try again!" });
            }

            AppUser userLoggedIn = await _userManager.FindByNameAsync(User.Identity.Name);

            if (ModelState.IsValid == false)
            {
                return View(cbvm);
            }

            try
            {
                //find the record in the database
                AppUser dbUsers = _context.Users.Where(u => u.Email == cbvm.Email).FirstOrDefault();

                //update the notes
                dbUsers.Birthday = cbvm.NewBirthdate;

                _context.Update(dbUsers);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was an error updating this order!", ex.Message });
            }

            //send the user to the Account Index page.
            return RedirectToAction(nameof(Index));

        }


        // get for change phonenumber
        [Authorize(Roles = "Employee, Manager, Customer")]
        [HttpGet]
        public ActionResult ChangePhoneNumber(string email)
        {
            ChangePhoneNumberViewModel newpnvm = new ChangePhoneNumberViewModel();
            {
                newpnvm.Email = email;

            };

            return View(newpnvm);
        }

        // change phone number
        [Authorize(Roles = "Employee, Manager, Customer")]
        [HttpPost]
        public async Task<ActionResult> ChangePhoneNumberAsync(string id, [Bind("Email, NewPhoneNumber")] ChangePhoneNumberViewModel pnvm)
        {
            if (User.Identity.Name != pnvm.Email)
            {
                return View("Error", new String[] { "There was a problem editing this customer. Try again!" });
            }

            AppUser userLoggedIn = await _userManager.FindByNameAsync(User.Identity.Name);

            if (pnvm.NewPhoneNumber == null)
            {
                return View(pnvm);
            }


            try
            {
                //find the record in the database
                AppUser dbUsers = _context.Users.Where(u => u.Email == pnvm.Email).FirstOrDefault();

                //update the notes
                dbUsers.PhoneNumber = pnvm.NewPhoneNumber;

                _context.Update(dbUsers);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was an error updating this order!", ex.Message });
            }

            //send the user to the Account Index page.
            return RedirectToAction(nameof(Index));
        }












        //Logic for change password
        // GET: /Account/ChangePassword
        public ActionResult ChangePassword()
        {
            return View();
        }



        // POST: /Account/ChangePassword
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ChangePassword(ChangePasswordViewModel cpvm)
        {
            //if user forgot a field, send them back to 
            //change password page to try again
            if (ModelState.IsValid == false)
            {
                return View(cpvm);
            }

            //Find the logged in user using the UserManager
            AppUser userLoggedIn = await _userManager.FindByNameAsync(User.Identity.Name);

            //Attempt to change the password using the UserManager
            var result = await _userManager.ChangePasswordAsync(userLoggedIn, cpvm.OldPassword, cpvm.NewPassword);

            //if the attempt to change the password worked
            if (result.Succeeded)
            {
                //sign in the user with the new password
                await _signInManager.SignInAsync(userLoggedIn, isPersistent: false);

                //send the user back to the home page
                return RedirectToAction("Index", "Home");
            }
            else //attempt to change the password didn't work
            {
                //Add all the errors from the result to the model state
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                //send the user back to the change password page to try again
                return View(cpvm);
            }
        }

        // POST: /Account/LogOff
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LogOff()
        {
            //sign the user out of the application
            _signInManager.SignOutAsync();

            //send the user back to the home page
            return RedirectToAction("Index", "Home");
        }
    }
}