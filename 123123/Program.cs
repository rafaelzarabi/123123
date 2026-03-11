using _123123;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace _123123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            UserService userService = new UserService();

            Rooms lokale1 = new Rooms("A", 70, true, true);
            Rooms lokale2 = new Rooms("B", 40, true, false);
            Rooms lokale3 = new Rooms("C", 20, false, true);

            List<Booking> allBookings = new List<Booking>();
            string[] days = { "Mandag", "Tirsdag", "Onsdag", "Torsdag", "Fredag" };
            string[] times = { "Morgen", "Formiddag", "Eftermiddag" };

            foreach (string day in days)
            {
                foreach (string time in times)
                {
                    allBookings.Add(new Booking(day, time, null, lokale1));
                }
            }

            User user = userService.CurrentUser;

            Booking booking = new Booking(
                "Mandag",
                "Morgen",
                user,
                lokale1
            );

            lokale1.TilføjBooking(booking);




            bool ProgramRunning = true;
            bool LogIn = false;

            while (ProgramRunning == true)
            {
                while (LogIn == false)
                {

                    Console.WriteLine("================================================");
                    Console.WriteLine("                     Log In                     ");
                    Console.WriteLine("================================================");
                    Console.WriteLine("1)  Log ind ");
                    Console.WriteLine("2)  Register bruger");
                    Console.WriteLine("3)  Se alle registeret brugere");
                    Console.WriteLine("4)  Afslut programmet");

                    ConsoleKeyInfo keyinfox = Console.ReadKey();

                    switch (keyinfox.KeyChar)
                    {
                        case '1':
                            Console.Clear();
                           userService.LoginBool();
                            break;
                        case '2':
                            Console.Clear();
                            userService.RegisterUser();
                            break;
                        case '3':
                            Console.Clear();
                            userService.ShowUserList();
                            break;
                        case '4':
                            Console.Clear();
                            CloseProgram();
                            break;
                    }
                   
                }

                Console.Clear();
                Console.Clear();
                Console.WriteLine("===============================================");
                Console.WriteLine("                   HOVEDMENU                   ");
                Console.WriteLine("===============================================");

                Console.WriteLine("1)  Status på lokaler");
                Console.WriteLine("2)  Lokale information");
                Console.WriteLine("3)  Book et lokale");
                Console.WriteLine("4)  Log ud");

                ConsoleKeyInfo keyinfo = Console.ReadKey();

                switch (keyinfo.KeyChar)
                {
                    case '1':
                        Console.Clear();

                        break;

                    case '2':
                        Console.Clear();

                        break;

                    case '3':
                        Console.Clear();

                        break;
                    case '4':
                        Console.Clear();
                        userService.LogOutBool();
                        break;

                }
                        
            }
        }

        public static void CloseProgram()
        {
            Console.WriteLine("Er du sikker på du vil afslutte programmet?\n At afslutte programmet fjerne af indtastet data");
            Console.WriteLine("1) ja");
            Console.WriteLine("2) Nej");

            ConsoleKeyInfo input = Console.ReadKey();
            switch (input.KeyChar)
            {
                case '1':
                    Environment.Exit(0);
                    break;
                case '2':
                break;
            } 
            


            /*//LOKALE INFO - FRA LOKALER.CS KLASSE
            List<Rooms> rooms = ne 

            foreach (var room in rooms)
            {
                Console.WriteLine($"Lokale {room.Name} ({room.SeatsAmount} pladser) - {(room.HasWhiteboard ? "Whiteboard" : "Ingen whiteboard")} - {(room.HasProjector ? "Projektor" : "Ingen projektor")}");
            }*/
        }
    }
}
