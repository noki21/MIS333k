using FinalProject12.DAL;
using FinalProject12.Models;
using Microsoft.SqlServer.Server;
using static System.Reflection.Metadata.BlobBuilder;

namespace FinalProject12.Seeding
{
    public static class SeedReviews
    {
        public static void SeedAllReviews(AppDbContext db)
        {
            Int32 intReviewID = 0;
            String strReviewTitle = "Begin";

            //add the list of movies
            List<Review> AllReviews = new List<Review>();

            AllReviews.Add(new Review
            {

                MovieRating = 5,
                Description = "Best movie I've ever seen.",
                Status = Status.Approved,
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Jurassic Park"),
                AppUser = db.Users.FirstOrDefault(c => c.FirstName == "Michelle" && c.LastName == "Banks")


            });

            AllReviews.Add(new Review
            {

                MovieRating = 4,
                Description = "Not bad.",
                Status = Status.Approved,
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Secret Life of Walter Mitty"),
                AppUser = db.Users.FirstOrDefault(c => c.FirstName == "Christopher" && c.LastName == "Baker")


            });

            AllReviews.Add(new Review
            {

                MovieRating = 5,
                Description = "Changed my life",
                Status = Status.Approved,
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "Jurassic Park"),
                AppUser = db.Users.FirstOrDefault(c => c.FirstName == "Brad" && c.LastName == "White")


            });

            AllReviews.Add(new Review
            {

                MovieRating = 5,
                Description = "Great family adventure movie",
                Status = Status.Approved,
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Goonies"),
                AppUser = db.Users.FirstOrDefault(c => c.FirstName == "Franco" && c.LastName == "Broccolo")


            });

            AllReviews.Add(new Review
            {

                MovieRating = 4,
                Description = "Good movie",
                Status = Status.Approved,
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Goonies"),
                AppUser = db.Users.FirstOrDefault(c => c.FirstName == "Wendy" && c.LastName == "Chang")


            });

            AllReviews.Add(new Review
            {

                MovieRating = 1,
                Description = "Worst thing I've ever seen",
                Status = Status.Approved,
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Goonies"),
                AppUser = db.Users.FirstOrDefault(c => c.FirstName == "Lim" && c.LastName == "Chou")


            });

            AllReviews.Add(new Review
            {

                MovieRating = 5,
                Description = "Reminded me of my summers in the NW",
                Status = Status.Approved,
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Goonies"),
                AppUser = db.Users.FirstOrDefault(c => c.FirstName == "Brad" && c.LastName == "White")


            });

            AllReviews.Add(new Review
            {

                MovieRating = 5,
                Description = "I love a good treasure hunt!",
                Status = Status.Pending,
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Goonies"),
                AppUser = db.Users.FirstOrDefault(c => c.FirstName == "Shan" && c.LastName == "Dixon")


            });

            AllReviews.Add(new Review
            {

                MovieRating = 3,
                Description = "Meh",
                Status = Status.Pending,
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Goonies"),
                AppUser = db.Users.FirstOrDefault(c => c.FirstName == "Jim Bob" && c.LastName == "Evans")


            });

            AllReviews.Add(new Review
            {

                MovieRating = 4,
                Status = Status.Approved,
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Hobbit: The Battle of Five Armies"),
                AppUser = db.Users.FirstOrDefault(c => c.FirstName == "Christopher" && c.LastName == "Baker")
                //fix

            });

            AllReviews.Add(new Review
            {

                MovieRating = 4,
                Status = Status.Approved,
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Hobbit: The Battle of Five Armies"),
                AppUser = db.Users.FirstOrDefault(c => c.FirstName == "Brad" && c.LastName == "White")
                //fix

            });

            AllReviews.Add(new Review
            {

                MovieRating = 5,
                Status = Status.Approved,
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Hobbit: The Battle of Five Armies"),
                AppUser = db.Users.FirstOrDefault(c => c.FirstName == "Michelle" && c.LastName == "Banks")
                //fix

            });

            AllReviews.Add(new Review
            {

                MovieRating = 5,
                Status = Status.Approved,
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Hobbit: The Battle of Five Armies"),
                AppUser = db.Users.FirstOrDefault(c => c.FirstName == "Franco" && c.LastName == "Broccolo")


            });

            AllReviews.Add(new Review
            {

                MovieRating = 1,
                Description = "Too Long",
                Status = Status.Pending,
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Hobbit: The Battle of Five Armies"),
                AppUser = db.Users.FirstOrDefault(c => c.FirstName == "Wendy" && c.LastName == "Chang")


            });

            AllReviews.Add(new Review
            {

                MovieRating = 2,
                Description = "Did they really need to drag this out into its own movie?",
                Status = Status.Pending,
                Movie = db.Movies.FirstOrDefault(c => c.MovieName == "The Hobbit: The Battle of Five Armies"),
                AppUser = db.Users.FirstOrDefault(c => c.FirstName == "Lim" && c.LastName == "Chou")


            });



            try  //attempt to add or update the book
            {
                //loop through each of the books in the list
                foreach (Review ReviewToAdd in AllReviews)
                {
                    //set the flag to the current title to help with debugging
                    strReviewTitle = ReviewToAdd.Description;

                    //look to see if the book is in the database - this assumes that no
                    //two books have the same title
                    Review dbReview = db.Reviews.FirstOrDefault(b => b.ReviewID == ReviewToAdd.ReviewID);

                    //if the dbBook is null, this title is not in the database
                    if (dbReview == null)
                    {
                        //add the book to the database and save changes
                        db.Reviews.Add(ReviewToAdd);
                        db.SaveChanges();

                        //update the counter to help with debugging
                        intReviewID += 1;
                    }
                    else //dbBook is not null - this title *is* in the database
                    {
                        //update all of the book's properties
                        dbReview.MovieRating = ReviewToAdd.MovieRating;
                        dbReview.Description = ReviewToAdd.Description;
                        dbReview.Status = ReviewToAdd.Status;
                     

                        //since we found the correct genre object in a previous step,
                        //this update is easy - both dbBook and bookToAdd have a Genre 
                        //object for this property
                        dbReview.Movie = ReviewToAdd.Movie;
                        dbReview.AppUser = ReviewToAdd.AppUser;

                        //update the database and save the changes
                        db.Update(dbReview);
                        db.SaveChanges();

                        //update the counter to help with debugging
                        intReviewID += 1;
                    } //this is the end of the else
                } //this is the end of the foreach loop for the books
            }//this is the end of the try block

            catch (Exception ex)//something went wrong with adding or updating
            {
                //Build a messsage using the flags we created
                String msg = "  Repositories added:" + intReviewID + "; Error on " + strReviewTitle;

                //throw the exception with the new message
                throw new InvalidOperationException(ex.Message + msg);
            }
        }
    }
}
