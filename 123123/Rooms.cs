using System;
using System.Collections.Generic;
using System.Text;

namespace KontorNordProjekt
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


        public void TilføjBooking(Booking booking)
        {
            _allBookings.Add(booking);
        }

        public void VisStatus()
        {
            Console.WriteLine($"Status for lokale: {Name}");

        }


        public static void LokaleStatus(List<Booking> allBookings)
        {

            foreach (Booking b in allBookings)
            {
                if (b.BookedBy == null)
                {
                    Console.WriteLine($"{b.Day} {b.TimeSlot} {b.Room.Name} - LEDIG");
                }
                else
                {
                    Console.WriteLine($"{b.Day} {b.TimeSlot} - OPTAGET af {b.BookedBy._Firstname}");
                }
            }
            Console.WriteLine("Tryk enter for at komme tilbage til hovedmenuen");
            Console.ReadKey();
        }












    }



}

		
	

        
      