using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservations.Room
{
    public class Room
    {
        /*In dayStatus dictionary key represent day, value represent is day reserved or not*/
        public Dictionary<int,bool> dayStatus;
        /* dayfree represent which day is available for*/
        public int dayfree = 0;
        public Room()
        {
            dayStatus = new Dictionary<int, bool>();
        }
        public void Reservation(int startDay, int endDay)
        {
            for(int i= startDay; i <= endDay; i++)
            {
                dayStatus[i] = false;
            }
            dayfree = endDay + 1;
        }
    }    
}

