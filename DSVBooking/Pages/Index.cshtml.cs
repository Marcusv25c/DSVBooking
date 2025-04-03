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
        public DateOnly filterDate { get; set; }

        bool dateIsSet = false;


        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, RoomService rs, BookService bs)
        {
            if(!dateIsSet)
                filterDate = DateOnly.FromDateTime(DateTime.Now.Date);

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
                DateOnly tempBookDate = DateOnly.FromDateTime(booking.StartDateTime);
                if (tempBookDate == filterDate)
                {
                    _activeBookings.Add(booking);
                    Debug.WriteLine(booking.ID + " added to activebookings");

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
                        Debug.WriteLine("BookChecker: true");
                    }
                    else if (hour == booking.EndDateTime.Hour && roomID == booking.RoomID)
                    {
                        _isBooked = false;
                        Debug.WriteLine("BookChecker: false");

                    }
                }
            }
            return _isBooked;
        }
        
        public void OnGet()
        {
            Vacancy();
        }

        public void OnPostFilter()
        {
            if (filterDate != DateOnly.FromDateTime(DateTime.Now.Date))
                dateIsSet = true;
            Debug.WriteLine(filterDate);
            Rooms = _rs.Filter(filterCap, filterWB, filterSB);
            Vacancy();
        }


        public IActionResult OnPostBook(int idroom,DateOnly dateroom)
        {
            Debug.WriteLine("hej");

            Room bound = _rs.Get(idroom);
            
            Debug.WriteLine("onPostBook " + dateroom);
            return RedirectToPage("/Form", new { roomname = bound.ID,roomdate =dateroom });
        }
    }
}
