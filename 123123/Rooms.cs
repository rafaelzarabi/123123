using System;
using System.Collections.Generic;
using System.Text;

namespace _123123
{
    internal class Rooms
    {
        public string Name  { get; private set; }
        public int SeatsAmount { get; private set; }
        public bool HasWhiteboard { get; private set; }
        public bool HasProjector { get; private set; }
        
        public Rooms(string name, int seatsAmount, bool hasWhiteboard, bool hasProjector)
        {
            Name = name;
            SeatsAmount = seatsAmount;
            HasWhiteboard = hasWhiteboard;
            HasProjector = hasProjector;
        }
        public static List<Rooms> GetLokaler()
        {
            List<Rooms> rooms = new List<Rooms>();

           
    
            rooms.Add(new Rooms("A", 70, true, true));
            rooms.Add(new Rooms("B", 40, true, false));
            rooms.Add(new Rooms("C", 20, false, true));
            
            return rooms; 
        }
    }
}
        
      