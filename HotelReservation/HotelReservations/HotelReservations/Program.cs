using HotelReservations.Room;
using System;

namespace HotelReservations
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* All Test Cases */
            Hotel hotel1 = new Hotel(1);
            //hotel1.RoomReservation(-4, 2);
            //hotel1.RoomReservation(200, 400);

            //Hotel hotel2 = new Hotel(3);
            //hotel2.RoomReservation(0, 5);
            //hotel2.RoomReservation(7, 13);
            //hotel2.RoomReservation(3, 9);
            //hotel2.RoomReservation(5, 7);
            //hotel2.RoomReservation(6, 6);
            //hotel2.RoomReservation(0, 4);

            Hotel hotel3 = new Hotel(3);
            hotel3.RoomReservation(1, 3);
            hotel3.RoomReservation(2, 5);
            hotel3.RoomReservation(1, 9);
            hotel3.RoomReservation(0, 15);

            Hotel hotel4 = new Hotel(3);
            hotel4.RoomReservation(1, 3);
            hotel4.RoomReservation(0, 15);
            hotel4.RoomReservation(1, 9);
            hotel4.RoomReservation(2, 5);
            hotel4.RoomReservation(4, 9);

            //Hotel hotel5 = new Hotel(2);
            //hotel5.RoomReservation(1, 3);
            //hotel5.RoomReservation(0, 4);
            //hotel5.RoomReservation(2, 3);
            //hotel5.RoomReservation(5, 5);
            //hotel5.RoomReservation(4, 10);
            //hotel5.RoomReservation(10, 10);
            //hotel5.RoomReservation(6, 7);
            //hotel5.RoomReservation(8, 10);
            //hotel5.RoomReservation(8, 9);
        }
    }
}
