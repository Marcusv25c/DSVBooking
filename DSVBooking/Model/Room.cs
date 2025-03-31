﻿using System.Security.Cryptography.X509Certificates;

namespace DSVBooking.Model
{
    public class Room
    {
        public string Name { get; set; }
        public int ID { get; set; } // Static for easy constructing 
        public int Capacity { get; set; }
        public bool Projector { get; set; }
        public bool Whiteboard { get; set; }
        public bool SmartBoard { get; set; }



        public Room()
        {
            Name = "test";
            ID++;
            Capacity = 0;
            Projector = false;
            Whiteboard = false;
            SmartBoard = false;
        }


        // Default Contructor for a room without equipment
        public Room(string name, int cap):this()
        {
            Name = name;
            Capacity = cap;
           
        }

        // In depth Constructor with all proterties
        public Room(string name, int cap, bool projector, bool whiteboard, bool smartboard) : this( name,  cap)
        {
          
            Projector = projector;
            Whiteboard = whiteboard;
            SmartBoard = smartboard;
        }
    }
}
