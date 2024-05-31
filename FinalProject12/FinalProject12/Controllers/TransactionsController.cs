using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject12.DAL;
using FinalProject12.Models;
using FinalProject12.Utilities;


namespace FinalProject12.Controllers
{
    [Authorize]
    public class TransactionsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public TransactionsController(AppDbContext context, UserManager<AppUser> userManger)
        {
            _context = context;
            _userManager = userManger;
        }

        // GET: Transactions
        public IActionResult Index()
        {
            //Set up a list of registrations to display
            List<Transaction> transactions;

            //User.IsInRole -- they see ALL registrations and detail
            if (User.IsInRole("Manager"))
            {
                transactions = _context.Transactions
                               .Include(r => r.TransactionDetails)
                               .ThenInclude(r => r.Schedule)
                               .ThenInclude(r => r.Movie)
                               .Include(r => r.TransactionDetails)
                               .ThenInclude(r => r.Schedule)
                               .ThenInclude(r => r.Price)
                               .ToList();
            }
            else //user is a customer, so only display their records
            //registration is assocated with a particular user (look on the registration model class)
            //every logged in user is allowed to access index page, but their results will be different
            {
                transactions = _context.Transactions
                               .Include(r => r.TransactionDetails)
                               .ThenInclude(r => r.Movie)
                               .Include(r => r.TransactionDetails)
                               .ThenInclude(r => r.Schedule)
                               .ThenInclude(r => r.Price)
                               .Where(r => r.AppUser.UserName == User.Identity.Name)
                               .ToList();
            }

            return View(transactions);
        }


        // GET: Transactions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            //the user did not specify a registration to view
            if (id == null)
            {
                return View("Error", new String[] { "Please specify a transaction to view!" });
            }

            //find the registration in the database
            Transaction transaction = await _context.Transactions
                                              .Include(r => r.TransactionDetails)
                                              .Include(r => r.AppUser)
                                              .ThenInclude(r => r.Reviews)
                                              .ThenInclude(r => r.Movie)
                                              .ThenInclude(r => r.Schedules)
                                              .ThenInclude(r => r.Price)
                                              .FirstOrDefaultAsync(m => m.TransactionID == id);

            //registration was not found in the database
            if (transaction == null)
            {
                return View("Error", new String[] { "This transaction was not found!" });
            }

            //make sure this registration belongs to this user
            if (User.IsInRole("Customer") && transaction.AppUser.UserName != User.Identity.Name)
            {
                return View("Error", new String[] { "This is not your transaction!  Don't be such a snoop!" });
            }

            //Send the user to the details page
            return View(transaction);
        }

        //only customer can purchase a movie
        [Authorize(Roles = "Customer")]
        public IActionResult AddtoCart(int? movieID)
        {
            if (movieID == null)
            {
                return View("Error", new string[] { "Please specify a movie to add to your order" });
            }

            Movie dbMovie = _context.Movies.Find(movieID);

            if (dbMovie == null)
            {
                return View("Error", new string[] { "This movie is not in the database" });

            }

            Transaction transaction = _context.Transactions.FirstOrDefault(r => r.AppUser.UserName == User.Identity.Name && r.TransactionStatus == TransactionStatus.Cancelled);

            if (transaction == null)
            {
                transaction = new Transaction();

                transaction.TransactionStatus = TransactionStatus.Cancelled;
                transaction.OrderDate = DateTime.Now;
                transaction.TransactionNumber = GeneratedTransactionNumber.GetNextGeneratedTransactionNumber(_context);
                transaction.AppUser = _context.Users.FirstOrDefault(r => r.UserName == User.Identity.Name);

                _context.Transactions.Add(transaction);
                _context.SaveChanges();
            }

            //create transaction detail
            TransactionDetail td = new TransactionDetail();

            td.Schedule.Movie = dbMovie;
            td.Transaction = transaction;

            ////you can assume the quantity is zero - they can edit it later
            td.Transaction.NumberOfTickets = 1;


            ////calculate the properties on the regdetails, need to fix this 

            //td.TicketPrice = dbMovie.TransactionDetails.TicketPrice;

            td.TicketPrice = dbMovie.MoviePrice;
            td.TotalFees = dbMovie.MoviePrice * td.Transaction.NumberOfTickets;

            _context.TransactionDetails.Add(td);
            _context.SaveChanges(true);

            return RedirectToAction("Details", new { id = transaction.TransactionID });

        }


        // GET: Transactions/Create
        [HttpGet]
        [Authorize]

        public async Task<IActionResult> Create()
        {
            if (User.IsInRole("Customer"))
            {
                Transaction txn = new Transaction();
                txn.AppUser = await _userManager.FindByNameAsync(User.Identity.Name);
                return View(txn);
            }

            else
            {
                ViewBag.UserNames = await GetAllCustomerUserNamesSelectList();
                return View("SelectCustomerForTransaction");
            }
        }

        // POST: Transactions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create([Bind("TransactionID,NumberOfTickets,OrderDate,OrderSubtotal,PopcornPoints,TransactionStatus")] Transaction transaction)
        
        {
            transaction.TransactionNumber = Utilities.GeneratedTransactionNumber.GetNextGeneratedTransactionNumber(_context);

            transaction.OrderDate = DateTime.Now;

            //Associate the txn with the logged-in customer
            transaction.AppUser = await _userManager.FindByNameAsync(User.Identity.Name);

        //if code gets this far, add transaction to database
            _context.Add(transaction);
            await _context.SaveChangesAsync();

            //send the user on to the action that will allow them to 
            //create a registration detail.  Be sure to pass along the RegistrationID
            //that you created when you added the registration to the database above
            return RedirectToAction("Create", "TransactionDetails", new { transactionID = transaction.TransactionID });
        }


