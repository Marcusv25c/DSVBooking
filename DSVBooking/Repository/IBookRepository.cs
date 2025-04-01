using DSVBooking.Model;

namespace DSVBooking.Repository
{
    public interface IBookRepository
    {
        void Add(Booking booking);

        List<Booking> GetAll();


    }
}
