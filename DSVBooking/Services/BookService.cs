using DSVBooking.Repository;
using DSVBooking.Model;

namespace DSVBooking.Services
{
    public class BookService
    {
        private IBookRepository _bookRepo;

        public BookService(IBookRepository bookRepo)
        {
            _bookRepo = bookRepo;
        }

        public List<Booking> GetAll()
        {
            return _bookRepo.GetAll();
        }

        public void Add(Booking book)
        {
            _bookRepo.Add(book);
        }
    }
}
