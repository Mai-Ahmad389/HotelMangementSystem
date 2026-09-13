using System;
namespace HotelMangementSystem
{
    public class Room
    {
        public int RoomId { get; set; }
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public decimal PricePerNight { get; set; }
        public bool IsAvailable { get; set; }
        public Room(int roomId, int roomNumber, string roomType, decimal priceperNight)
        {
            RoomId = roomId;
            RoomNumber = roomNumber;
            RoomType = roomType;
            PricePerNight = priceperNight;
            IsAvailable = true;
        }
        public void DisplayInfo()
        {
            string status = IsAvailable ? "Available" : "Not Available";
            Console.WriteLine($"Room ID:{RoomId} | Room #:{RoomNumber} | Type:{RoomType} | price:${PricePerNight} | Status:{status}");
        }
    }
  }  

