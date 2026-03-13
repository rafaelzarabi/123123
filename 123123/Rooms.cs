using System;
using System.Collections.Generic;
using System.Text;

namespace _123123
{
    internal class Rooms
    {
        public string Name { get; private set; }
        public int SeatsAmount { get; private set; }
        public bool HasWhiteboard { get; private set; }
        public bool HasProjector { get; private set; }


        private List<Booking> _allBookings = new List<Booking>();


        public Rooms(string name, int seatsAmount, bool hasWhiteboard, bool hasProjector)
        {
            Name = name;
            SeatsAmount = seatsAmount;
            HasWhiteboard = hasWhiteboard;
            HasProjector = hasProjector;
        }



        public static void LokaleStatus(List<Booking> allBookings)
        {

            foreach (Booking b in allBookings)
            {
                if (b.BookedBy == null)
                {
                    Console.WriteLine($"| {b.Day.PadRight(10)} | {b.TimeSlot.PadRight(10)} | {b.Room.Name.PadRight(10)} - LEDIG |");
                }
                else
                {
                    Console.WriteLine($"{b.Day.PadRight(10)} {b.TimeSlot.PadRight(10)} - OPTAGET af {b.BookedBy._Firstname.PadRight(10)} ");
                }
            }
            Console.WriteLine("Tryk enter for at komme tilbage til hovedmenuen");
            Console.ReadKey();
        }












    }



}

		
	

        
      