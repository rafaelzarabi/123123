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

        public Rooms(string name, int seatsAmount, bool hasWhiteboard, bool hasProjector)
        {
            Name = name;
            SeatsAmount = seatsAmount;
            HasWhiteboard = hasWhiteboard;
            HasProjector = hasProjector;
        }

        public static List<Rooms> GetLokaler()
        {
            return new List<Rooms>
        {
            new Rooms("A", 70, true, true),
            new Rooms("B", 40, true, false),
            new Rooms("C", 20, false, true)
        };
        }

        public static void LokaleStatus()
        {
            string[] tider = { "Morgen", "Formiddag", "Eftermiddag" };
            string[] dage = { "Mandag", "Tirsdag", "Onsdag", "Torsdag", "Fredag" };

            List<Rooms> rooms = GetLokaler();

            for (int dag = 0; dag < dage.Length; dag++)
            {
                Console.WriteLine($"=== {dage[dag]} ===");
                Console.WriteLine("========================================================================");
                Console.WriteLine("             |      Lokale A     |     Lokale B     |     Lokale C     |");
                Console.WriteLine("========================================================================");

                for (int tid = 0; tid < tider.Length; tid++)
                {
                    string statusA = Booking.bookings.ContainsKey("A_" + dage[dag] + "_" + tider[tid])
                        ? Booking.bookings["A_" + dage[dag] + "_" + tider[tid]]
                        : "Ledig";

                    string statusB = Booking.bookings.ContainsKey("B_" + dage[dag] + "_" + tider[tid])
                        ? Booking.bookings["B_" + dage[dag] + "_" + tider[tid]]
                        : "Ledig";

                    string statusC = Booking.bookings.ContainsKey("C_" + dage[dag] + "_" + tider[tid])
                        ? Booking.bookings["C_" + dage[dag] + "_" + tider[tid]]
                        : "Ledig";

                    Console.WriteLine(tider[tid].PadRight(19) + statusA.PadRight(19) + statusB.PadRight(19) + statusC);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Tryk på en tast for at gå tilbage til Hovedmenu");
            Console.ReadKey();


        }
    }
}
        
      