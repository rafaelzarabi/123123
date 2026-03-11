using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Text;

namespace _123123
{
    internal class Menu
    {
        UserService userService = new UserService();
        Program program = new Program();


        /*public bool LogInMenuBool()
      


        {
            Console.WriteLine("================================================");
            Console.WriteLine("                     Log In                     ");
            Console.WriteLine("================================================");
            Console.WriteLine("1)  Log ind ");
            Console.WriteLine("2)  Register bruger");
            Console.WriteLine("3)  Se alle registeret brugere");
            Console.WriteLine("4)  Afslut programmet");

            ConsoleKeyInfo keyinfo = Console.ReadKey();

            switch (keyinfo.KeyChar)
            {
                case '1':
                    Console.Clear();
                    return userService.LoginBool();
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
                    program.CloseProgram();
                        break;
            }
            return false;
        }

        */
        public bool MainMenuBool()
        {
            Console.Clear();
            Console.WriteLine("===============================================");
            Console.WriteLine("                   HOVEDMENU                   ");
            Console.WriteLine("===============================================");

            Console.WriteLine("1)  Status på lokaler");
            Console.WriteLine("2)  Lokale information");
            Console.WriteLine("3)  Book et lokale");
            Console.WriteLine("4)  Fjerne bookings");
            Console.WriteLine("4)  Log ud");

            ConsoleKeyInfo keyinfo = Console.ReadKey();

            switch (keyinfo.KeyChar)
            {
                case '1':
                    Console.Clear();
                    Rooms.LokaleStatus();
                    break;

                case '2':
                    Console.Clear();

					foreach (var rooms in Rooms.GetLokaler())
					{
						Console.WriteLine($"Lokale: {rooms.Name}. Antal siddepladser: {rooms.SeatsAmount}. Har rummet en projektor? {rooms.HasProjector}. Har rummet et Whiteboard? {rooms.HasWhiteboard}");
					}
                    Console.ReadKey();

					break;

                case '3':
                    Console.Clear();
					new Booking().BookRoom();
					break;

				case '4':
					Console.Clear();
                    Booking.RemoveBooking();
					break;

				case '5':
                    Console.Clear();
                    return userService.LogOutBool();

				default:
					Console.WriteLine("Ugyldigt valg");
					Console.ReadKey();
					return false;

			}
            return true;
        } 
    }
}

