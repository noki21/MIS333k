using System;
using FinalProject12.Models;
using FinalProject12.DAL;
using Microsoft.SqlServer.Server;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;


//TODO:Make these namespaces match your project name
using FinalProject12.Models;
using FinalProject12.DAL;
using System.Text;

//TODO:Make this namespace match your project name
namespace FinalProject12.Seeding
{
    //make this class static so you can use the dbContext
    public static class SeedGenres
    {
        //You will call this method from the SeedController to add categories
        public static void SeedAllGenres(AppDbContext db)
        {
            Int32 intGenreID = 0;
            String strGenreName = "Begin";

            List<Genre> AllGenres = new List<Genre>();
            Genre g1 = new Genre()
            {
                GenreName = "Drama"
            };
            AllGenres.Add(g1);

            Genre g2 = new Genre()
            {
                GenreName = "Children and Family"
            };
            AllGenres.Add(g2);

            Genre g3 = new Genre()
            {
                GenreName = "Action"
            };
            AllGenres.Add(g3);

            Genre g4 = new Genre()
            {
                GenreName = "Romance"
            };
            AllGenres.Add(g4);



            Genre g5 = new Genre()
            {
                GenreName = "Musical"
            };
            AllGenres.Add(g5);


            Genre g6 = new Genre()
            {
                GenreName = "Science Fiction"
            };
            AllGenres.Add(g6);

            Genre g7 = new Genre()
            {
                GenreName = "Comedy"
            };
            AllGenres.Add(g7);

            Genre g8 = new Genre()
            {
                GenreName = "Horror"
            };
            AllGenres.Add(g8);


            try
            {
                //loop through each of the categories
                foreach (Genre seedGenre in AllGenres)
                {
                    //updates the counters to get info on where the problem is
                    intGenreID = seedGenre.GenreID;
                    strGenreName = seedGenre.GenreName;

                    //try to find the category in the database
                    Genre dbGenre = db.Genres.FirstOrDefault(c => c.GenreName == seedGenre.GenreName);

                    //if the category isn't in the database, dbCategory will be null
                    if (dbGenre == null)
                    {
                        //add the Category to the database
                        db.Genres.Add(seedGenre);
                        db.SaveChanges();
                    }
                    else //the record is in the database
                    {
                        //update all the fields
                        //this isn't really needed for category because it only has one field
                        //but you will need it to re-set seeded data with more fields
                        dbGenre.GenreName = seedGenre.GenreName;
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
                msg.Append(strGenreName);
                msg.Append(" Genre (GenreID = ");
                msg.Append(intGenreID);
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
