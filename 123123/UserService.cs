using System;
using System.Collections.Generic;
using System.Text;

namespace _123123
{
    internal class UserService
    {

        public void RegisterBruger(Bruger Username)
        {
            Console.WriteLine("===============================================".PadLeft(50));
            Console.WriteLine("               REGISTER BRUGER                 ".PadLeft(50));
            Console.WriteLine("===============================================".PadLeft(50));

            Console.Write("Indtast Dit brugernavn: ");
            string Username = Console.ReadLine().ToLower();

            Console.Write("Indtast Dit adgangkode: ");
            String Password = Console.ReadLine().ToLower();

            Bruger NewUser = new Bruger(Username, Password);

        }
    }
}
