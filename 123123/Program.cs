using _123123;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace _123123
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // kalder klassen, så jeg kan bruge den i main
            Menu menu = new Menu();
            UserService userService = new UserService();

            bool ProgramRunning = true;
            bool LogIn = false;

            while (ProgramRunning == true)
            {
                /*
                while (LogIn == false)
                {
                    Console.Clear();
                    LogIn = menu.LogInMenuBool();   // Vi har en return stafet med bool fra loginBool()-->loginMenuBool-->Main
                }
                */
                Console.Clear();
                LogIn = menu.MainMenuBool();      // Vi har en return stafet med bool fra  LogOut()-->mainMenu()-->Main()    
            }
        }
        
        public void CloseProgram()
        {
            Console.WriteLine("Er du sikker på du vil afslutte programmet? At afslutte programmet fjerne af indtastet data");
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
            
            //LOKALE INFO - FRA LOKALER.CS KLASSE
            List<Rooms> rooms = Rooms.GetLokaler();

            foreach (var room in rooms)
            {
                Console.WriteLine($"Lokale {room.Name} ({room.SeatsAmount} pladser) - {(room.HasWhiteboard ? "Whiteboard" : "Ingen whiteboard")} - {(room.HasProjector ? "Projektor" : "Ingen projektor")}");
            }
        }
    }
}
