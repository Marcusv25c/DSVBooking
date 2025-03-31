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
        Room _room;
        DateTime _startDateTime;
        DateTime _endDateTime;
        string _comment;
        int _iD;


    /// <summary>
    /// Room represents the room that is being booked. 
    /// StartDateTime is the starting time and date for the booking.
    /// EndDateTime describes when the booking ends.
    /// The comment is a user input which contains information about the booking.
    /// The iD is a unique identifier for the user's specific.
    /// </summary>
        public Room Room { get => _room; set => _room = value; }
        public DateTime StartDateTime { get => _startDateTime; set => _startDateTime = value; }
        public DateTime EndDateTime { get => _endDateTime; set => _endDateTime = value; }
        public string Comment { get => _comment; set => _comment = value; }
        public int ID { get => _iD; set => _iD = value; }

        /// <summary>
        /// StartDateTime is the starting time and date for the booking.
        /// EndDateTime describes when the booking ends.
        /// The comment is a user input which contains information about the booking.
        /// </summary>
        /// <param name="iD">Unique identifier for booking</param>
        /// <param name="room">Name of the room in the building</param>
        /// <param name="startDateTime">Start time of booking</param>
        /// <param name="endDateTime">End time of booking</param>
        /// <param name="comment">User input comment about booking</param>
        Booking(int iD, Room room, DateTime startDateTime, DateTime endDateTime, string comment)
        {
            _iD = iD;
            _room = room;
            _startDateTime = startDateTime;
            _endDateTime = endDateTime;
            _comment = comment;
        }
    }
}