// GET: Transactions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Transactions == null)
            {
                return NotFound();
            }

            var transaction = await _context.Transactions.FindAsync(id);
            if (transaction == null)
            {
                return NotFound();
            }
            return View(transaction);
        }

        // POST: Transactions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TransactionID,NumberOfTickets,OrderDate,OrderSubtotal,PopcornPoints,TransactionStatus")] Transaction transaction)
        {
            if (id != transaction.TransactionID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transaction);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransactionExists(transaction.TransactionID))
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
            return View(transaction);
        }

        // GET: Transactions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Transactions == null)
            {
                return NotFound();
            }

            var transaction = await _context.Transactions
                .FirstOrDefaultAsync(m => m.TransactionID == id);
            if (transaction == null)
            {
                return NotFound();
            }

            return View(transaction);
        }

        // POST: Transactions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Transactions == null)
            {
                return Problem("Entity set 'AppDbContext.Transactions'  is null.");
            }
            var transaction = await _context.Transactions.FindAsync(id);
            if (transaction != null)
            {
                _context.Transactions.Remove(transaction);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TransactionExists(int id)
        {
            return (_context.Transactions?.Any(e => e.TransactionID == id)).GetValueOrDefault();
        }

        [Authorize]
        public async Task<IActionResult> CheckoutTransaction(int? id)
        {
            if (id == null)
            {
                return View("Error", new String[] { "Please specify a transaction to view!" });
            }

            //find transaction in database
            Transaction txn = await _context.Transactions
                                              .Include(r => r.TransactionDetails)
                                              .Include(r => r.AppUser)
                                              .ThenInclude(r => r.Reviews)
                                              .ThenInclude(r => r.Movie)
                                              .FirstOrDefaultAsync(m => m.TransactionID == id);

            //if txn not found in databse
            if (txn == null)
            {
                return View("Error", new String[] { "This transaction was not found" });
            }

            if (User.IsInRole("Customer") && txn.AppUser.UserName != User.Identity.Name)
            {
                return View("Error", new String[] { "This is not your order" });
            }
            //send user to confirm view
            return View("Confirm", txn);
        }

        public async Task<IActionResult> Confirm(int? id)
        {
            Transaction dbTxn = await _context.Transactions.FindAsync(id);
            dbTxn.TransactionStatus = TransactionStatus.Purchased;
            _context.Update(dbTxn);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }





        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> SelectCustomerForTransaction(String SelectedCustomer)
        {
            if (String.IsNullOrEmpty(SelectedCustomer))
            {
                ViewBag.UserNames = await GetAllCustomerUserNamesSelectList();
                return View("SelectCustomerForTransaction");
            }

            Transaction txn = new Transaction();
            txn.AppUser = await _userManager.FindByNameAsync(SelectedCustomer);
            return View("Create", txn);
        }

        public async Task<SelectList> GetAllCustomerUserNamesSelectList()
        {
            //create a list to hold the customers
            List<AppUser> allCustomers = new List<AppUser>();

            //See if the user is a customer
            foreach (AppUser dbUser in _context.Users)
            {
                //if the user is a customer, add them to the list of customers
                if (await _userManager.IsInRoleAsync(dbUser, "Customer") == true)//user is a customer
                {
                    allCustomers.Add(dbUser);
                }
            }

            //create a new select list with the customer emails
            SelectList sl = new SelectList(allCustomers.OrderBy(c => c.Email), nameof(AppUser.UserName), nameof(AppUser.Email));

            //return the select list
            return sl;


        }
    }

}