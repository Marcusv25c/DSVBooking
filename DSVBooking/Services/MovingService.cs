using DSVBooking.Model;
using DSVBooking.Repository;

namespace DSVBooking.Services
{
    public class MovingService
    {
        private IMovingRepository _moveRepo;

        public MovingService(IMovingRepository bookRepo)
        {
            _moveRepo = bookRepo;
        }

        public List<MovingBetween> GetAll()
        {
            return _moveRepo.GetAll();
        }

        public void Add(MovingBetween book)
        {
            _moveRepo.Add(book);
        }
    }
}

