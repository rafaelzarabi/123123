using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _123123
{
    internal class Booking
    {

        // Hvad indeholder en booking? Den er tilknyttet en USER, har et navn og et tidspunkt på dagen 1, 2, 3 = morgen, middag, eftermiddag
        public string _NameOfTheBooker { get; private set; }
        public string _roomname { get; private set; }
        public int _TimeSlot { get; private set; }


        public static List<string> bookings = new List<string>();
        List<Rooms> rooms = Rooms.GetLokaler();



        public void BookRoom()
        {
            List<Rooms> lokaler = Rooms.GetLokaler();
            string NameOfTheBooker = "";
            string Roomname = "";
            int Timeslot = 0;

            foreach (var rooms in Rooms.GetLokaler())
            {
                Console.WriteLine($"Lokale: {rooms.Name}. Antal siddepladser: {rooms.SeatsAmount}. Har rummet en projektor? {rooms.HasProjector}. Har rummet et Whiteboard? {rooms.HasWhiteboard}");
            }
            Console.WriteLine("");
            Console.WriteLine("Indtast navnet på facilitatoren af mødet ");
            _NameOfTheBooker = Console.ReadLine().ToLower().Trim();

            Console.WriteLine("Vælg det lokale du gerne vil rersaver ");
            Console.WriteLine("1) lokale A ");
            Console.WriteLine("2) lokale b ");
            Console.WriteLine("3) lokale c ");

            _roomname = Console.ReadLine();

            switch (_roomname)
            {
                case "1":
                    _roomname = lokaler[0].Name;
                    break;
     
                case "2":
                    _roomname = lokaler[1].Name;

                    break;
                case "3":
                    _roomname = lokaler[2].Name;

                    break;

				default:

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

            Day valgtDag;

            switch (dagInput)
            {
                case "1":
                    valgtDag = Day.Mandag;
                    break;

                case "2":
                    valgtDag = Day.Tirsdag;
                    break;

                case "3":
                    valgtDag = Day.Onsdag;
                    break;

                case "4":
                    valgtDag = Day.Torsdag;
                    break;

                case "5":
                    valgtDag = Day.Fredag;
                    break;

                default:
					Console.WriteLine("Ugyldigt valg");
					Console.ReadKey();
					return;
			}

			// Vælg tidsrum
			Console.Clear();
			Console.WriteLine("Vælg tidsrum:");
			Console.WriteLine("1) Morgen      08:00 - 10:00");
			Console.WriteLine("2) Formiddag   10:00 - 12:00");
			Console.WriteLine("3) Eftermiddage 12:00 - 14:00");

			string timeInput = Console.ReadLine();

            TimeSlot timeSlot;

            switch (timeInput)
            {
                case "1":
                    timeSlot = TimeSlot.Morgen;
                    break;

                case "2":
                    timeSlot = TimeSlot.Formiddag;
                    break;

                case "3":
                    timeSlot = TimeSlot.Eftermiddag;
                    break;

                default:
                    Console.WriteLine("Ugyldigt valg");
                    Console.ReadKey();
                    return;

                
			}

			string bookingText = $"Lokale {Roomname} er booket {timeSlot}, {valgtDag}";

			// Bekræft booking

			Console.Clear();
			Console.WriteLine("Bekræft booking:");
			Console.WriteLine(bookingText);

			Console.WriteLine();

			Console.WriteLine("1) Bekræft");
			Console.WriteLine("2) Annuller");

			string confirm = Console.ReadLine();


			if (confirm == "1")
			{

                if (bookings.Contains(bookingText))
				{
					Console.Clear();
					Console.WriteLine("Dette lokale er allerede booket på det tidspunkt.");
				}

				else
				{
					bookings.Add(bookingText);

					Console.Clear();
					Console.WriteLine("Booking gennemført!");

					Console.WriteLine(bookingText);
				}
			}

			Console.WriteLine("Tryk på en tast for at fortsætte...");
			Console.ReadKey();

		} 



        
    
    } 
}