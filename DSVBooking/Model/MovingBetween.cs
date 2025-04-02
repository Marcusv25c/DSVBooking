using System.Security.Cryptography;

namespace DSVBooking.Model
{
    public class MovingBetween
    {
        int _roomID;
        DateTime _startDateTime;
        DateTime _endDateTime;


       
        public int RoomID { get => _roomID; set => _roomID = value; }
        public DateTime StartDateTime { get => _startDateTime; set => _startDateTime = value; }
        public DateTime EndDateTime { get => _endDateTime; set => _endDateTime = value; }


        public MovingBetween()
        {
            RoomID = 0;
            _startDateTime = new DateTime(2025, 04, 04, 10, 0, 0);
            _endDateTime = new DateTime(2025, 04, 04, 10, 0, 0);


        }
    }
}
