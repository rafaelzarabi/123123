using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace KontorNordProjekt
{
    internal class Booking
    {

        public string Day { get; set; }
        public string TimeSlot { get; set; }
        public User BookedBy { get; set; }
        public Rooms Room { get; set; }

        public Booking(string day, string timeSlot, User user, Rooms room)
        {
            Day = day;
            TimeSlot = timeSlot;
            BookedBy = user;
            Room = room;
        }



        


        


    
    } 

}
