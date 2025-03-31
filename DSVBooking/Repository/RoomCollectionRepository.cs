using DSVBooking.Model;
namespace DSVBooking.Repository
{
    public class RoomCollectionRepository : IRoomRepository
    {
        List<Room> _rooms = new List<Room> ();

        public void Add(Room room)
        {
            _rooms.Add(room);
        }

        public void Get(int id)
        {
            foreach(Room room in _rooms)
            {
                if (id == room.ID)
                {

                }
            }
        }
    }
}
