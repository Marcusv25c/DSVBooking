using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DSVBooking.Services;
using DSVBooking.Repository;
using DSVBooking.Model;

namespace DSVBooking.Pages
{
    public class IndexModel : PageModel
    {
        private readonly RoomService _rs;
        private readonly BookService _bs;
        [BindProperty]
        public List<Room> Rooms { get; set; }

        public List<Booking> Bookings { get; set; }
        List<Booking> _activeBookings;

        bool _isBooked = false;

        private DateTime setDate = DateTime.Now;

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, RoomService rs, BookService bs)
        {
            _logger = logger;
            Rooms = rs.GetAll();
            _rs = rs;
            Bookings = bs.GetAll();
            _bs = bs;
        }

        public void Vancancy()
        {
            foreach (Booking booking in Bookings)
            {
                if (booking.StartDateTime.Date == setDate.Date)
                {
                    _activeBookings.Add(booking);
                }
            }
        }

        public bool BookChecker(int hour)
        {
            if (_activeBookings != null)
            {
                foreach (var booking in _activeBookings)
                {
                    if (hour == booking.StartDateTime.Hour)
                    {
                        _isBooked = true;
                    }
                    else if (hour == booking.EndDateTime.Hour)
                    {
                        _isBooked = false;
                    }
                }
            }
            return _isBooked;
        }

        public void OnGet()
        {

        }
    }
}
