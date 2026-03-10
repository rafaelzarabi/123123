using System;
using System.Collections.Generic;

namespace _123123
{
	internal class Booking
	{
		public static List<string> bookings = new List<string>();

		public void BookRoom()
		{
			Console.Clear();

			// Vælg lokale
			Console.WriteLine("Vælg lokale:");
			Console.WriteLine("1) Lokale A");
			Console.WriteLine("2) Lokale B");
			Console.WriteLine("3) Lokale C");

			string roomInput = Console.ReadLine();
			string valgtLokale = "";

			switch (roomInput)
			{
				case "1":
					valgtLokale = "A";
					break;

				case "2":
					valgtLokale = "B";
					break;

				case "3":
					valgtLokale = "C";
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
			string valgtDag = "";

			switch (dagInput)
			{
				case "1":
					valgtDag = "Mandag";
					break;
				case "2":
					valgtDag = "Tirsdag";
					break;
				case "3":
					valgtDag = "Onsdag";
					break;
				case "4":
					valgtDag = "Torsdag";
					break;
				case "5":
					valgtDag = "Fredag";
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
			Console.WriteLine("3) Eftermiddag 12:00 - 14:00");

			string timeInput = Console.ReadLine();
			string timeSlot = "";

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
					Console.WriteLine("Ugyldigt valg");
					Console.ReadKey();
					return;
			}

			string bookingText = $"Lokale {valgtLokale} er booket i {timeSlot} på {valgtDag}";

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