using DSVBooking.Repository;
using DSVBooking.Model;
using System.Diagnostics;

namespace DSVBooking.Services
{
    public class BookService
    {
        private IBookRepository _bookRepo;

        public BookService(IBookRepository bookRepo)
        {
            //added throw to avoid null exception error
            _bookRepo = bookRepo ?? throw new ArgumentNullException(nameof(bookRepo));
        }

        public List<Booking> GetAll()
        {
            return _bookRepo.GetAll();
        }

        public void Add(Booking book)
        {
            _bookRepo.Add(book);
        }

        public void DeleteBooking(int bookingId)
        {
            _bookRepo.Delete(bookingId);
        }

        //Method to update the booking list
        public void UpdateBooking(Booking updatedBooking)
        {
            // Find the existing booking by ID
            var existingBooking = _bookRepo.GetAll().FirstOrDefault(b => b.ID == updatedBooking.ID);
            Debug.WriteLine(updatedBooking.ID);
            if (existingBooking != null)
            {
                // Replace the old booking's values with the new ones
                existingBooking.StartDateTime = updatedBooking.StartDateTime;
                existingBooking.EndDateTime = updatedBooking.EndDateTime;
                existingBooking.Comment = updatedBooking.Comment;

                // In a real scenario, you might save changes to a database here
            }
        }
    }
}
