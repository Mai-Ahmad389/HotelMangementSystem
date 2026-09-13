using System;
using System.Data;
namespace HotelMangementSystem
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int RoomId { get; set; }
        public int GuestId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

        public Reservation(int reservationId, int roomId, int guestId, DateTime checkInDate, DateTime checkOutDate)
        {
            ReservationId = reservationId;
            RoomId = roomId;
            GuestId = guestId;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Reservation ID:{ReservationId} | Room ID:{RoomId} | Guest ID:{GuestId} |Guest ID:{GuestId} | Chec-In:{CheckInDate.ToShortDateString()} | Check-Out: {CheckOutDate.ToShortDateString}");
        }
    }
}