using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Text;

namespace _123123
{
    internal class Menu
    {
        UserService userService = new UserService();

        public void LogInMenu()
        {


            Console.WriteLine("================================================");
            Console.WriteLine("                     Log In                     ");
            Console.WriteLine("================================================");

            Console.WriteLine("1)  Log ind ");
            Console.WriteLine("2)  Register bruger");
            Console.WriteLine("3)  Se alle registeret brugere");
            Console.WriteLine("3)  Afslut programmet");

            string input = Console.ReadLine().ToLower();

            switch (input)
            {
                case "1":
                    Console.Clear();
                    userService.Login();
                    break;

                case "2":
                    Console.Clear();
                    userService.RegisterUser();
                    break;
                case "3":
                    Console.Clear();
                    userService.ShowUserList();
                    break;

                case "4":
                    Console.Clear();
                    userService.LogOut();
                    break;
            }
        }

        public void MainMenu()
        {
            
            Console.Clear();
            Console.WriteLine("===============================================");
            Console.WriteLine("                   HOVEDMENU                   ");
            Console.WriteLine("===============================================");

            Console.WriteLine("1)  Status på lokaler");
            Console.WriteLine("2)  Lokale information");
            Console.WriteLine("3)  Book et lokale");
            Console.WriteLine("4)  Log ud");
            

            string input = Console.ReadLine().ToLower();

            switch (input)
            {
                case "1":
                    Console.Clear();
                   // lav en nyt objekt der kalder på klassen oppe i toppen uden for metoden, og kald metoden fra klassen her: MARIE
                    break;

                case "2":
                    Console.Clear();
                    // lav en nyt objekt der kalder på klassen oppe i toppen uden for denne metoden, og kald metoden fra klassen her: NEEGA
                    break;

                case "3":
                    Console.Clear();
                    // lav en nyt objekt der kalder på klassen oppe i toppen uden for metoden, og kald metoden fra klassen her: RAFAEL
                    break;
                case "4":
                    Console.Clear();
                    userService.LogOut();
                    break;
            }
        }

      


       
    }
    
}

