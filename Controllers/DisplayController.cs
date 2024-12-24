using Biblio;
using Library.Data;
using Library.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
 
    public class DisplayController : Controller
    {
        private readonly ApplicationDbContext _dbContext; // Update with your DbContext
        private readonly IHttpContextAccessor _httpContext;
        public DisplayController(ApplicationDbContext dbContext, IHttpContextAccessor httpContext)
        {
            _dbContext = dbContext;
            _httpContext = httpContext;
        }

        public IActionResult Index(string filter, string categoryFilter)
        {
            var booksQuery = _dbContext.Livre.AsQueryable();

            // Filter by title or author
            if (!string.IsNullOrEmpty(filter))
            {
                booksQuery = booksQuery.Where(b => b.titre_l.Contains(filter) );
            }

            // Filter by category

            var books = booksQuery.ToList();
            return View(books);
        }

        public IActionResult Details(int id)
        {
             
            
                Livre document = _dbContext.Livre.FirstOrDefault(d => d.id_l == id);
                if (document == null)
                {
                    return NotFound(); // or handle the case where the document is not found
                }
                return View(document);
          
        }
        [HttpPost]
        public IActionResult Reserve(int documentId, int reservationDays)
        {
            // Retrieve the Document from the database
            var document = _dbContext.Livre.FirstOrDefault(d => d.id_l == documentId);

            if (document == null)
            {
                // Handle the case where the document is not found
                return NotFound();
            }

            // Check if the document is available
            if (true)
            {

               
                var subscriberId = _httpContext.HttpContext.Session.GetInt32("UserId");

                // Create a Reservation object
                var reservation = new Emprunt
                {
                    id_inscrit = subscriberId.Value,
                    date_emprunt = DateTime.Today,
                };

                // Calculate ReturnDate based on the ReservedDate and the user-provided reservation period
                reservation.date_delai = reservation.date_emprunt.AddDays(reservationDays);
                reservation.id_l = document.id_l;

                // Save the Reservation to the database
                _dbContext.Emprunt.Add(reservation);
                _dbContext.SaveChanges();

                // Update the Document with the Reservation information
          

                _dbContext.SaveChanges();
                return RedirectToAction("Index"); // Redirect to the appropriate action after reservation
            }

            // Handle the case where the document is not available
            return RedirectToAction("Details", new { id = documentId }); // Redirect back to the Details view
        }
    }
}
