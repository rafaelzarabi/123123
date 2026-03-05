using System;
using System.Collections.Generic;
using System.Text;

namespace _123123
{
    internal class User
    {
        public string _UserName { get; private set; }
        public string _Password { get; private set; }
        public int _UserID { get; private set; }

        public User(string Username, int UserID, string Password)
        {
            _UserName = Username;
            _Password = Password;
            _UserID = UserID;




        }
    }
}
