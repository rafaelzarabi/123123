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
          
            

            while (Firstname.Length < 2 || Firstname.Any(char.IsDigit))

            {
                Console.WriteLine("===============================================");
                Console.WriteLine("               REGISTER BRUGER                 ");
                Console.WriteLine("===============================================");
                Console.WriteLine("");
                Console.Write("Indtast dit Fornavn. Minimum 2 bogstaver:");
                Firstname = Console.ReadLine().ToLower().Trim();

                if (Firstname.Any(char.IsDigit) || Firstname == "")
                {
                    Console.WriteLine("");
                    Console.WriteLine("fejl... Du skal indtase et navn med mindst 2 bogstaver, og ingen tal");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                Console.Clear();
            }

            while ( Lastname == "" || Lastname.Length < 2 || Lastname.Any(char.IsDigit ))
            {
                // Trim fjerner mellemrum
                Console.WriteLine("===============================================");
                Console.WriteLine("               REGISTER BRUGER                 ");
                Console.WriteLine("===============================================");
                Console.WriteLine("");
                Console.Write("Indtast dit efternavn. Minimum 2 bogstaver: ");
                Lastname = Console.ReadLine().ToLower().Trim();

                if (Lastname.Any(char.IsDigit) || Lastname == "" || Lastname.Length < 2)
                {
                    Console.WriteLine("");
                    Console.WriteLine("fejl... Du skal indtase et Efternavn med mindst 2 bogstaver, og ingen tal");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                Console.Clear();
            }

            while (Password.Length < 5 || Password == "")
            {
                // Trim fjerner mellemrum
                Console.WriteLine("===============================================");
                Console.WriteLine("               REGISTER BRUGER                 ");
                Console.WriteLine("===============================================");
                Console.WriteLine("");
                Console.Write("Indtast din adgangkode. Mindst 5 tegn: ");
                Password = Console.ReadLine().ToLower().Trim();

                if (Password == "" || Password.Length < 5 )
                {
                    Console.WriteLine("");
                    Console.WriteLine("Fejl... du skal indtaste en adgangskode med mindst 5 tegn");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }

            //automatisk tilføjer unikt id til UserID, +1 fordi ellers starer den ved 0
            int UserID = _usersList.Count + 1;

            //opretter en ny bruger og tilføjer den til _userslisten
            User NewUser = new User(Firstname, Lastname, Password, UserID);
            _usersList.Add(NewUser);
        }
        public bool LoginBool()
        {
            if (_usersList.Count == 0)
            {
                Console.WriteLine("Du skal oprette en bruger først!");
                Thread.Sleep(1000);
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
                Console.WriteLine("");
                Console.WriteLine($"Navn: {user._Firstname} {user._Lastname}, ID: {user._UserID}");
                Console.WriteLine("");
            }

            Console.WriteLine("");
            Console.WriteLine("Tryk på en vilkårlig tast for at vende tilbage til hovedmenuen....");
            Console.ReadKey();
        }

        public bool LogOutBool()
        {
            Console.WriteLine("Er du sikker på du gerne vil logge ud? ( Ja / Nej )");
            Console.WriteLine("1) ja");
            Console.WriteLine("2) Nej");
            ConsoleKeyInfo svar = Console.ReadKey();

            switch (svar.KeyChar)
            {
                case '1':
                    return false;
                case '2':
                    return true;
            }
            return true;
        }
    }
}
