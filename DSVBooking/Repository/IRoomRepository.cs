using DSVBooking.Model;

namespace DSVBooking.Repository
{
    public interface IRoomRepository
    {
        void Add(Room room);

        List<Room> GetAll();

        List<Room> Filter(int cap, bool whiteb, bool smartb);
        public Room Get(int id);

    }
}
