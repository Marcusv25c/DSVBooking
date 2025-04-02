using System.Security.Cryptography.X509Certificates;

namespace DSVBooking.Model
{
    public class Room
    {
        private static int _tempID = 1; // instance

        public string Name { get; set; }
        public int ID { get; set; }  
        public int Capacity { get; set; }
        public bool Whiteboard { get; set; }
        public bool SmartBoard { get; set; }
        public string ImgPath { get; set; }
                

        public Room()
        {
            Name = "test";
            ID = _tempID;
            Capacity = 0;
            Whiteboard = false;
            SmartBoard = false;
            ImgPath = "";
        }


        // Default Contructor for a room without equipment
        public Room(string name, int cap):this()
        {
            Name = name;
            Capacity = cap;           
        }

        // In depth Constructor with all proterties
        public Room(string name, int cap, bool whiteboard, bool smartboard, string imgPath) : this( name,  cap)
        {
            Whiteboard = whiteboard;
            SmartBoard = smartboard;
            ImgPath = imgPath;
        }
    }
}
