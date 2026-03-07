using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Text;

namespace _123123
{
    internal class Menu
    {
        public string Name { get; private set; }

        public void LogInMenu()
        {
            UserService userService = new UserService();
            List<User> userlist = new List<User>();


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
            UserService userService = new UserService();
            Console.Clear();
            Console.WriteLine("===============================================");
            Console.WriteLine("                   HOVEDMENU                   ");
            Console.WriteLine("===============================================");

            Console.WriteLine("1)  Status på lokaler");
            Console.WriteLine("1)  Status på lokaler");
            Console.WriteLine("1)  Status på lokaler");
            Console.WriteLine("1)  Status på lokaler");
            Console.WriteLine("1)  Status på lokaler");

            string input = Console.ReadLine().ToLower();

            switch (input)
            {
                case "1":
                    Console.Clear();
                    userService.RegisterBruger();
                    break;

                case "2":
                    Console.Clear();
                    userService.ShowUserList();
                    break;

                case "3":
                    Console.Clear();

                    break;
                case "4":
                    Console.Clear();

                    break;

                case "5":
                    Console.Clear();

                    break;

                case "6":
                    Console.Clear();

                    break;

            }
        }

      


       
    }
    
}

