using DSVBooking.Model;

namespace DSVBooking.Repository
{
    public interface IRoomRepository
    {
        void Add(Room room);

        List<Room> GetAll();
    }
}
