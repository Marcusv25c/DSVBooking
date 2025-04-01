using System.Diagnostics;
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

        public List<Room> Filter(bool whiteb, bool smartb, int cap)
        {
            List<Room> filterRooms = new List<Room>();
            List<Booking> filterBookings = new List<Booking>();

            if (smartb == true && whiteb == true)
            {
                foreach (Room room in _rooms)
                {
                    if (room.SmartBoard && room.Capacity >= cap && room.Whiteboard)
                    {
                        filterRooms.Add(room);
                    }
                }
            }

            else if (whiteb == true)
            {
                foreach (Room room in _rooms)
                {
                    if (room.Whiteboard && room.Capacity >= cap)
                    {
                        filterRooms.Add(room);
                    }
                }
            }

            else if (smartb == true)
            {
                foreach (Room room in _rooms)
                {
                    if (room.SmartBoard && room.Capacity >= cap)
                    {
                        filterRooms.Add(room);
                    }
                }
            }

            else
            {
                foreach (Room room in _rooms)
                {
                    if (room.Capacity >= cap)
                    {
                        filterRooms.Add(room);
                    }
                }
            }
            //foreach (Room room in filterRooms)
             //   Debug.WriteLine("test " + room.Name);

            return filterRooms;
        }

        public RoomCollectionRepository()
        {
            _rooms.Add(new Room("Alpha", 30, true, false, "conference1.jpg"));
            _rooms.Add(new Room("Beta", 60, true, true, "conference2.jpg"));
            _rooms.Add(new Room("Charlie", 20, true, false, "conference3.jpg"));
            _rooms.Add(new Room("Delta", 100, true, true, "conference4.jpg"));
            _rooms.Add(new Room("Echo", 20, false, false, "conference3.jpg"));
            _rooms.Add(new Room("Foxtrot", 50, false, true, "conference1.jpg"));
        }
    }
}
