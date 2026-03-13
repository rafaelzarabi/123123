using _123123;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace KontorNordProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            UserService userService = new UserService();
            List<Rooms> rooooms = new List<Rooms>();
            Rooms lokale1 = new Rooms("Lokale A", 70, true, true);
            Rooms lokale2 = new Rooms("Lokale B", 40, true, false);
            Rooms lokale3 = new Rooms("Lokale C", 20, false, true);
            rooooms.Add(lokale1);
            rooooms.Add(lokale2);
            rooooms.Add(lokale3);
            
            

            List<Booking> allBookings = new List<Booking>();
            string[] days = { "Mandag", "Tirsdag", "Onsdag", "Torsdag", "Fredag" };
            string[] times = { "Morgen", "Formiddag", "Eftermiddag" };

            foreach (string day in days)
            {
                foreach (string time in times)
                {
                    allBookings.Add(new Booking(day, time, null, lokale1));
                    allBookings.Add(new Booking(day, time, null, lokale2));
                    allBookings.Add(new Booking(day, time, null, lokale3));
                }
            }

         
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
                            LogIn = userService.LoginBool();
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
                Console.WriteLine("4)  Fjern en bookning");
                Console.WriteLine("5)  Log ud");

                ConsoleKeyInfo keyinfo = Console.ReadKey();

                switch (keyinfo.KeyChar)
                {
                    case '1':
                        Console.Clear();
                        Rooms.LokaleStatus(allBookings);
                        break;

                    case '2':
                        Console.Clear();
                        foreach (var room in rooooms)
                        {
                            Console.WriteLine($"{room.Name} ({room.SeatsAmount} pladser) - {(room.HasWhiteboard ? "Whiteboard" : "Ingen whiteboard")} - {(room.HasProjector ? "Projektor" : "Ingen projektor")}");
                        }
                        

                        Console.ReadKey();
                        break;
                    case '3':
                        Console.Clear();
                        foreach (Booking b in allBookings)
                        {
                            if (b.BookedBy == null)
                            {
                                Console.WriteLine($"| {b.Day} | {b.TimeSlot} | {b.Room.Name} - LEDIG |");
                            }
                            else
                            {
                                Console.WriteLine($"{b.Day} {b.TimeSlot} - OPTAGET af {b.BookedBy._Firstname}");
                            }
                        }
                        Console.WriteLine("Indtast dag:");
                        string day = Console.ReadLine();

                        Console.WriteLine("Indtast tidspunkt:");
                        string time = Console.ReadLine();

                        Console.WriteLine("Vælg ønskede lokale:");
                        Console.WriteLine("1) Lokale A");
                        Console.WriteLine("2) Lokale B");
                        Console.WriteLine("3) Lokale C");

                        char lokaleValg;

                         while (true)
                        {
                            lokaleValg = Console.ReadKey(true).KeyChar;

                            if (lokaleValg == '1' || lokaleValg == '2' || lokaleValg == '3')
                            {
                                break;
                            }

                            Console.WriteLine("Ugyldigt valg, vælg venligst 1 2 eller 3");
                        }
                        Rooms valgtLokale = null;
                        switch (lokaleValg)
                        {
                            case '1':
                                valgtLokale = lokale1;
                                break;
                            case '2':
                                valgtLokale = lokale2;
                                break;

                            case '3':
                                valgtLokale = lokale3;
                                break;
                        }



                        foreach (Booking b in allBookings)
                        {
                            if (b.Day.ToLower() == day.ToLower() &&
                                b.TimeSlot.ToLower() == time.ToLower() &&
                                b.Room == valgtLokale)
        
                            {
                                if (b.BookedBy == null)
                                {
                                    b.BookedBy = userService.CurrentUser;
                                    Console.WriteLine($"{valgtLokale.Name} er nu booket");
                                }
                                else
                                {
                                    Console.WriteLine("Tiden er allerede optaget");
                                }
                            }
                        }
                        Console.ReadKey();
                        break;
                    case '4':
                        FjernEnBooking(allBookings);
                        break;
                    case '5':
                        Console.Clear();
                        LogIn = userService.LogOutBool();
                        break;

                }

            }
        }







        public static void FjernEnBooking(List<Booking> allBookings)
        {

            Console.WriteLine("Hvilken dag vil du fjerne booking fra?");
            string dag = Console.ReadLine();

            Console.WriteLine("Hvilket tidspunkt?");
            string tid = Console.ReadLine();

            foreach (Booking booking in allBookings)
            {
                bool sammeDag = booking.Day.ToLower() == dag.ToLower();
                bool sammeTid = booking.TimeSlot.ToLower() == tid.ToLower();

                if (sammeDag && sammeTid)
                {
                    if (booking.BookedBy == null)
                    {
                        Console.WriteLine("Der er ingen booking på dette tidspunkt");
                    }
                    else
                    {
                        booking.BookedBy = null;

                        Console.WriteLine("Bookingen er nu fjernet");
                    }
                }
            }

            Console.ReadKey();
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
            


           
        }
    }
}
