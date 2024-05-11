using Labb4Book.Data;
using Labb4Book.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Labb4Book.Controllers
{
    public class CustomersBooksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomersBooksController(ApplicationDbContext context)
        {
            _context = context;
        }
        //GET: CustomersBooks
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var customerBooks = await _context.CustomerBooks
                .Include(cb => cb.Customer)
                .Include(c => c.Book)
                .Where(cb => !cb.IsReturned)
                .ToListAsync();

            return View(customerBooks);
        }
        //GET: CustomersBooks/Create
        [HttpGet]

        public IActionResult Create()
        {
            ViewData["FkCustomerId"] = new SelectList(_context.Customers, "CustomerId", "CutsomerFirstName");
            ViewData["FkBookId"] = new SelectList(_context.Books, "BookId", "Title");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(int? customerId, int? bookId, DateTime rentDate, DateTime returnDate)
        {
            if(customerId != null && bookId != null)
            {
                var rentedBookByCustomer = new CustomerBook
                {
                    FkCustomerId = customerId.Value,
                    FkBookId = bookId.Value,
                    BookRentDate = rentDate.Date,
                    BookReturnDate = returnDate.Date,
                    IsReturned = false
                };
                _context.CustomerBooks.Add(rentedBookByCustomer);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();
        }
        //GET: CustomerBook/Return/5
        [HttpGet]
        public async Task<IActionResult> Return(int? customerId, int? bookId)
        {
            if(customerId == null || bookId == null)
            {
                return NotFound();
            }
            var customer = await _context.CustomerBooks
                .Include(c=>c.Book)
                .Include(b=>b.Customer)
                .FirstOrDefaultAsync(c=>c.Customer.CustomerId == customerId && c.FkBookId == bookId);
            if(customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }
        //POST: CutomersBooks/Return/5
        [HttpPost]
        public async Task<IActionResult> Return(int? customerId,int? bookId, CustomerBook customerBook)
        {
            var customer = await _context.CustomerBooks.FirstOrDefaultAsync(c => c.Customer.CustomerId == customerId && c.FkBookId == bookId);
            
            if (customer == null)
            {
                return NotFound();
            }

            customer.IsReturned = true;
            customer.ReturnedAt = DateTime.Now;

            _context.Update(customer);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        //GET: CustomerBooks/ReturnedBooks
        [HttpGet]
        public async Task<IActionResult> ReturnedBooks()
        {
            var customerBooks = await _context.CustomerBooks
                .Include(cb => cb.Customer)
                .Include(c => c.Book)
                .Where(cb => cb.IsReturned)
                .ToListAsync();

            return View(customerBooks);
        }
    }
}
