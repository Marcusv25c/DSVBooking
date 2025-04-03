using DSVBooking.Model;
using System.Reflection.Metadata.Ecma335;
using System.Diagnostics;

namespace DSVBooking.Repository
{
    public class BookCollectionRepository : IBookRepository
    {
        private List<Booking> _bookings;

        public BookCollectionRepository()
        {
            _bookings = new List<Booking>();
            Seed();
        }

        /// <summary>
        /// adds a new booking to the repository
        /// </summary>
        /// <param name="booking">the booking being added</param>
        public void Add(Booking booking)
        {
            _bookings.Add(booking);
        }

        /// <summary>
        /// Henter alle kæledyr i repositoryet.
        /// Dette svarer til en "Read all"-operation i en database.
        /// </summary>
        /// <returns>En liste med alle kæledyr.</returns>
        public List<Booking> GetAll()
        {
            return _bookings;
        }

        //new deletion method
        public void Delete(int bookingId)
        {
            var bookingToDelete = _bookings.FirstOrDefault(b => b.ID == bookingId);
            if (bookingToDelete != null)
            {
                _bookings.Remove(bookingToDelete);
            }
        }

        private void Seed()
        {
            _bookings.Add(new Booking(1, new DateTime(2025, 04, 03, 10, 0, 0), new DateTime(2025, 04, 01, 15, 0, 0), "we want cookies!"));
            _bookings.Add(new Booking(2, new DateTime(2025, 04, 14, 12, 0, 0), new DateTime(2025, 04, 14, 15, 0, 0), "Pizza Party!!!"));
            _bookings.Add(new Booking(5, new DateTime(2025, 04, 24, 8, 0, 0), new DateTime(2025, 04, 24, 11, 0, 0), "Lost and found raffle"));
        }
    }
}
