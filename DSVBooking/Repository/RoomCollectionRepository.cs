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
            _rooms.Add(new Room("Alpha", 30, true, false, "imgpath"));
            _rooms.Add(new Room("Beta", 60, true, true, "imgpath"));
            _rooms.Add(new Room("Charlie", 20, true, false, "imgpath"));
            _rooms.Add(new Room("Delta", 100, true, true, "imgpath"));
            _rooms.Add(new Room("Echo", 20, false, false, "imgpath"));
            _rooms.Add(new Room("Foxtrot", 50, false, true, "imgpaht"));
        }
    }
}
