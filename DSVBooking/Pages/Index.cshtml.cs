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

        int filterCap = 0;
        bool filterWB = false;
        bool filterSB = false;

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

        public void Filter(int cap, bool wb, bool sb)
        {
            List<Room> filterRooms = new List<Room>();
            Rooms = _rs.Filter(cap, wb, sb);
        }

        public IActionResult OnPost()
        {
            _movingService.Add(Moveing);
            return RedirectToPage("/Form");
        }
    }
}
