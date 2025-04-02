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

        }

        public IActionResult OnPost()
        {
            switch (Lokale)
            {
                case 1:
                    Booking.RoomID = 1;
                        break;
                case 2:
                    Booking.RoomID = 2;
                    break;
                case 3:
                    Booking.RoomID = 3;
                    break;
                case 4:
                    Booking.RoomID = 4;
                    break;
                case 5:
                    Booking.RoomID = 5;
                    break;
                case 6:
                    Booking.RoomID = 6;
                    break;
            }
            Debug.WriteLine("test " + Booking.RoomID);
            _bookService.Add(Booking);
            return RedirectToPage("/Index");
        }
    }
}
