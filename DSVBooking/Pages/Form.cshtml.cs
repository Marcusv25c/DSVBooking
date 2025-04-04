using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DSVBooking.Model;
using DSVBooking.Services;

namespace DSVBooking.Pages
{
    public class FormModel : PageModel
    {
        private BookService _bookService;
        [BindProperty]
        public Booking Booking { get; set; }
        public int Lokale { get; set; }

        public FormModel(BookService bs)
        {
            Booking = new Booking();
            _bookService = bs;
        }

        public void OnGet()
        {
            Booking.EndDateTime = Booking.StartDateTime.Date;
        }

        public IActionResult OnPost()
        {
            Debug.WriteLine("test " + Booking.ID);
            _bookService.Add(Booking);
            return RedirectToPage("/BookingEditor");
        }
    }
}
