using System;
using System.Collections.Generic;

namespace _123123
{
    internal class Booking
    {
        // Liste over alle bookinger
        public static List<string> bookings = new List<string>();

        public void BookRoom()
        {
            List<Rooms> rooms = Rooms.GetLokaler();

            Console.WriteLine("Vælg et lokale:");

            for (int i = 0; i < rooms.Count; i++)
            {
                Console.WriteLine($"{i + 1}) Lokale {rooms[i].Name}");
            }

            int roomChoice;

            while (true)
            {
                string input = Console.ReadLine();

                if (!int.TryParse(input, out roomChoice))
                {
                    Console.WriteLine("Ugyldigt valg, prøv igen:");
                    continue;
                }

                roomChoice -= 1;

                if (roomChoice < 0 || roomChoice >= rooms.Count)
                {
                    Console.WriteLine("Ugyldigt valg, prøv igen:");
                    continue;
                }

                break;
            }

            Rooms selectedRoom = rooms[roomChoice];

            Console.Clear();
            Console.WriteLine("Vælg tidsrum:");
            Console.WriteLine("1) Morgen".PadRight(25) + "08:00 - 10:00");
            Console.WriteLine("2) Formiddag".PadRight(25) + "10:00 - 12:00");
            Console.WriteLine("3) Eftermiddag".PadRight(25) + "12:00 - 14:00");

            string timeInput;
            string timeSlot = "";

            while (true)
            {
                timeInput = Console.ReadLine();

                switch (timeInput)
                {
                    case "1":
                        timeSlot = "Morgen";
                        break;
                    case "2":
                        timeSlot = "Formiddag";
                        break;
                    case "3":
                        timeSlot = "Eftermiddag";
                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg, prøv igen:");
                        continue;
                }

                break;
            }

            string bookingText = $"Lokale {selectedRoom.Name} er booket i {timeSlot}";

            Console.Clear();
            Console.WriteLine("Bekræft booking:");
            Console.WriteLine(bookingText);
            Console.WriteLine("");
            Console.WriteLine("1) Bekræft");
            Console.WriteLine("2) Annuller");

            string confirm = Console.ReadLine();

            if (confirm == "1")
            {
                bookings.Add(bookingText);

                Console.Clear();
                Console.WriteLine("Booking gennemført!");
                Console.WriteLine(bookingText);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Booking annulleret.");
            }

            Console.WriteLine("\nTryk på en tast for at fortsætte...");
            Console.ReadKey();
        }
    }
}