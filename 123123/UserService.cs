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
            string Firstname = "";
            string Lastname = "";
            string Password = "";

            Console.WriteLine("===============================================");
            Console.WriteLine("               REGISTER BRUGER                 ");
            Console.WriteLine("===============================================");

            while (Firstname.Length < 2)
            {
                Console.Write("Indtast dit Fornavn. Minimum 2 bogstaver:");
                Firstname = Console.ReadLine().ToLower().Trim();

                if (Firstname.Any(char.IsDigit) && Firstname == "")
                {
                    Console.WriteLine("fejl... Du skal indtase et navn med mindst 2 bogstaver, og ingen tal");
             
                }
            }

            while (Lastname.Length < 2)
            {
                // Trim fjerner mellemrum
                Console.Write("Indtast dit efternavn. Minimum 2 bogstaver: ");
                 Lastname = Console.ReadLine().ToLower().Trim();

                if (Lastname.Any(char.IsDigit) && Lastname == "")
                {
                    Console.WriteLine("");
                    Console.WriteLine("fejl... Du skal indtase et Efter med mindst 2 bogstaver, og ingen tal\nTryk på en vilkårlig tast for at vende tilbage til login");
                }
            }

            while (Password.Length < 5)
            {
                // Trim fjerner mellemrum
                Console.Write("Indtast din adgangkode. Mindst 5 tegn: ");
                Password = Console.ReadLine().ToLower().Trim();

                if (Password == "")
                {
                    Console.WriteLine("");
                    Console.WriteLine("du skal indtaste en gyldig adgangskode");
                }
            }
   
            //automatisk tilføjer unikt id til UserID, +1 fordi ellers starer den ved 0
            int UserID = _usersList.Count + 1;

            //opretter en ny bruger og tilføjer den til _userslisten
            User NewUser = new User(Firstname, Lastname, Password, UserID);
            _usersList.Add(NewUser);
        }

        public bool Login()
        {
            if (_usersList.Count == 0)
            {
                Console.WriteLine("Du skal oprette en bruger først...\n Tryk på en vilkårlig tast for at vende tilbage til login");
                Console.ReadKey();
                return false;
            }

            Console.WriteLine("===============================================".PadLeft(50));
            Console.WriteLine("                    Log in                     ".PadLeft(50));        
            Console.WriteLine("===============================================".PadLeft(50));

            
            Console.Write("Indtast Dit Fornavn: ");
            string Firstname = Console.ReadLine().ToLower();

            Console.Write("Indtast Dit adgangkode: ");
            string Password = Console.ReadLine().ToLower();

            
            foreach (User user in _usersList)
            {
                if (user._Firstname == Firstname && user._Password == Password)
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

            foreach (User user in _usersList)       
            {
                Console.WriteLine($"Navn: {user._Firstname} {user._Lastname}, ID: {user._UserID}");   
                Console.WriteLine("");
                Console.ReadKey();
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
