using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DSVBooking.Services;
using DSVBooking.Repository;
using DSVBooking.Model;
using System.Diagnostics;

namespace DSVBooking.Pages
{
    public class IndexModel : PageModel
    {
        private readonly RoomService _rs;
        private readonly BookService _bs;
        private readonly MovingService _ms;
        [BindProperty]
        public List<Room> Rooms { get; set; }

        private MovingService _movingService;

        public List<Booking> Bookings { get; set; }
        public MovingBetween Moveing { get; set; }
        List<Booking> _activeBookings = new List<Booking>();

        bool _isBooked = false;

        private DateTime setDate = DateTime.Now;

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, RoomService rs, BookService bs, MovingService _ms)
        {
            _logger = logger;
            Rooms = rs.GetAll();
            _rs = rs;
            Bookings = bs.GetAll();
            _bs = bs;
            Moveing = new MovingBetween();
            _movingService = _ms;
        }

        public void Vacancy()
        {
            foreach (Booking booking in Bookings)
            {
                Debug.WriteLine("idag: " + setDate.Date + "bookings: " + booking.StartDateTime.Date);
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
        public IActionResult OnPost(int idroom)
        {
            Debug.WriteLine("test" + idroom);
            
            
            Room bound = _rs.Get(idroom);







            return RedirectToPage("/Form", new { roomname = bound.Name });
        }
    }
}
