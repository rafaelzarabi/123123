using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _123123
{
    internal class Booking
    {
        public static Dictionary<string, string> bookings = new Dictionary<string, string>();

        public void BookRoom()
        {
            List<Rooms> lokaler = Rooms.GetLokaler();

            foreach (var room in lokaler)
            {
                Console.WriteLine($"Lokale: {room.Name}. Antal siddepladser: {room.SeatsAmount}. Har rummet en projektor? {room.HasProjector}. Har rummet et Whiteboard? {room.HasWhiteboard}");
            }

            Console.WriteLine();
            Console.WriteLine("Indtast navnet på facilitatoren af mødet ");
            string nameOfBooker = Console.ReadLine().ToLower().Trim();

            Console.WriteLine("Vælg det lokale du gerne vil reservere ");
            Console.WriteLine("1) lokale A ");
            Console.WriteLine("2) lokale B ");
            Console.WriteLine("3) lokale C ");

            string roomInput = Console.ReadLine();
            string roomName = roomInput switch
            {
                "1" => lokaler[0].Name,
                "2" => lokaler[1].Name,
                "3" => lokaler[2].Name,
                _ => null
            };

            if (roomName == null)
            {
                Console.WriteLine("Ugyldigt valg");
                Console.ReadKey();
                return;
            }

            // Vælg dag
            Console.Clear();
            Console.WriteLine("Vælg dag:");
            Console.WriteLine("1) Mandag");
            Console.WriteLine("2) Tirsdag");
            Console.WriteLine("3) Onsdag");
            Console.WriteLine("4) Torsdag");
            Console.WriteLine("5) Fredag");

            string dagInput = Console.ReadLine();
            string valgtDag = dagInput switch
            {
                "1" => "Mandag",
                "2" => "Tirsdag",
                "3" => "Onsdag",
                "4" => "Torsdag",
                "5" => "Fredag",
                _ => null
            };

            if (valgtDag == null)
            {
                Console.WriteLine("Ugyldigt valg");
                Console.ReadKey();
                return;
            }

            // Vælg tidsrum
            Console.Clear();
            Console.WriteLine("Vælg tidsrum:");
            Console.WriteLine("1) Morgen      08:00 - 10:00");
            Console.WriteLine("2) Formiddag   10:00 - 12:00");
            Console.WriteLine("3) Eftermiddag 12:00 - 14:00");

            string timeInput = Console.ReadLine();
            string timeSlot = timeInput switch
            {
                "1" => "Morgen",
                "2" => "Formiddag",
                "3" => "Eftermiddag",
                _ => null
            };

            if (timeSlot == null)
            {
                Console.WriteLine("Ugyldigt valg");
                Console.ReadKey();
                return;
            }

            string key = roomName + "_" + valgtDag + "_" + timeSlot;

            Console.Clear();
            Console.WriteLine($"Bekræft booking: Lokale {roomName} er booket {timeSlot}, {valgtDag} af {nameOfBooker}");
            Console.WriteLine();
            Console.WriteLine("1) Bekræft");
            Console.WriteLine("2) Annuller");
            string confirm = Console.ReadLine();

            if (confirm == "1")
            {
                if (bookings.ContainsKey(key))
                {
                    Console.Clear();
                    Console.WriteLine("Dette lokale er allerede booket på det tidspunkt.");
                }
                else
                {
                    bookings[key] = nameOfBooker;
                    Console.Clear();
                    Console.WriteLine("Booking gennemført!");
                    Console.WriteLine($"Lokale {roomName} er booket {timeSlot}, {valgtDag} af {nameOfBooker}");
                }
            }

            Console.WriteLine("Tryk på en tast for at fortsætte...");
            Console.ReadKey();
        }







    } 
}