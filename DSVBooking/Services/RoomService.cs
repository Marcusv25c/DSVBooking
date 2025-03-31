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
    }
}
