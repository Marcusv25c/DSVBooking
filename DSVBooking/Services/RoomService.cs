using DSVBooking.Model;
using DSVBooking.Repository;
namespace DSVBooking.Services
{
    public class RoomService
    {
        /// <summary>
        /// 
        /// </summary>
        private IRoomRepository _roomRepo;

        public RoomService(IRoomRepository roomRepo)
        {
            _roomRepo = roomRepo;
        }

        public void Add(Room room)
        {
            _roomRepo.Add(room);
        }
        
        public List<Room> GetAll()
        {
            return _roomRepo.GetAll();
        }
        public Room Get(int ID)
        {
            return _roomRepo.Get(ID);
        }

        public List<Room> Filter(int cap, bool whiteb, bool smartb)
        {
            return _roomRepo.Filter(cap, whiteb, smartb);
        }

    }
}
