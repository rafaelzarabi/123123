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

        public void RegisterBruger()
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
       
        public void Login(string Username, string Password)
        {

            foreach (var user in _usersList)
            {



                if (user._Username == Username && user._Password == Password)
                {
                    Console.WriteLine("Login succesfuldt!");
                    return; // Stop metoden her, da vi har fundet brugeren
                }







            }    
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
       
    

          
        



        
    }
}
