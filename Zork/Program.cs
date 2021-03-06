﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;

namespace Zork
{
    class program
    {
        static void Main(string[] args)
        {
            const string defaultGameFilename = "Zork.json";
            string gameFilename = (args.Length > 0 ? args[(int)CommandLineArguments.GameFilename] : defaultGameFilename);

            Game game = Game.Load(gameFilename);
            Console.WriteLine("Welcome to Zork!");
            game.Run();
            Console.WriteLine("Thank you for playing!");
        }

        private enum CommandLineArguments
        {
            GameFilename = 0
        }
    }
//    internal class Program
//    {
//        private static (int Row, int Column) Location = (1, 1);

//        static void Main(string[] args)
//        {
//            Console.WriteLine("Welcome to Zork!");
//            const string defaultRoomsFilename = "Rooms.json";
//            string roomsFilename = (args.Length > 0 ? args[(int)CommandLineArguments.RoomsFilename] : defaultRoomsFilename);
//            InitializeRooms(roomsFilename);

//            Room previousRoom = null;
//            Commands command = Commands.UNKNOWN;
//            while (command != Commands.QUIT)
//            {
//                Console.WriteLine(CurrentRoom);
//                if (previousRoom != CurrentRoom)
//                {
//                    Console.WriteLine(CurrentRoom.Description);
//                    previousRoom = CurrentRoom;
//                }
//                Console.Write("> ");
//                command = ToCommand(Console.ReadLine().Trim());

//                switch (command)
//                {
//                    case Commands.QUIT:
//                        Console.WriteLine("Thank you for playing!");
//                        break;
//                    case Commands.LOOK:
//                        Console.WriteLine(CurrentRoom.Description);
//                        break;
//                    case Commands.NORTH:
//                    case Commands.SOUTH:
//                    case Commands.EAST:
//                    case Commands.WEST:
//                        if (Move(command) == false)
//                        {
//                            Console.WriteLine("The way is shut!");
//                        }
//                        break;

//                    default:
//                        Console.WriteLine("Unknown command.");
//                        break;
//                }
//            }
//        }
//        private static bool Move(Commands command)
//        {
//            Assert.IsTrue(IsDirection(command), "Invalid direction.");

//            bool valid = true;
//            switch (command)
//            {
//                case Commands.NORTH when Location.Row < Rooms.GetLength(0) - 1:
//                    Location.Row++;
//                    break;

//                case Commands.SOUTH when Location.Row > 0:
//                    Location.Row--;
//                    break;

//                case Commands.EAST when Location.Column < Rooms.GetLength(1) - 1:
//                    Location.Column++;
//                    break;

//                case Commands.WEST when Location.Column > 0:
//                    Location.Column--;
//                    break;

//                default:
//                    valid = false;
//                    break;
//            }
//            return valid;
//        }

//        private static Room CurrentRoom
//        {
//            get
//            {
//                return Rooms[Location.Row, Location.Column];
//            }
//        }

//        /* static Program()
//         {
//             RoomMap = new Dictionary<string, Room>();
//             foreach (Room room in Rooms)
//             {
//                 RoomMap[room.Name] = room;
//             }
//         } */

//        /*private static void InitializeRoomDescriptions(string roomsFilename)
//        {
//            var rooms = JsonConvert.DeserializeObject<Room[]>(File.ReadAllText(roomsFilename));
//            foreach(Room room in rooms)
//            {
//                RoomMap[room.Name].Description = room.Description;
//            }
//        }
//    */
//        private static void InitializeRooms(string roomsFilename) =>
//            Rooms = JsonConvert.DeserializeObject<Room[,]>(File.ReadAllText(roomsFilename));

//            private static Commands ToCommand(string commandString) =>
//                 Enum.TryParse(commandString, true, out Commands result)
//                    ? result : Commands.UNKNOWN;

//            private static bool IsDirection(Commands command)
//                => Directions.Contains(command);

//        private static Room[,] Rooms =
//        {
//            {new Room("Rocky Trail"), new Room("South of House"), new Room("Canyon View")},
//            {new Room("Forest"), new Room("West of House"), new Room("Behind House")},
//            {new Room("Dense Woods"), new Room("North of House"), new Room("Clearing")}
//        };

//        //private static readonly Dictionary<string, Room> RoomMap;

//        private static readonly List<Commands> Directions = new List<Commands>
//        {
//          Commands.NORTH,
//          Commands.SOUTH,
//          Commands.EAST,
//          Commands.WEST,
//        };

//        private enum Fields
//        {
//            Name = 0,
//            Description
//        }

//        private enum CommandLineArguments
//        { 
//            RoomsFilename=0
//        }
//    }
}