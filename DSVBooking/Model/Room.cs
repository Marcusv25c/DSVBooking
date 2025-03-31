using System.Security.Cryptography.X509Certificates;

namespace DSVBooking.Model
{
    public class Room
    {
        public string Name { get; set; }
        static int ID { get; set; } // Static for easy constructing 
        public int Capacity { get; set; }
        public bool Projector { get; set; }
        public bool Whiteboard { get; set; }
        public bool SmartBoard { get; set; }

        // Default Contructor for a room without equipment
        public Room(string name, int cap)
        {
            Name = name;
            ID++;
            Capacity = cap;
            Projector = false;
            Whiteboard = false;
            SmartBoard = false;
        }

        // In depth Constructor with all proterties
        public Room (string name, int cap, bool projector, bool whiteboard, bool smartboard)
        {
            Name = name;
            ID++;
            Capacity = cap;
            Projector = projector;
            Whiteboard = whiteboard;
            SmartBoard = smartboard;
        }
    }
}
