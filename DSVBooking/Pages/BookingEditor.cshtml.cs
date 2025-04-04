using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DSVBooking.Services;
using DSVBooking.Repository;
using DSVBooking.Model;
using System.Diagnostics;

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

        //method for deleting bookings
        public IActionResult OnPostDeleteBooking(int bookingId)
        {
            // Call the service to delete the booking
            _bs.DeleteBooking(bookingId);

            // Redirect back to the page to refresh the list of bookings
            return RedirectToPage();
        }

        //method for editing bookings
        public IActionResult OnPostEditBooking(int bookingId, DateTime startDateTime, DateTime endDateTime, string comment, int roomId)
        {
            // Find the booking by ID
            Debug.WriteLine(bookingId);
            var bookingToUpdate = Bookings.FirstOrDefault(b => b.ID == bookingId);
            
            if (bookingToUpdate != null)
            {
                // Replace the old booking with the updated one
                bookingToUpdate.StartDateTime = startDateTime;
                bookingToUpdate.EndDateTime = endDateTime;
                bookingToUpdate.Comment = comment;
                bookingToUpdate.RoomID = roomId;
            }

            // Save changes to the repository or perform other necessary actions
            _bs.UpdateBooking(bookingToUpdate);

            // Redirect back to the page to refresh the list
            return RedirectToPage();
        }
    }
}
