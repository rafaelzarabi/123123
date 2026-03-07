using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _123123
{
    internal class UserService
    {
        //listen her viser alle Users
        private List<User> _usersList = new List<User>();

        public void RegisterUser()
        {
            Console.WriteLine("===============================================".PadLeft(50));
            Console.WriteLine("               REGISTER BRUGER                 ".PadLeft(50));
            Console.WriteLine("===============================================".PadLeft(50));

            Console.Write("Indtast Dit brugernavn: ");
            string Username = Console.ReadLine().ToLower();

            Console.Write("Indtast Dit adgangkode: ");
            string Password = Console.ReadLine().ToLower();

            //automatisk tilføjer unikt id til UserID, +1 fordi ellers starer den ved nul
            int UserID = _usersList.Count + 1;

            //opretter en ny bruger og tilføjer den til _userslisten
            User NewUser = new User(Username, Password, UserID);
            _usersList.Add(NewUser);
        }

        public bool Login()
        {
            if (_usersList.Count == 0)
            {
                Console.WriteLine("Du skal oprette en bruger først...\n Tryk på en vilkårlig tast for at forsætte");
                Console.ReadKey();
                return false;
            }

            Console.WriteLine("===============================================".PadLeft(50));
            Console.WriteLine("                    Log in                     ".PadLeft(50));        
            Console.WriteLine("===============================================".PadLeft(50));

            
            Console.Write("Indtast Dit brugernavn: ");
            string Username = Console.ReadLine().ToLower();

            Console.Write("Indtast Dit adgangkode: ");
            string Password = Console.ReadLine().ToLower();

            
            foreach (User user in _usersList)
            {
                if (user._Username == Username && user._Password == Password)
                {
                    Console.WriteLine("Adgang givet");
                    Thread.Sleep(1000);
                    return true;
                }       
            }
            Console.WriteLine("Forkert brugernavn eller adgangkode... Prøv venligst igen");
            return false;
        }

        

        public void ShowUserList()        
        {
            Console.Clear();
            Console.WriteLine("===============================================".PadLeft(50));
            Console.WriteLine("                ALLE BRUGERE                   ".PadLeft(50));
            Console.WriteLine("===============================================".PadLeft(50));

            foreach (var user in _usersList)       
            {
                Console.WriteLine($"Navn: {user._Username}, ID: {user._UserID}");   
                Console.WriteLine("");
            }

            Console.WriteLine("");
            Console.WriteLine("Tryk på en vilkårlig tast for at vende tilbage til hovedmenuen....");
            Console.ReadKey();
        
        
        }
       
    
        public void LogOut()
        {
            Console.WriteLine("Er du sikker på du gerne vil lukke programmet? Alt data slettes permenent ( JA / Nej )");
            string svar = Console.ReadLine().ToLower();
            if (svar == "ja")
            {
                Environment.Exit(0);
            }
            else { Console.Clear(); }
        }
          
        



        
    }
}
