using System.Diagnostics;
using System.Xml.Linq;
using DSVBooking.Pages;

namespace DSVBooking.Model
{
    public class Booking
    {
        /// <summary>
        /// Booking class describes the currently booked rooms. 
        /// It uses the Room class
        /// starting datetime
        /// end datetime of booking and the user's written comment as properties
        /// </summary>
        static int _tempID = 1;
        int _iD;
        int _roomID;
        DateTime _startDateTime;
        DateTime _endDateTime;
        string _comment;


        /// <summary>
        /// Room represents the room that is being booked. 
        /// StartDateTime is the starting time and date for the booking.
        /// EndDateTime describes when the booking ends.
        /// The comment is a user input which contains information about the booking.
        /// The iD is a unique identifier for the user's specific.
        /// </summary>
        public int ID { get => _iD; set => _iD = value; }
        public int RoomID { get => _roomID; set => _roomID = value; }
        public DateTime StartDateTime { get => _startDateTime; set => _startDateTime = value; }
        public DateTime EndDateTime { get => _endDateTime; set => _endDateTime = value; }
        public string Comment { get => _comment; set => _comment = value; }

        /// <summary>
        /// StartDateTime is the starting time and date for the booking.
        /// EndDateTime describes when the booking ends.
        /// The comment is a user input which contains information about the booking.
        /// </summary>
        /// <param name="iD">Unique identifier for booking</param>
        /// <param name="roomID">ID of the room in the building</param>
        /// <param name="startDateTime">Start time of booking</param>
        /// <param name="endDateTime">End time of booking</param>
        /// <param name="comment">User input comment about booking</param>


        public Booking() 
        {
            _iD = _tempID++;
            RoomID = 0;
            _startDateTime = DateTime.Now.Date.AddHours(DateTime.Now.Hour);
            _endDateTime = DateTime.Now.Date.AddHours(DateTime.Now.Hour).AddHours(1);
            _comment = "";
            Debug.WriteLine("cdw" + ID);
            


        } //default constructor

        

        public Booking(int roomID, DateTime startDateTime, DateTime endDateTime, string comment):this()
        {
            _roomID = roomID;
            _startDateTime = startDateTime;
            _endDateTime = endDateTime;
            _comment = comment;
        }
    }
}
