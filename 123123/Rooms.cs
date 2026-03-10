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

		public static void LokaleStatus()
        {
			Booking booking = new Booking();

			string[] tider = { "Morgen", "Formiddag", "Eftermiddag" };
			string[] dage = { "Mandag", "Tirsdag", "Onsdag", "Torsdag", "Fredag" };


			List <Rooms> rooms =  GetLokaler();

			for (int dag = 0; dag < dage.Length; dag++)
			{


				Console.WriteLine($"=== {dage[dag]} ===");
				Console.WriteLine("========================================================================".PadLeft(50));
				Console.WriteLine("             |      Lokale A     |     Lokale B     |     Lokale C     |".PadLeft(50));
				Console.WriteLine("========================================================================".PadLeft(50));


				for (int tid = 0; tid < tider.Length; tid++)
				{
					bool lokaleA = false;
					bool lokaleB = false;
					bool lokaleC = false;

					foreach (string bookingx in Booking.bookings)
					{
						// Checker dag og tid ;
						if (bookingx.Contains("Lokale A er booket " + tider[tid]) &&
							bookingx.Contains(dage[dag]))
							lokaleA = true;


						if (bookingx.Contains("Lokale B er booket " + tider[tid]) &&
							bookingx.Contains(dage[dag]))
							lokaleB = true;


						if (bookingx.Contains("Lokale C er booket " + tider[tid]) &&
							bookingx.Contains(dage[dag]))
							lokaleC = true;
					}


					string statusA;
					if (lokaleA == true)
						statusA = booking._NameOfTheBooker;

					else
						statusA = "Ledig";

					string statusB;
					if (lokaleB == true)
						statusB = booking._NameOfTheBooker;
					else
						statusB = "Ledig";

					string statusC;
					if (lokaleC == true)
						statusC = booking._NameOfTheBooker;
					else
						statusC = "Ledig";


					Console.WriteLine(tider[tid].PadRight(19) + statusA.PadRight(19) + statusB.PadRight(19) + statusC);
				}

				Console.WriteLine();


			}

			Console.WriteLine("Tryk på en tast for at gå tilbage til Hovedmenu");
			Console.ReadKey();


		}
	}
}
        
      