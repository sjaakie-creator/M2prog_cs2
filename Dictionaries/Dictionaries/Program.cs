using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        
        private static Dictionary<string, Room> rooms = new Dictionary<string, Room>();

        static void Main(string[] args)
        {
            Run();
        }

        static void Run()
        {
            
            Dictionary<int, string> exampleDictionary = new Dictionary<int, string>
            {
                { 1, "Jim" },
                { 2, "Tim" }
            };

            
            Console.WriteLine($"Key 1: {exampleDictionary[1]}");
            Console.WriteLine($"Key 2: {exampleDictionary[2]}");

            
            foreach (var item in exampleDictionary)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }

            
            Console.WriteLine("Alle keys:");
            foreach (var key in exampleDictionary.Keys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine("Alle values:");
            foreach (var value in exampleDictionary.Values)
            {
                Console.WriteLine(value);
            }

           
            Room startRoom = new Room(0, 0, "De startkamer");
            rooms.Add(startRoom.GetRoomLocationKey(), startRoom);

            
            ShowRoom(0, 0);

           
            Room room1 = new Room(1, 0, "Een kamer naar het oosten");
            Room room2 = new Room(0, 1, "Een kamer naar het noorden");
            Room room3 = new Room(-1, 0, "Een kamer naar het westen");

            rooms.Add(room1.GetRoomLocationKey(), room1);
            rooms.Add(room2.GetRoomLocationKey(), room2);
            rooms.Add(room3.GetRoomLocationKey(), room3);

            
            ShowRoom(1, 0);
            ShowRoom(0, 1);
            ShowRoom(-1, 0);

            
            ShowRoom(5, 5);

            Console.ReadLine(); 
        }

        private static void ShowRoom(int x, int y)
        {
            string key = $"{x},{y}";

            if (rooms.ContainsKey(key))
            {
                Room room = rooms[key];
                Console.WriteLine($"Kamer gevonden: {room.Description}");
            }
            else
            {
                Console.WriteLine($"Geen kamer gevonden op locatie {x}, {y}.");
            }
        }
    }

    class Room
    {
        public int X { get; }
        public int Y { get; }
        public string Description { get; }

        public Room(int x, int y, string description)
        {
            X = x;
            Y = y;
            Description = description;
        }

   
        internal string GetRoomLocationKey()
        {
            return $"{X},{Y}";
        }
    }
}
