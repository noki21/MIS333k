using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProject12.DAL;
using FinalProject12.Models;
using FinalProject12.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;


namespace FinalProject12.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;


        public MoviesController(AppDbContext context, UserManager<AppUser> userManger)
        {
            _context = context;
            _userManager = userManger;

        }


        //GET: Movies
        //public async Task<IActionResult> Index()
        //{
        //    return _context.Movies != null ?
        //                View(await _context.Movies.ToListAsync()) :
        //                Problem("Entity set 'AppDbContext.Movies'  is null.");
        //}


        public ActionResult Index(string SearchString)
        {
            var query = from m in _context.Movies

                        select m;

            if (string.IsNullOrEmpty(SearchString) == false)
            {
                query = query.Where(jp => jp.MovieName.Contains(SearchString) ||
                          jp.MovieDescription.Contains(SearchString) ||
                          jp.Tagline.Contains(SearchString) ||
                          jp.Actor.Contains(SearchString) ||
                          jp.Genre.GenreName.Contains(SearchString)
                          );

            }

            List<Movie> SelectedMovies = query.Include(jp => jp.Genre).Include(jp => jp.Schedules).Include(jp => jp.Reviews).OrderByDescending(jp => jp.Schedules.Count()).ToList();

            //Populate the view bag with a count of all job postings
            ViewBag.AllMovies = _context.Movies.Count();
            //Populate the view bag with a count of selected job postings
            ViewBag.SelectedMovies = SelectedMovies.Count();


          
            return View(SelectedMovies);
        }


        public ActionResult DetailedSearch()

        {
            ViewBag.AllGenres = GetAllGenresSelectList();

            //Set default properties by creating new instance of svm
            SearchViewModel svm = new SearchViewModel();

            return View(svm);
        }


        private SelectList GetAllGenresSelectList()
        {
            List<Genre> GenreList = _context.Genres.ToList();

            Genre SelectNone = new Genre() { GenreID = 0, GenreName = "All Genres" };

            GenreList.Add(SelectNone);

            SelectList GenreSelectList = new SelectList(GenreList.OrderBy(m => m.GenreID), "GenreID", "GenreName");

            return GenreSelectList;

        }



        [HttpGet]
        public IActionResult DisplaySearchResults(SearchViewModel svm)
        {
            Console.WriteLine("I was hit");

            var query = from j in _context.Movies
                        select j;

            if (svm.SearchTitle != null && svm.SearchTitle != "") //user entered something
            {
                query = query.Where(c => c.MovieName.Contains(svm.SearchTitle));
            }

            if (svm.SearchTagline != null && svm.SearchTagline != "")
            {
                query = query.Where(c => c.Tagline.Contains(svm.SearchTagline));
            }

            if (svm.SearchDescription != null && svm.SearchDescription != "")
            {
                query = query.Where(c => c.MovieDescription.Contains(svm.SearchDescription));
            }

            if (svm.SelectedGenre != 0)
            {
                query = query.Where(c => c.Genre.GenreID == svm.SelectedGenre);

            }

            if (svm.SelectedMPAARating != null)
            {
                query = query.Where(c => c.MPAA_Rating == svm.SelectedMPAARating);
            }

            //filter by release year
            if (svm.SearchReleaseYear != null)
            {
                query = query.Where(c => c.ReleaseYear == svm.SearchReleaseYear);
            }

            //search by actor name 
            if (svm.SearchActors != null && svm.SearchActors != "")
            {
                query = query.Where(c => c.Actor.Contains(svm.SearchActors));
            }

            if (svm.SearchRating.HasValue && svm.RatingsRange.HasValue)
            {
                var statusToCheck = Status.Approved;

                decimal searchRating = svm.SearchRating.Value;

                //AvG Movie Rating Query 
                if (svm.RatingsRange == RatingsRange.GreaterThan)
                {
                    query = query
                        .Where(c => c.Reviews
                            .Any(r => r.Status == statusToCheck) &&
                            (decimal)c.Reviews
                            .Where(r => r.Status == statusToCheck)
                            .Average(r => r.MovieRating) > searchRating);
                }
                else if (svm.RatingsRange == RatingsRange.LessThan)
                {
                    query = query
                        .Where(c => c.Reviews
                            .Any(r => r.Status == statusToCheck) &&
                            (decimal)c.Reviews
                            .Where(r => r.Status == statusToCheck)
                            .Average(r => r.MovieRating) < searchRating);
                }
            }




            //// Apply the new rating search criteria if provided






            //if (svm.SelectedDateTime != null)
            //{
            //    query = query.Where(c => c. == svm.SelectedDateTime);
            //    ViewBag.SelectedDateTime = svm.SelectedDateTime.ToString();
            //}

            //search by search rating 

            //if (svm.SearchRating != null)
            //{
            //    switch (svm.RatingsRange)
            //   {
            //       case RatingsRange.GreaterThan:
            //          query = query.Where(c => c.RatingsAvg > svm.SearchRating || c.RatingsAvg == null);
            //          break;
            //      case RatingsRange.LessThan:
            //          query = query.Where(c => c.RatingsAvg < svm.SearchRating || c.RatingsAvg == null);
            //          break;
            //       default:
            //          break;
            //    }
            // }


            // Think this is right 
            List<Movie> SelectedMovies = query.Include(Movie => Movie.Genre).Include(Movie => Movie.Reviews).ToList();

            ViewBag.AllMovies = _context.Movies.Count();
            ViewBag.SelectedMovies = SelectedMovies.Count();

            return View("Index", SelectedMovies);
        }

        public IActionResult Details(int? id)
        {
            if (id == null) //JobPostingID not specified
            {
                return View("Error", new String[] { "JobPostingID not specified - which job posting do you want to view?" });
            }

            Movie Movies = _context.Movies.Include(j => j.Genre).FirstOrDefault(j => j.MovieID == id);

            if (Movies == null) //Job posting does not exist in database
            {
                return View("Error", new String[] { "Job posting not found in database" });
            }

            //if code gets this far, all is well
            return View(Movies);
        }










        // GET: Movies/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null || _context.Movies == null)
        //    {
        //        return NotFound();
        //    }

        //    var movie = await _context.Movies
        //        .FirstOrDefaultAsync(m => m.MovieID == id);
        //    if (movie == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(movie);
        //}

        // GET: Movies/Create
        [HttpGet]
        [Authorize(Roles = "Manager")]
        public IActionResult Create()
        {
            ViewBag.AllGenres = GetAllGenres();
            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Manager")]
        public IActionResult Create([Bind("MovieID,MovieName,MovieDescription,ReleaseYear,MPAA_Rating,Runtime,Actor,Tagline")] Movie movie, int SelectedGenre, string NewGenreName)
        {

            if (ModelState.IsValid )
            {
                ViewBag.AllGenres = GetAllGenres();
                return View();
            }
            if (SelectedGenre == 0 && NewGenreName == null)
            {
                ModelState.AddModelError(string.Empty, "You must either select or create a genre!");
                ViewBag.AllGenres = GetAllGenres();
                return View();
            }
            if (SelectedGenre == 0 && NewGenreName != null)
            {
                Genre newgenre = new Genre();
                newgenre.GenreName = NewGenreName;
                _context.Genres.Add(newgenre);
                _context.SaveChanges();
                movie.Genre = newgenre;
            }

            if (SelectedGenre != 0 && NewGenreName == null)
            {
                movie.Genre = _context.Genres.Find(SelectedGenre);
            }

            if (SelectedGenre != 0 && NewGenreName != null)
            {
                return View("Error", new string[] { "Make sure to select New Genre if you would like to make a new genre!" });
            }
            try
            {
                movie.MovieNum = Utilities.GenerateMovieNumber.GetNextMovieNumber(_context);
                _context.Movies.Add(movie);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                // Log the exception (you can use a logging library or write to a log file)
                // You should also consider returning an error view or message to the user
                // Here, I'm just returning a generic error view for demonstration purposes
                return View("Error", new string[] { "An error occurred while processing your request." });
            }

        }
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(movie);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(movie);
        //}

        //// GET: Movies/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null || _context.Movies == null)
        //    {
        //        return NotFound();
        //    }

        //    var movie = await _context.Movies.FindAsync(id);
        //    if (movie == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(movie);
        //}

        // POST: Movies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MovieID,MovieName,MovieDescription,ReleaseYear,MPAA_Rating,Runtime,Actor,Tagline")] Movie movie)
        {
            if (id != movie.MovieID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieExists(movie.MovieID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        // GET: Movies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Movies == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies
                .FirstOrDefaultAsync(m => m.MovieID == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Movies == null)
            {
                return Problem("Entity set 'AppDbContext.Movies'  is null.");
            }
            var movie = await _context.Movies.FindAsync(id);
            if (movie != null)
            {
                _context.Movies.Remove(movie);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovieExists(int id)
        {
          return (_context.Movies?.Any(e => e.MovieID == id)).GetValueOrDefault();
        }


        private SelectList GetAllGenres()
        {
            List<Genre> genreList = _context.Genres.ToList();

            Genre SelectNone = new Genre() { GenreID = 0, GenreName = "New Genre" };
            genreList.Add(SelectNone);

            SelectList genreSelectList = new SelectList(genreList.OrderBy(m => m.GenreID), "GenreID", "GenreName");

            return genreSelectList;
        }
    }
}
