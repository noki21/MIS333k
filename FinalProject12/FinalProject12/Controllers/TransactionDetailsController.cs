using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProject12.DAL;
using FinalProject12.Models;

namespace FinalProject12.Controllers
{
    public class TransactionDetailsController : Controller
    {
        private readonly AppDbContext _context;

        public TransactionDetailsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: TransactionDetails
        public IActionResult Index(int? transactionID)
        {
            if (transactionID == null)
            {
                return View("Error", new String[] { "Please specify a transaction to view!" });
            }

            //limit the list to only the registration details that belong to this registration
            List<TransactionDetail> tds = _context.TransactionDetails
                                          .Include(rd => rd.Transaction)
                                          .Include(rd => rd.Schedule)
                                          .ThenInclude(rd => rd.Movie)
                                           //.ThenInclude(rd => rd.Price)
                                          .Where(rd => rd.Transaction.TransactionID == transactionID)
                                          .ToList();

            return View(tds);
        }



        // GET: TransactionDetails/Create
        public IActionResult Create(int transactionID)
        {
            //create a new instance of the RegistrationDetail class
            TransactionDetail td = new TransactionDetail();

            //find the registration that should be associated with this registration
            Transaction dbTransaction = _context.Transactions.Find(transactionID);

            //set the new registration detail's registration equal to the registration you just found
            td.Transaction = dbTransaction;

            //populate the ViewBag with a list of existing courses
            ViewBag.AllMovies = GetMovieSelectList();

            //pass the newly created registration detail to the view
            return View(td);
        }

        // POST: RegistrationDetails/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TransactionDetail transactiondetail, int SelectedMovie)
        {
            //if user has not entered all fields, send them back to try again
            if (ModelState.IsValid == false)
            {
                ViewBag.AllMovies = GetMovieSelectList();
                return View(transactiondetail);
            }

            //find the movie to be associated with this order
            Movie dbMovie = _context.Movies.Find(SelectedMovie);

            //set the registration detail's movie to be equal to the one we just found
            transactiondetail.Movie = dbMovie;

            //find the registration on the database that has the correct registration id
            //unfortunately, the HTTP request will not contain the entire registration object, 
            //just the registration id, so we have to find the actual object in the database
            Transaction dbTransaction = _context.Transactions.Find(transactiondetail.Transaction.TransactionID);

            //set the registration on the registration detail equal to the registration that we just found
            transactiondetail.Transaction = dbTransaction;

            //set the registration detail's price equal to the course price
            //this will allow us to to store the price that the user paid
            transactiondetail.TicketPrice = dbMovie.MoviePrice;

            //calculate the extended price for the registration detail
            transactiondetail.TotalFees = transactiondetail.Transaction.NumberOfTickets * transactiondetail.TicketPrice;

            //add the registration detail to the database
            _context.Add(transactiondetail);
            await _context.SaveChangesAsync();

            return RedirectToAction("Details", "Transactions", new { id = transactiondetail.Transaction.TransactionID });

        }



            // GET: TransactionDetails/Edit/5
            public async Task<IActionResult> Edit(int? id)
            {
                if (id == null || _context.TransactionDetails == null)
                {
                    return NotFound();
                }

                var transactionDetail = await _context.TransactionDetails.FindAsync(id);
                if (transactionDetail == null)
                {
                    return NotFound();
                }
                return View(transactionDetail);
            }

        

        // POST: TransactionDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TransactionDetailID,SeatNumber,SeniorDiscount,TuesdayDiscount,PaymentMethod,TicketPrice,PopcornPointsPerOrder")] TransactionDetail transactionDetail)
        {
            if (id != transactionDetail.TransactionDetailID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transactionDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransactionDetailExists(transactionDetail.TransactionDetailID))
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
            return View(transactionDetail);
        }

        // GET: TransactionDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TransactionDetails == null)
            {
                return NotFound();
            }

            var transactionDetail = await _context.TransactionDetails
                .FirstOrDefaultAsync(m => m.TransactionDetailID == id);
            if (transactionDetail == null)
            {
                return NotFound();
            }

            return View(transactionDetail);
        }

        // POST: TransactionDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TransactionDetails == null)
            {
                return Problem("Entity set 'AppDbContext.TransactionDetails'  is null.");
            }
            var transactionDetail = await _context.TransactionDetails.FindAsync(id);
            if (transactionDetail != null)
            {
                _context.TransactionDetails.Remove(transactionDetail);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TransactionDetailExists(int id)
        {
          return (_context.TransactionDetails?.Any(e => e.TransactionDetailID == id)).GetValueOrDefault();
        }

        private SelectList GetMovieSelectList()
        {
            //create a list for all the courses
            List<Movie> allmovies = _context.Movies.ToList();

            //the user MUST select a course, so you don't need a dummy option for no course

            //use the constructor on select list to create a new select list with the options
            SelectList slAllMovies = new SelectList(allmovies, nameof(Movie.MovieID), nameof(Movie.MovieName));

            return slAllMovies;
        }
    }
}
