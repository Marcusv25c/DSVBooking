using DSVBooking.Model;
using System.Reflection.Metadata.Ecma335;
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
        private void Seed()
        {
            _bookings.Add(new Booking(1, , 17/07/2025, 18/07/2025, "we want cookies!"));
            _bookings.Add(new Booking());
            _bookings.Add(new Booking());
        }
        /*
        /// <summary>
        /// Iterate through the list and find a specefic id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Booking Get(int id)
        {
            foreach(Booking booking in _bookings)
            {
                return booking;
            }
            return null;
        }*/
    }
}
