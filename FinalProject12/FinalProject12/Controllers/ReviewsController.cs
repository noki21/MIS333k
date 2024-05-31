using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProject12.DAL;
using FinalProject12.Models;
using Microsoft.AspNetCore.Identity;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using Microsoft.AspNetCore.Authorization;

namespace FinalProject12.Controllers
{
    public class ReviewsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;


        public ReviewsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Reviews

        public IActionResult Index()
        {
            // Retrieve all reviews from the database
            var reviews = _context.Reviews.Include(r => r.AppUser).Include(r => r.Movie).ToList();


            // Pass the reviews to the view
            return View(reviews);
        }

        [HttpGet]
        public IActionResult Create()
        {
        ViewBag.AllMovies = new SelectList(_context.Movies, "MovieID", "MovieName");
        return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReviewID,MovieRating,Description,SelectedMovieID")] Review movieReview, int SelectedMovieID)
        {
            // No need for any checks, just proceed with creating the review

            if (ModelState.IsValid == false)
            {
                // Set ViewBag.SelectedMovieID to a SelectList of movies
                var movies = _context.Movies.ToList();
                ViewBag.SelectedMovieID = new SelectList(movies, "MovieID", "MovieName");

                return View(movieReview);
            }

            // Set the Movie navigation property based on the selected movie
            movieReview.Movie = _context.Movies.Find(SelectedMovieID);

            // Add the new review to the database context
            _context.Reviews.Add(movieReview);

            // Save changes to the database
            await _context.SaveChangesAsync();

            // Redirect to the desired action after successfully creating the review
            return RedirectToAction("Index");
        }








        //[HttpGet]
        //public IActionResult Create()
        //{
        //    ViewBag.AllMovies = new SelectList(_context.Movies, "MovieID", "MovieName");
        //    return View();
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("ReviewID,MovieRating,Description,SelectedMovieID")] Review movieReview, int SelectedMovieID)
        //{
        //    List<Transaction> pasttransactions = _context.Transactions.Include(o => o.TransactionDetails).ThenInclude(o => o.Schedule).ThenInclude(o => o.Movie).ToList();
        //    bool check = false;
        //    foreach (Transaction transaction in pasttransactions)
        //    {
        //        foreach (TransactionDetail transactiondetail in transaction.TransactionDetails)
        //        {
        //            if (transactiondetail?.Schedule?.Movie?.MovieID == SelectedMovieID &&
        //                transactiondetail?.Schedule?.EndDateTime < DateTime.Now)
        //            {
        //                check = true;
        //                break;
        //            }
        //        }
        //        if (check == true)
        //        {
        //            break;
        //        }
        //    }


        //    if (check == false)
        //    {
        //        return View("Error", new String[] { "You have not watched this movie yet, or have not watched this movie with us; please do that first!" });
        //    }

        //    List<Review> userreviews;
        //    userreviews = _context.Reviews.Include(mr => mr.Movie).Where(m => m.AppUser.UserName == User.Identity.Name).ToList();
        //    if (userreviews.Count() != 0)
        //    {
        //        foreach (Review review in userreviews)
        //        {
        //            if (review.Movie.MovieID == SelectedMovieID)
        //            {
        //                return View("Error", new String[] { "You have already created a review for this movie!!" });
        //            }
        //        }
        //    }

        //    if (ModelState.IsValid == false)
        //    {
        //        // Set ViewBag.SelectedMovieID to a SelectList of movies
        //        var movies = _context.Movies.ToList();
        //        ViewBag.SelectedMovieID = new SelectList(movies, "MovieID", "MovieName");

        //        return View(movieReview);
        //    }

        //    Movie dbMovie = _context.Movies.Find(SelectedMovieID);

        //    movieReview.Movie = dbMovie;
        //    movieReview.Status = Status.Pending;
        //    movieReview.AppUser = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);

        //    _context.Add(movieReview);
        //    await _context.SaveChangesAsync();

        //    return RedirectToAction(nameof(Index));

        //}

        [Authorize(Roles = "Employee, Manager, Customer")]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            // Retrieve the existing review from the database
            Review existingReview = _context.Reviews.FirstOrDefault(r => r.ReviewID == id);

            // Check if the review exists
            if (existingReview == null)
            {
                return View("Error", new String[] { "Review not found. Try again!" });
            }

            // Check if the current user is authorized to edit the review
            //if (User.Identity.Name != existingReview?.AppUser?.UserName)
            //{
            //return View("Error", new String[] { "You are not authorized to edit this review!" });
            //}

            return View(existingReview);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReviewID,MovieRating,Description,Status")] Review editedReview)
        {
            // Retrieve the original review from the database
            Review originalReview = _context.Reviews.FirstOrDefault(r => r.ReviewID == id);

            // Check if the original review exists
            if (originalReview == null)
            {
                return View("Error", new String[] { "Review not found. Try again!" });
            }

            // Check if the current user is authorized to edit the review
            //if (User.Identity.Name != originalReview?.AppUser?.UserName)
            //{
                //return View("Error", new String[] { "You are not authorized to edit this review!" });
            //}

            // Update the review properties
            originalReview.MovieRating = editedReview.MovieRating;
            originalReview.Description = editedReview.Description;
            originalReview.Status = editedReview.Status;

            // Save changes to the database
            await _context.SaveChangesAsync();

            // Redirect to the index or details view
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Retrieve the review from the database
            var review = _context.Reviews.FirstOrDefault(r => r.ReviewID == id);

            if (review == null)
            {
                return NotFound();
            }

            return View(review);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movieReview = await _context.Reviews
                .FirstOrDefaultAsync(m => m.ReviewID == id);
            if (movieReview == null)
            {
                return View("Error", new String[] { "This movie review was not found. Try creating a review instead!" });
            }


            return View(movieReview);
        }

        // POST: MovieReviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movieReview = await _context.Reviews.FindAsync(id);
            _context.Reviews.Remove(movieReview);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }





    }





    // GET: MovieReviews/Create
    //public IActionResult Create()
    //{
    //    ViewBag.AllMovies = GetWatchedMovies();
    //    return View();
    //}

    //// POST: MovieReviews/Create
    //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
    //// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    //[HttpPost]
    //[ValidateAntiForgeryToken]
    //public async Task<IActionResult> Create([Bind("MovieReviewID,MovieRating,ReviewDescription,SelectedMovieID")] MovieReview movieReview, int SelectedMovieID)
    //{
    //    List<TransactionDetail> Past_Orders = _context.TransactionDetails.Include(o => o.Transaction).ThenInclude(o => o.Showing).ThenInclude(o => o.Movie).ToList();
    //    bool check = false;
    //    foreach (Transaction transaction in Past_Orders)
    //    {
    //        foreach (Transaction trasaction in TransactionDetail.Transaction)
    //        {
    //            if (ticket.Showing.Movie.MovieID == SelectedMovieID && transaction.Schedule.EndDateTime < DateTime.Now)
    //            {
    //                check = true;
    //                break;
    //            }
    //        }
    //        if (check == true)
    //        {
    //            break;
    //        }
    //    }


    //    if (check == false)
    //    {
    //        return View("Error", new String[] { "You have not watched this movie yet, or have not watched this movie with us; please do that first!" });
    //    }

    //    List<MovieReview> userreviews;
    //    userreviews = _context.MovieReviews.Include(mr => mr.Movie).Where(m => m.User.UserName == User.Identity.Name).ToList();
    //    if (userreviews.Count() != 0)
    //    {
    //        foreach (MovieReview review in userreviews)
    //        {
    //            if (review.Movie.MovieID == SelectedMovieID)
    //            {
    //                return View("Error", new String[] { "You have already created a review for this movie!!" });
    //            }
    //        }
    //    }

    //    if (ModelState.IsValid == false)
    //    {
    //        return View(movieReview);
    //    }

    //    Movie dbMovie = _context.Movies.Find(SelectedMovieID);

    //    movieReview.Movie = dbMovie;
    //    movieReview.Status = MRStatus.WIP;
    //    movieReview.User = _userManager.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);

    //    _context.Add(movieReview);
    //    await _context.SaveChangesAsync();

    //    return RedirectToAction("Details", "MovieReviews", new { id = movieReview.MovieReviewID });
    //}


















    ////public async Task<IActionResult> Details(int? id)
    ////{
    ////    if (id == null || _context.Reviews == null)
    ////    {
    ////        return NotFound();
    ////    }

    ////    var review = await _context.Reviews
    ////        .FirstOrDefaultAsync(m => m.ReviewID == id);
    ////    if (review == null)
    ////    {
    ////        return NotFound();
    ////    }

    ////    return View(review);
    ////}

    //// GET: Reviews/Create
    ////public IActionResult Create()
    ////{
    ////    ViewBag.AllMovies = GetMoviesSeen();
    ////    return View();
    ////}

    //// POST: Reviews/Create
    //// To protect from overposting attacks, enable the specific properties you want to bind to.
    //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    //[HttpPost]
    //[ValidateAntiForgeryToken]
    //public async Task<IActionResult> Create([Bind("ReviewID,MovieRating,Description,Status")] Review review)
    //{
    //    //TO DO uncomment
    //    //List<Transaction> pastorders = _context.Transactions.Include(o => o.Tickets).ThenInclude(o => o.Showing).ThenInclude(o => o.Movie).ToList();

    //    if (ModelState.IsValid)
    //    {
    //        _context.Add(review);
    //        await _context.SaveChangesAsync();
    //        return RedirectToAction(nameof(Index));
    //    }
    //    return View(review);
    //}

    //// GET: Reviews/Edit/5
    //public async Task<IActionResult> Edit(int? id)
    //{
    //    if (id == null || _context.Reviews == null)
    //    {
    //        return NotFound();
    //    }

    //    var review = await _context.Reviews.FindAsync(id);
    //    if (review == null)
    //    {
    //        return NotFound();
    //    }
    //    return View(review);
    //}

    //// POST: Reviews/Edit/5
    //// To protect from overposting attacks, enable the specific properties you want to bind to.
    //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    //[HttpPost]
    //[ValidateAntiForgeryToken]
    //public async Task<IActionResult> Edit(int id, [Bind("ReviewID,MovieRating,Description,Status")] Review review)
    //{
    //    if (id != review.ReviewID)
    //    {
    //        return NotFound();
    //    }

    //    if (ModelState.IsValid)
    //    {
    //        try
    //        {
    //            _context.Update(review);
    //            await _context.SaveChangesAsync();
    //        }
    //        catch (DbUpdateConcurrencyException)
    //        {
    //            if (!ReviewExists(review.ReviewID))
    //            {
    //                return NotFound();
    //            }
    //            else
    //            {
    //                throw;
    //            }
    //        }
    //        return RedirectToAction(nameof(Index));
    //    }
    //    return View(review);
    //}

    //// GET: Reviews/Delete/5
    //public async Task<IActionResult> Delete(int? id)
    //{
    //    if (id == null || _context.Reviews == null)
    //    {
    //        return NotFound();
    //    }

    //    var review = await _context.Reviews
    //        .FirstOrDefaultAsync(m => m.ReviewID == id);
    //    if (review == null)
    //    {
    //        return NotFound();
    //    }

    //    return View(review);
    //}

    //// POST: Reviews/Delete/5
    //[HttpPost, ActionName("Delete")]
    //[ValidateAntiForgeryToken]
    //public async Task<IActionResult> DeleteConfirmed(int id)
    //{
    //    var movieReview = await _context.Reviews.FindAsync(id);
    //    _context.Reviews.Remove(movieReview);
    //    await _context.SaveChangesAsync();
    //    return RedirectToAction(nameof(Index));
    //}

    //private bool ReviewExists(int id)
    //{
    //    return (_context.Reviews?.Any(e => e.ReviewID == id)).GetValueOrDefault();
    //}

    //public SelectList GetWatchedMovies()
    //{
    //    List<Transaction> pastorders = _context.Transactions.Include(o => o.TransactionDetails).ThenInclude(o => o.Schedule).ThenInclude(o => o.Movie).Where(o => o.AppUser.UserName == User.Identity.Name).Where(o => o.OrderHistory == OrderHistory.Past).ToList();
    //    List<Movie> watchedmovies = new List<Movie>();
    //    foreach (Order order in pastorders)
    //    {
    //        foreach (Ticket ticket in order.Tickets)
    //        {
    //            if (watchedmovies.Contains(ticket.Showing.Movie) == false && ticket.Showing.EndDateTime < DateTime.Now)
    //            {
    //                watchedmovies.Add(ticket.Showing.Movie);
    //            }
    //        }
    //    }

    //    SelectList movieSelectList = new SelectList(watchedmovies.OrderBy(m => m.MovieID), "MovieID", "Title");

    //    return movieSelectList;




    //}
}


