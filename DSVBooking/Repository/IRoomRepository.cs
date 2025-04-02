using DSVBooking.Model;

namespace DSVBooking.Repository
{
    public interface IRoomRepository
    {
        void Add(Room room);

        List<Room> GetAll();

        List<Room> Filter(bool whiteb, bool smartb, int cap);
        public Room Get(int id);

    }
}
