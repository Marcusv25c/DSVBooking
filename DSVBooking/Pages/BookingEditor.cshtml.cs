using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DSVBooking.Services;
using DSVBooking.Repository;
using DSVBooking.Model;


namespace DSVBooking.Pages
{
    public class BookingEditorModel : PageModel
    {
        private readonly RoomService _rs;
        private readonly BookService _bs;
        [BindProperty]
        public List<Room> Rooms { get; set; }
        public List<Booking> Bookings { get; set; }

        public BookingEditorModel(BookService bs, RoomService rs)
        {
            Bookings = bs.GetAll();
            Rooms = rs.GetAll();
            _bs = bs;
            _rs = rs;
        }
        public void OnGet()
        {
        }
    }
}
