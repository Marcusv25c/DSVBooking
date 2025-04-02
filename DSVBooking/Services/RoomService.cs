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

        public List<Room> Filter(bool whiteb, bool smartb, int cap)
        {
            return _roomRepo.Filter(whiteb, smartb, cap);
        }

    }
}
