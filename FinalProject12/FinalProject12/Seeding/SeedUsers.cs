using Microsoft.AspNetCore.Identity;



using System;
using FinalProject12.Models;
using FinalProject12.DAL;
using FinalProject12.Utilities;

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalProject12.Seeding
{

    public static class SeedUsers
    {
        public async static Task<IdentityResult> SeedAllUsers(UserManager<AppUser> userManager, AppDbContext context)
        {

            List<AddUserModel> AllUsers = new List<AddUserModel>();


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "cbaker@example.com",
                    Email = "cbaker@example.com",
                    PhoneNumber = "152-275-7212",

                    //TODO: Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Christopher",
                    LastName = "Baker",
                    Birthday = new DateTime(1945,08,02),
                    StreetAddress = "1 David Park",
                    City = "Austin",
                    State = "TX",
                    ZipCode = 78705,
                },
                Password = "bookworm",
                RoleName = "Customer"
            }); ;

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "banker@longhorn.net",
                    Email = "banker@longhorn.net",
                    PhoneNumber = "596-211-5872",

                    //TODO: Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Michelle",
                    LastName = "Banks",
                    Birthday = new DateTime(2000,11,18),
                    StreetAddress = "10117 Swallow Road",
                    City = "Austin",
                    State = "TX",
                    ZipCode = 78712,
                },
                Password = "aclfest2017",
                RoleName = "Customer"
            }); ;

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "franco@example.com",
                    Email = "franco@example.com",
                    PhoneNumber = "756-979-6344",

                    //TODO: Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Franco",
                    LastName = "Broccolo",
                    Birthday = new DateTime(2002, 05, 02),

                    StreetAddress = "21344 Marcy Avenue",
                    City = "Austin",
                    State = "TX",
                    ZipCode = 78786,
                },
                Password = "aggies",
                RoleName = "Customer"
            }); ;

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "wchang@example.com",
                    Email = "wchang@example.com",
                    PhoneNumber = "220-613-2686",

                    //TODO: Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Wendy",
                    LastName = "Chang",
                    Birthday = new DateTime(1955, 08, 20),
                    StreetAddress = "894 Kim Junction",
                    City = "Eagle Pass",
                    State = "TX",
                    ZipCode = 78852,
                },
                Password = "alaskaboy",
                RoleName = "Customer"
            }); ;

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "limchou@gogle.com",
                    Email = "limchou@gogle.com",
                    PhoneNumber = "728-717-9608",

                    //TODO: Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Lim",
                    LastName = "Chou",
                    Birthday = new DateTime(2009, 04, 06),

                    
                    StreetAddress = "703 Anthes Lane",
                    City = "Austin",
                    State = "TX",
                    ZipCode = 78729,
                },
                Password = "allyrally",
                RoleName = "Customer"
            }); ;

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "shdixon@aoll.com",
                    Email = "shdixon@aoll.com",
                    PhoneNumber = "338-796-7818",

                    //TODO: Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Shan",
                    LastName = "Dixon",
                    Birthday = new DateTime(1989, 10, 21),
                    StreetAddress = "45927 Forest Run Trail",
                    City = "Georgetown",
                    State = "TX",
                    ZipCode = 78628,
                },
                Password = "Anchorage",
                RoleName = "Customer"
            }); ;

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "j.b.evans@aheca.org",
                    Email = "j.b.evans@aheca.org",
                    PhoneNumber = "878-921-1122",

                    //TODO: Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Jim Bob",
                    LastName = "Evans",
                    Birthday = new DateTime(2001, 10, 08),

                    StreetAddress = "51 Miller Park",
                    City = "Austin",
                    State = "TX",
                    ZipCode = 78705,
                },
                Password = "billyboy",
                RoleName = "Customer"
            }); ;

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "feeley@penguin.org",
                    Email = "feeley@penguin.org",
                    PhoneNumber = "389-364-3017",

                    //TODO: Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Lou Ann",
                    LastName = "Feeley",
                    Birthday = new DateTime(1966, 06, 19),

                    StreetAddress = "80686 Ryan Terrace",
                    City = "Austin",
                    State = "TX",
                    ZipCode = 78704,
                },
                Password = "bunnyhop",
                RoleName = "Customer"
            }); ;

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "tfreeley@minnetonka.ci.us",
                    Email = "tfreeley@minnetonka.ci.us",
                    PhoneNumber = "327-105-4962",

                    //TODO: Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Tesa",
                    LastName = "Freeley",
                    Birthday = new DateTime(1996, 09, 12),

                    StreetAddress = "97327 Express Avenue",
                    City = "College Station",
                    State = "TX",
                    ZipCode = 77840,
                },
                Password = "dustydusty",
                RoleName = "Customer"
            }); ;

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "mgarcia@gogle.com",
                    Email = "mgarcia@gogle.com",
                    PhoneNumber = "480-950-2469",

                    //TODO: Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Margaret",
                    LastName = "Garcia",
                    Birthday = new DateTime(2002, 06, 17),

                    StreetAddress = "1 Arrowood Road",
                    City = "Austin",
                    State = "TX",
                    ZipCode = 78756,
                },
                Password = "gowest",
                RoleName = "Customer"
            }); ;

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "chaley@thug.com",
                    Email = "chaley@thug.com",
                    PhoneNumber = "439-864-2291",

                    //TODO: Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Charles",
                    LastName = "Haley",
                    Birthday = new DateTime(1998, 05, 15),
                    StreetAddress = "5035 Dayton Court",
                    City = "Austin",
                    State = "TX",
                    ZipCode = 78746,
                },
                Password = "hampton1",
                RoleName = "Customer"
            }); ;

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "jeffh@sonic.com",
                    Email = "jeffh@sonic.com",
                    PhoneNumber = "287-989-2098",

                    //TODO: Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Jeffrey",
                    LastName = "Hampton",
                    Birthday = new DateTime(2003, 04, 08),


                    StreetAddress = "90461 Evergreen Place",
                    City = "Austin",
                    State = "TX",
                    ZipCode = 78756,
                },
                Password = "hickhickup",
                RoleName = "Customer"
            }); ;

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "wjhearniii@umich.org",
                    Email = "wjhearniii@umich.org",
                    PhoneNumber = "759-247-6853",

                    //TODO: Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "John",
                    LastName = "Hearn",
                    Birthday = new DateTime(2000, 09, 15),

                    StreetAddress = "973 Stephen Alley",
                    City = "Liberty",
                    State = "TX",
                    ZipCode = 77575,
                },
                Password = "ingram2015",
                RoleName = "Customer"
            }); ;

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "ahick@yaho.com",
                    Email = "ahick@yaho.com",
                    PhoneNumber = "603-447-9200",

                    //TODO: Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Anthony",
                    LastName = "Hicks",
                    Birthday = new DateTime(1980, 05, 07),

                    StreetAddress = "80319 Forster Parkway",
                    City = "San Antonio",
                    State = "TX",
                    ZipCode = 78203,
                },
                Password = "jhearn22",
                RoleName = "Customer"
            }); ;

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "ingram@jack.com",
                    Email = "ingram@jack.com",
                    PhoneNumber = "965-996-5936",

                    //TODO: Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Brad",
                    LastName = "White",
                    Birthday = new DateTime(1986, 02, 06),

                    StreetAddress = "96 Stang Hill",
                    City = "New Braunfels",
                    State = "TX",
                    ZipCode = 78132,
                },
                Password = "joejoejoe",
                RoleName = "Customer"
            }); ;

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "toddj@yourmom.com",
                    Email = "toddj@yourmom.com",
                    PhoneNumber = "171-155-1224",

                    //TODO: Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Todd",
                    LastName = "Jacobs",
                    Birthday = new DateTime(1975, 08, 29),

                    StreetAddress = "23726 Main Crossing",
                    City = "New York",
                    State = "NY",
                    ZipCode = 10101,
                },
                Password = "jrod2017",
                RoleName = "Customer"
            }); ;

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "thequeen@aska.net",
                    Email = "thequeen@aska.net",
                    PhoneNumber = "300-564-3682",

                    //TODO: Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Victoria",
                    LastName = "Lawrence",
                    Birthday = new DateTime(2001, 01, 29),

                    StreetAddress = "6299 Moland Alley",
                    City = "Lockhart",
                    State = "TX",
                    ZipCode = 78644,
                },
                Password = "longhorns",
                RoleName = "Customer"
            }); ;

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "linebacker@gogle.com",
                    Email = "linebacker@gogle.com",
                    PhoneNumber = "968-319-5113",

                    //TODO: Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Erik",
                    LastName = "Lineback",
                    Birthday = new DateTime(2004, 05, 21),

                    StreetAddress = "6 Truax Street",
                    City = "Kingwood",
                    State = "TX",
                    ZipCode = 77325,
                },
                Password = "louielouie",
                RoleName = "Customer"
            }); ;

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "elowe@netscare.net",
                    Email = "elowe@netscare.net",
                    PhoneNumber = "932-455-8010",

                    //TODO: Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Ernest",
                    LastName = "Lowe",
                    Birthday = new DateTime(2001, 12, 27),

                    StreetAddress = "50883 Heath Park",
                    City = "Beverly Hills",
                    State = "CA",
                    ZipCode = 90210,
                },
                Password = "martin1234",
                RoleName = "Customer"
            }); ;

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "michelle@example.com",
                    Email = "michelle@example.com",

                    //TODO: Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Michelle",
                    LastName = "Banks",

                },
                Password = "jVb0Z6",
                RoleName = "Employee"
            }); ;

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "toddy@aool.com",
                    Email = "toddy@aool.com",

                    //TODO: Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Todd",
                    LastName = "Jacobs",

                },
                Password = "1PnrBV",
                RoleName = "Employee"
            }); ;

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "elowe@netscrape.net",
                    Email = "elowe@netscrape.net",

                    //TODO: Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Ernest",
                    LastName = "Lowe",

                },
                Password = "v3n5AV",
                RoleName = "Employee"
            }); ;

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "mclarence@aool.com",
                    Email = "mclarence@aool.com",

                    //TODO: Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Clarence",
                    LastName = "Martin",

                },
                Password = "zBLq3S",
                RoleName = "Employee"
            }); ;

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "nelson.Kelly@aool.com",
                    Email = "nelson.Kelly@aool.com",

                    //TODO: Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Kelly",
                    LastName = "Nelson",

                },
                Password = "FSb8rA",
                RoleName = "Employee"
            }); ;

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "megrhodes@freezing.co.uk",
                    Email = "megrhodes@freezing.co.uk",

                    //TODO: Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Megan",
                    LastName = "Rhodes",

                },
                Password = "1xVfHp",
                RoleName = "Employee"
            }); ;

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "sheff44@ggmail.com",
                    Email = "sheff44@ggmail.com",

                    //TODO: Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Martin",
                    LastName = "Sheffield",

                },
                Password = "4XKLsd",
                RoleName = "Employee"
            }); ;

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "peterstump@hootmail.com",
                    Email = "peterstump@hootmail.com",

                    //TODO: Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Peter",
                    LastName = "Stump",

                },
                Password = "1XdmSV",
                RoleName = "Employee"
            }); ;

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "yhuik9.Taylor@aool.com",
                    Email = "yhuik9.Taylor@aool.com",

                    //TODO: Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Rachel",
                    LastName = "Taylor",

                },
                Password = "9yhFS3",
                RoleName = "Employee"
            }); ;

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "tuck33@ggmail.com",
                    Email = "tuck33@ggmail.com",

                    //TODO: Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Clent",
                    LastName = "Tucker",

                },
                Password = "I6BgsS",
                RoleName = "Employee"
            }); ;

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "taylordjay@aool.com",
                    Email = "taylordjay@aool.com",

                    //TODO: Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Allison",
                    LastName = "Taylor",

                },
                Password = "Vjb1wI",
                RoleName = "Employee"
            }); ;

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "jojoe@ggmail.com",
                    Email = "jojoe@ggmail.com",

                    //TODO: Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Joe",
                    LastName = "Nguyen",

                },
                Password = "xI8Brg",
                RoleName = "Employee"
            }); ;

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "hicks43@ggmail.com",
                    Email = "hicks43@ggmail.com",

                    //TODO: Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Anthony",
                    LastName = "Hicks",

                },
                Password = "s33WOz",
                RoleName = "Employee"
            }); ;

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "orielly@foxnets.com",
                    Email = "orielly@foxnets.com",

                    //TODO: Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Bill",
                    LastName = "O'Reilly",

                },
                Password = "pS2OJh",
                RoleName = "Employee"
            }); ;

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "ra@aoo.com",
                    Email = "ra@aoo.com",

                    //TODO: Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Allen",
                    LastName = "Rogers",

                },
                Password = "3wCynC",
                RoleName = "Manager"
            }); ;

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "captain@enterprise.net",
                    Email = "captain@enterprise.net",

                    //TODO: Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Jean Luc",
                    LastName = "Picard",

                },
                Password = "Pbon0r",
                RoleName = "Manager"
            }); ;

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "slayer@onegirl.net",
                    Email = "slayer@onegirl.net",

                    //TODO: Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Buffy",
                    LastName = "Summers",

                },
                Password = "jW5fPP",
                RoleName = "Manager"
            }); ;

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "liz@ggmail.com",
                    Email = "liz@ggmail.com",

                    //TODO: Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Elizabeth",
                    LastName = "Markham",

                },
                Password = "0QyilL",
                RoleName = "Manager"
            }); ;

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "twin@deservedbetter.com",
                    Email = "twin@deservedbetter.com",

                    //TODO: Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Fred",
                    LastName = "Weasley",

                },
                Password = "atLm6W",
                RoleName = "Manager"
            }); ;

            //create flag to help with errors
            String errorFlag = "Start";

            //create an identity result
            IdentityResult result = new IdentityResult();
            //call the method to seed the user
            try
            {
                foreach (AddUserModel aum in AllUsers)
                {
                    errorFlag = aum.User.Email;
                    result = await Utilities.AddUser.AddUserWithRoleAsync(aum, userManager, context);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("There was a problem adding the user with email: "
                    + errorFlag, ex);
            }

            return result;
        }
    }
}

