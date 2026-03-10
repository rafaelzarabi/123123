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
		public TimeSlot _TimeSlot { get; private set; }
		public Day Day { get; private set; }

		//laver en liste af alle bookings
		public static List<Booking> bookings = new List<Booking>();

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

			Console.WriteLine("Indtast navnet på facilitatoren af mødet:");
			_NameOfTheBooker = Console.ReadLine().Trim();


			Console.WriteLine("Vælg det lokale du gerne vil rersaver ");
			Console.WriteLine("1) lokale A ");
			Console.WriteLine("2) lokale b ");
			Console.WriteLine("3) lokale c ");

			string roomname = Console.ReadLine();

			switch (roomname)
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
					
					Day = Day.Mandag;
					break;

				case "2":
					Day = Day.Tirsdag;
					break;

				case "3":
					Day = Day.Onsdag;
					break;

				case "4":
					Day = Day.Torsdag;
					break;

				case "5":
					Day = Day.Fredag;
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
					_TimeSlot = TimeSlot.Morgen;
					break;

				case "2":
					_TimeSlot = TimeSlot.Formiddag;
					break;

				case "3":
					_TimeSlot = TimeSlot.Eftermiddag;
					break;

				default:
					Console.WriteLine("Ugyldigt valg");
					Console.ReadKey();
					return;


			}

			string bookingText = ($"Lokale {_roomname} er booket {_TimeSlot}, {Day} af {_NameOfTheBooker}");

			// Bekræft booking

			Console.Clear();
			Console.WriteLine("Bekræft booking:");
			Console.WriteLine(bookingText);

			Console.WriteLine();

			Console.WriteLine("1) Bekræft");
			Console.WriteLine("2) Annuller");

			string confirm = Console.ReadLine();


			bool alreadyBooked = bookings.Exists(b => b._roomname == _roomname && b.Day == Day && b._TimeSlot == _TimeSlot); //.Exists returnerer hvis én ting er korrekt

			if (alreadyBooked)
			{
				Console.Clear();
				Console.WriteLine("Dette lokale er allerede booket på det tidspunkt.");
			}

			else
			{
				bookings.Add(this); //tilføjer booking-objektet til liste
				Console.Clear();
				Console.WriteLine("Booking gennemført!");
				Console.WriteLine(bookingText);
			}

			Console.WriteLine("Tryk på en tast for at fortsætte...");
			Console.ReadKey();


		}



	}
}