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
       


        public bool LogInMenuBool()
      


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

        public bool MainMenuBool()
        {
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
                    // lav en nyt objekt der kalder på klassen oppe i toppen uden for metoden (ligsom i linje 10/11), og kald metoden fra klassen her(ligsom i linje 81 uden return): MARIE
                    Console.WriteLine("test");
                    break;

                case '2':
                    Console.Clear();
                    // lav en nyt objekt der kalder på klassen oppe i toppen uden for denne metoden(ligsom i linje 10/11), og kald metoden fra klassen her(ligsom i linje 81 uden return): NEEGA

                    Console.WriteLine("test");
                    break;

                case '3':
                    Console.Clear();
                    
                    break;
                case '4':
                    Console.Clear();
                    return userService.LogOutBool();
                    
            }
            return true;
        } 
    }
}

