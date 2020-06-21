using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelReservations.Room;

namespace HotelReservations.Room
{
    public class Hotel
    {
        /*key represent number of room, value represent Room entity*/
        private Dictionary<int, Room> rooms;
        public Hotel(int size)
        {
            if (size <= 1000)
            {
                rooms = new Dictionary<int, Room>();
                for (int i = 1; i <= size; i++)
                {
                    rooms.Add(i, new Room());
                }
                foreach (var room in rooms)
                {
                    int j = 0;
                    while (j < 365)
                    {
                        room.Value.dayStatus.Add(j, true);
                        j++;
                    }
                }
            }
        }
        public void RoomReservation(int startDay, int endDay)
        {
            bool reservationStatus = false;
            if (startDay >= 0 && endDay - startDay >= 0 && endDay < 365)
            {
                RoomSorting();/* Sorting by most optimal room for reservation */
                foreach (var room in rooms)
                {
                    var roomReservation = true;
                    for (int i = startDay; i <= endDay; i++)
                    {
                        if (room.Value.dayStatus[i] == false)
                        {
                            roomReservation = false;
                            break;
                        }
                    }
                    if (roomReservation == true)
                    {
                        room.Value.Reservation(startDay, endDay);
                        reservationStatus = true;
                        break;
                    }
                }
                if (reservationStatus == true)
                {
                    Console.WriteLine("StartDate " + startDay + " EndDate " + endDay + " Accept");
                }
                else
                {
                    Console.WriteLine("StartDate " + startDay + " EndDate " + endDay + " Decline");
                }
            }
            else
                Console.WriteLine("StartDate " + startDay + " EndDate " + endDay + " Decline");
        }
        public void RoomSorting()
        {
            var firstRoom = rooms.ElementAt(0);
            for (int i = 1; i < rooms.Count; i++)
            {
                var room = rooms.ElementAt(i);
                if (firstRoom.Value.dayfree < room.Value.dayfree)
                {
                    var pom = rooms[1];
                    rooms[1] = rooms[i+1];
                    rooms[i+1] = pom;
                }
            }
        }
    }
}
