using DSVBooking.Model;

namespace DSVBooking.Repository
{
    public interface IMovingRepository
    {
        void Add(MovingBetween MovingBetween);

        List<MovingBetween> GetAll();
    }
}
