using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace _123123
{
    internal class Booking
    {
        // Hvad indeholder en booking? Den er tilknyttet en USER, har et navn og et tidspunkt på dagen 1, 2, 3 = morgen, middag, eftermiddag
        public string _NameOfTheBooker { get; private set; }
        public string _roomname { get; private set; }
        public int _TimeSlot { get; private set; }


        public static List<Booking> bookings = new List<Booking>();
        List<Rooms> rooms = Rooms.GetLokaler();



        // constructor - til når vi skal oprette et booking objekt, som indeholder et NAME og TIMESLOT
        public Booking(string NameOfTheBooker,string Roomname, int Timeslot)
        {
            _NameOfTheBooker = NameOfTheBooker;
            _roomname = Roomname;
            _TimeSlot = Timeslot;
        }

        public void BookRoomLangberg()
        {
            List<Rooms> lokaler = Rooms.GetLokaler();
            string NameOfTheBooker = "";
            string Roomname = "";
            int Timeslot = 0;
            foreach (var rooms in Rooms.GetLokaler())
            {
                Console.WriteLine($"Lokale: {rooms.Name}. Antal siddepladser: {rooms.SeatsAmount}. Har rummet en projektor? {rooms.HasProjector}. Har rummet et Whiteboard? {rooms.HasWhiteboard}");
            }

            Console.WriteLine("Indtast navnet på facilitatoren af mødet ");
            NameOfTheBooker = Console.ReadLine().ToLower().Trim();

            Console.WriteLine("Vælg det lokale du gerne vil rersaver ");
            Console.WriteLine("1) lokale A ");
            Console.WriteLine("2) lokale b ");
            Console.WriteLine("3) lokale c ");

            Roomname = Console.ReadLine();


            switch (Roomname)
            {
                case "1":
                    Roomname = lokaler[0].Name;
                    break;
     
                case "2":
                    Roomname = lokaler[1].Name;

                    break;
                case "3":
                    Roomname = lokaler[2].Name;

                    break;

            }


            Console.WriteLine("Vælg det lokale du gerne vil rersaver ");
            Console.WriteLine("1) lokale A ");
            Console.WriteLine("2) lokale b ");
            Console.WriteLine("3) lokale c ");
            Timeslot = Convert.ToInt32(Console.ReadLine());

            switch (Timeslot)
            {
                case 1:
                    Timeslot= 

                    break;
                case 2:
                    Timeslot=

                    break;
                case 3:
                    Timeslot=

                    break;

            }     
        }


        public void Mariebook()
        {
            // string så vi kan sætte hvem der har
            Console.WriteLine("Hvad er navnet på mødeansvarlige");
            string meeting = Console.ReadLine();

            //Vælg lokale
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




      






        public void BookRoom()
        {


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
}