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

        public Room Get(int id)
        {
            foreach(Room room in _rooms)
            {
                if (id == room.ID)
                {
                    return room;
                }
            }
            return null;
        }

        public List<Room> GetAll()
        {
            return _rooms;
        }

        public RoomCollectionRepository()
        {
            _rooms.Add(new Room("Arne", 30, false, true, false));
            _rooms.Add(new Room("Børge", 60, true, false, true));
            _rooms.Add(new Room("Carsten", 10));
        }
    }
}
