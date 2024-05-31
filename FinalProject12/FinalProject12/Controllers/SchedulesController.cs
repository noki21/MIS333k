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


namespace FinalProject12.Controllers
{
    public class SchedulesController : Controller
    {
        private readonly AppDbContext _context;

        public SchedulesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Schedules
        //public async Task<IActionResult> Index()
        //{
        //      return _context.Schedules != null ? 
        //                  View(await _context.Schedules.ToListAsync()) :
        //                  Problem("Entity set 'AppDbContext.Schedules'  is null.");
        //}

        public ActionResult Index(string SearchString)
        {

            var query = from m in _context.Schedules
                        select m;

            if (string.IsNullOrEmpty(SearchString) == false)
            {
                query = query.Where(jp => jp.Movie.MovieName.Contains(SearchString) ||
                                    jp.Movie.MovieID.Equals(SearchString)
                                    
                          //jp.MovieDescription.Contains(SearchString) ||
                          //jp.Tagline.Contains(SearchString) ||
                          //jp.Actor.Contains(SearchString) ||
                          //jp.Genre.GenreName.Contains(SearchString)


                          );

            }

            List<Schedule> SelectedSchedules = query.Include(jp => jp.Movie).Include(jp => jp.TransactionDetails).ToList();

            //List<Movie> SelectedMovies = query.Include(jp => jp.Genre).ToList();



            //Populate the view bag with a count of all job postings
            //Populate the view bag with a count of selected job postings

            return View(SelectedSchedules);
        }

        //private MultiSelectList GetAvailableSeats(TransactionDetail seat)
        //{
        //    List<string> AllSeats = new List<string> { "A1", "A2", "A3", "A4", "A5", "B1", "B2", "B3", "B4", "B5", "C1", "C2", "C3", "C4", "C5", "D1", "D2", "D3", "D4", "D5", "E1", "E2", "E3", "E4", "E5"};
        //    List<int> allSeatsID = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24};
        //    int Index = 0;

        //    return null;
        //}




        //}

        public ActionResult DetailedSearch()

        {
            //ViewBag.AllGenres = GetAllGenresSelectList();

            //Set default properties by creating new instance of svm
            SearchViewModel svm = new SearchViewModel();

            return View(svm);
        }

        [HttpGet]
        public IActionResult DisplaySearchshowtime(SearchViewModel svm)
        {
            Console.WriteLine("I was hit");

            var query = from j in _context.Schedules
                        select j;

            if (svm.SelectedDateTime != null) //user entered something
            {
                query = query.Where(c => c.StartDateTime >= svm.SelectedDateTime);
                ViewBag.SelectedDateTime = svm.SelectedDateTime.ToString();

            }

            List<Schedule> SelectedSchedules = query.Include(jp => jp.Movie).Include(jp => jp.TransactionDetails).ToList();

            //ViewBag.AllMovies = _context.Movies.Count();
            //ViewBag.SelectedMovies = SelectedMovies.Count();

            return View("Index", SelectedSchedules);

        }

        public IActionResult Details(int? id)
        {
            if (id == null) //JobPostingID not specified
            {
                return View("Error", new String[] { "ScheduleID not specified - which job posting do you want to view?" });
            }

            Schedule Schedules = _context.Schedules.Include(j => j.Movie).Include(j => j.TransactionDetails).FirstOrDefault(j => j.ScheduleID == id);

            if (Schedules == null) //Job posting does not exist in database
            {
                return View("Error", new String[] { "Schedule not found in database" });
            }

            //if code gets this far, all is well
            return View(Schedules);
        }




        // GET: Schedules/Create
        public IActionResult Create(int scheduleID)
        {
            Schedule schedule = new Schedule();
            Schedule dbSchedule = _context.Schedules.Find(scheduleID);

            ViewBag.NextWeekDays = GetAllDays();
            ViewBag.AllMovies = GetAllMovies();
            return View(schedule);
        }





        // POST: Schedules/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Schedule schedule, int SelectedMovie)
        {
            if (ModelState.IsValid)
            {
                ViewBag.AllMovies = GetAllMovies();
                return View(schedule);

           
            }

            Movie dbMovie = _context.Movies.Find(SelectedMovie);

            schedule.Movie = dbMovie;

            Schedule dbSchedule = _context.Schedules.Find(schedule.ScheduleID);

            _context.Add(schedule);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        // GET: Schedules/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Schedules == null)
            {
                return NotFound();
            }

            var schedule = await _context.Schedules.FindAsync(id);
            if (schedule == null)
            {
                return NotFound();
            }
            return View(schedule);
        }

        // POST: Schedules/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ScheduleID,StartDateTime,TheaterNumber,SpecialEvent")] Schedule schedule)
        {
            if (id != schedule.ScheduleID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(schedule);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ScheduleExists(schedule.ScheduleID))
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
            return View(schedule);
        }

        // GET: Schedules/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Schedules == null)
            {
                return NotFound();
            }

            var schedule = await _context.Schedules
                .FirstOrDefaultAsync(m => m.ScheduleID == id);
            if (schedule == null)
            {
                return NotFound();
            }

            return View(schedule);
        }

        // POST: Schedules/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Schedules == null)
            {
                return Problem("Entity set 'AppDbContext.Schedules'  is null.");
            }
            var schedule = await _context.Schedules.FindAsync(id);
            if (schedule != null)
            {
                _context.Schedules.Remove(schedule);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ScheduleExists(int id)
        {
          return (_context.Schedules?.Any(e => e.ScheduleID == id)).GetValueOrDefault();
        }


        private SelectList GetAllMovies()
        {
            List<Movie> movieList = _context.Movies.ToList();

            SelectList movieSelectList = new SelectList(movieList.OrderBy(m => m.MovieID), "MovieID", "Title");

            return movieSelectList;
        }

        private SelectList GetAllDays()
        {
            List<ScheduleViewModel> svm = new List<ScheduleViewModel>();
            List<string> nextweek = new List<string>();
            List<int> ids = new List<int> { 0, 1, 2, 3, 4, 5, 6 };
            DateTime today = DateTime.Now.Date;

            if (today.DayOfWeek == DayOfWeek.Friday)
            {
                today = today.AddDays(1);
            }

            while (today.DayOfWeek != DayOfWeek.Friday)
            {
                today = today.AddDays(1);
            }

            foreach (int value in Enumerable.Range(1, 7))
            {
                string stoday = today.ToString("MM/dd/yyyy");
                nextweek.Add(stoday);
                today = today.AddDays(1);
            }

            foreach (int id in ids)
            {
                ScheduleViewModel temp = new ScheduleViewModel();
                temp.ScheduleID = id;
                temp.ScheduleDate = nextweek[id];
                svm.Add(temp);
            }

            SelectList movieSelectList = new SelectList(svm, "ScheduleID", "ScheduleDate");

            return movieSelectList;
        }



    }
}
