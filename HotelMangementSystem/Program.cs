using System;
using System.Collections.Generic;
namespace HotelMangementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Room> rooms = new List<Room>();
            List<Guest> guests = new List<Guest>();
            List<Reservation> reservations = new List<Reservation>();
            int reservationCounter = 1;
            int guestCounter = 1;
            bool running = true;
            int roomCounter = 1;
            while (running)
            {
                Console.WriteLine("\n HotelMangementSystem");
                Console.WriteLine("1. Add Room");
                Console.WriteLine("2. View Rooms");
                Console.WriteLine("3. Search Room");
                Console.WriteLine("4. Add Guest");
                Console.WriteLine("5. View Guests");
                Console.WriteLine("6. Creat Reservation");
                Console.WriteLine("7. Cancel Reservation");
                Console.WriteLine("8. View Reservation");
                Console.WriteLine("9. Exit");
                Console.WriteLine("\nChoose on option:");

                string choice = Console.ReadLine()?.Trim();
                if (choice == "1")
                {
                    Console.WriteLine("\n Add New Room");
                    Console.WriteLine("Eter Room Number");
                    int roomNumber = int.Parse(Console.ReadLine());

                    Console.Write("Enter Room Type (Single/Doublesuite):");
                    string roomType = Console.ReadLine();

                    Console.Write("Enter Price Per Night:");
                    decimal price = decimal.Parse(Console.ReadLine());

                    Room newRoom = new Room(roomCounter, roomNumber, roomType, price);
                    rooms.Add(newRoom);
                    roomCounter++;

                    Console.WriteLine("Room added successffully!");
                }
                else if (choice == "2")
                {
                    Console.WriteLine("\n All Rooms");
                    if (rooms.Count == 0)
                    {
                        Console.WriteLine("No rooms available yet");
                    }
                    else
                    {
                        foreach (var room in rooms)
                        {
                            room.DisplayInfo();
                        }
                    }
                }
                else if (choice == "3")
                {
                    Console.WriteLine("\n Search Room");
                    Console.Write("Enter Room Number to search:");
                    int searchNumber = int.Parse(Console.ReadLine()!);
                    bool found = false;
                    foreach (var room in rooms)
                    {
                        if (room.RoomNumber == searchNumber)
                        {
                            Console.WriteLine("\nRoom Found:");
                            room.DisplayInfo();
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine("Room not found!");
                    }
                }
                else if (choice == "4")
                {
                    Console.WriteLine("\n Add New Guest");
                    Console.WriteLine("Enter Guest Name:");
                    string name = Console.ReadLine();

                    Console.Write("Enter Guest Phone: ");
                    string phone = Console.ReadLine()!;

                    Console.Write("Enter Guest Email:");
                    string email = Console.ReadLine()!;

                    Guest newGuest = new Guest(guestCounter, name, phone, email);
                    guests.Add(newGuest);
                    guestCounter++;

                    Console.WriteLine("Guest added successfully!");
                }
                else if (choice == "5")
                {
                    Console.WriteLine("\n All Guests");
                    if (guests.Count == 0)
                    {
                        Console.WriteLine("No guests available yet.");

                    }
                    else
                    {
                        foreach (var guest in guests)
                        {
                            guest.DisplayInfo();
                        }
                    }
                }
                else if (choice == "6")
                {
                    Console.WriteLine("\n Create Reservation");
                    Console.WriteLine("Enter Guest ID:");
                    int roomId = int.Parse(Console.ReadLine()!);

                    Console.Write("Enter Guest ID:");
                    int guestId = int.Parse(Console.ReadLine()!);

                    Console.Write("Enter Check In Date(Day,Month,Year):");
                    DateTime checkIn = DateTime.Parse(Console.ReadLine());

                    Console.Write("Enter Check Out Date(Day,Month,Year):");
                    DateTime checkOut = DateTime.Parse(Console.ReadLine());

                    Reservation newRes = new Reservation(reservationCounter, roomId, guestId, checkIn, checkOut);
                    reservations.Add(newRes);
                    reservationCounter++;

                    Console.WriteLine("Done!");
                }
                else if (choice == "7")
                {
                    Console.WriteLine("\n Cancle Reservation");
                    Console.WriteLine("Enter Reservation ID:");
                    int resId = int.Parse(Console.ReadLine());

                    bool found = false;
                    for (int i = 0; i < reservations.Count; i++)
                    {
                        if (reservations[i].ReservationId == resId)
                        {
                            reservations.RemoveAt(i);
                            Console.WriteLine("Reservatio removed successfully!");
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine("Not found!");
                    }
                }
                else if (choice == "8")
                {
                    Console.WriteLine("\n All Reservation");
                    if (reservations.Count == 0)
                    {
                        Console.WriteLine("No reservations");            
                    }
                    else
                    {
                        foreach (var res in reservations)
                        {
                            res.DisplayInfo();
                        }
                    }
                }
                else if (choice == "9")
                {
                    running = false;
                    Console.WriteLine("Exiting program");
                }
                else
                {
                    Console.WriteLine($"You selscted option {choice}.(Feature under construction)");
                }
            }
        }
    }
}
