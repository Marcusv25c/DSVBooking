using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DSVBooking.Services;
using DSVBooking.Repository;
using DSVBooking.Model;
using System.Diagnostics;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace DSVBooking.Pages
{
    public class IndexModel : PageModel
    {
        private readonly RoomService _rs;
        private readonly BookService _bs;
        [BindProperty]
        public List<Room> Rooms { get; set; }

        public List<Booking> Bookings { get; set; }
        List<Booking> _activeBookings = new List<Booking>();
        
        bool _isBooked = false;
        [BindProperty]
        public int filterCap { get; set; }
        [BindProperty]
        public bool filterWB { get; set; }
        [BindProperty]
        public bool filterSB { get; set; }
        [BindProperty]
        public DateTime filterDate { get; set; }

        public DateTime setDate = DateTime.Now.Date;


        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, RoomService rs, BookService bs)
        {
            _logger = logger;
            Rooms = rs.GetAll();
            _rs = rs;
            Bookings = bs.GetAll();
            _bs = bs;
        }

        public void Vacancy()
        {
            foreach (Booking booking in Bookings)
            {
                if (booking.StartDateTime.Date == setDate.Date)
                {
                    _activeBookings.Add(booking);
                }
            }
        }

        public bool BookChecker(int hour, int roomID)
        {
            if (_activeBookings != null)
            {
                foreach (var booking in _activeBookings)
                {
                    if (hour == booking.StartDateTime.Hour && roomID == booking.RoomID)
                    {
                        _isBooked = true;
                    }
                    else if (hour == booking.EndDateTime.Hour && roomID == booking.RoomID)
                    {
                        _isBooked = false;
                    }
                }
            }
            return _isBooked;
        }
        
        public void OnGet()
        {
            Vacancy();
        }

        public IActionResult OnPostFilter()
        {
            Debug.WriteLine("fefe");
            Rooms = _rs.Filter(filterCap, filterWB, filterSB);
            return Page();
        }


        public IActionResult OnPostBook(int idroom)
        {
            Debug.WriteLine("hej");

            Room bound = _rs.Get(idroom);

            return RedirectToPage("/Form", new { roomname = bound.ID,dateroom = setDate });
        }
    }
}
