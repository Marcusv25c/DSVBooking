using DSVBooking.Model;
using System.Reflection.Metadata.Ecma335;
namespace DSVBooking.Repository
{
    public class BookCollectionRepository : IBookRepository
    {
        List<Booking> _bookings = new List<Booking>();

        /// <summary>
        /// Return af copy of the list, so it can't be changed from the outside
        /// </summary>
        /// <returns></returns>
        public List<Booking> GetAll()
        {
            return _bookings;
        }

        

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
        }
    }
}
