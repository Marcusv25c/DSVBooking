using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DSVBooking.Model;
using DSVBooking.Services;

namespace DSVBooking.Pages
{
    public class FormModel : PageModel
    {
        private readonly MovingService _ms;
        private MovingService _moveingService;
        private BookService _bookService;
        [BindProperty]
        public Booking Booking { get; set; }
        public MovingBetween Moving { get; set; }

        public FormModel(BookService bs,MovingService _ms)
        {
            Booking = new Booking();
            _bookService = bs;
            _moveingService = _ms;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            Debug.WriteLine("test " + Booking.ID);
            _bookService.Add(Booking);
            return RedirectToPage("/BookingEditor");
        }
    }
}
