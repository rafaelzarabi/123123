using System;
using System.Collections.Generic;
using System.Text;

namespace KontorNordProjekt
{
    internal class User
    {
        //klassens atributes i fields
        public string _Firstname { get; private set; }
        public string _Lastname { get; private set; }
        public string _Password { get; private set; }
        public int _UserID { get; private set; }

        //klassens Constructor 
        public User(string Firstname, string Lastname, string Password, int UserID)
        {
            _Firstname = Firstname;
            _Lastname = Lastname;
            _Password = Password;
            _UserID = UserID;
        }
    }
}
