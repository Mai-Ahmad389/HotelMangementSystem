using System;
using System.ComponentModel.DataAnnotations;
namespace HotelMangementSystem
{
    public class Guest
    {
        public int GuestId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Guest(int guestId, string name, string phone, string email)
        {
        GuestId = guestId;
        Name = name;
        Phone = phone;
        Email = email;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {GuestId} | Name:{Name} | Phone:{Phone}| Email:{Email}");
        }
      }
    }


