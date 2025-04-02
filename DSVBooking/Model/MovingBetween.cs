using System.Security.Cryptography;

namespace DSVBooking.Model
{
    public class MovingBetween
    {
        int _roomID;
        string _name;
        DateTime _startDateTime;


        public int RoomID { get => _roomID; set => _roomID = value; }
        public DateTime StartDateTime { get => _startDateTime; set => _startDateTime = value; }
        public string Name { get => _name; set => _name = value; }


        public MovingBetween()
        {
         
        }
        public MovingBetween(int roomid,DateTime dateTime,string name):this()
        {
            RoomID = roomid;
            _startDateTime = dateTime;
            _name = name;
        }
    }
}
