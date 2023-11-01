using Codecool.HogwartsHouses.Data;
using Codecool.HogwartsHouses.Model;
using Microsoft.AspNetCore.Mvc;
using Npgsql;

namespace Codecool.HogwartsHouses.Services.RoomRepo
{
    public class RoomRepository : IRoomRepository
    {
        private List<Room> _rooms { get; set; }
        public IRoomGenerator RoomGenerator { get; set; }


        public RoomRepository(IRoomGenerator roomGenerator)
        {
            RoomGenerator = roomGenerator;
            _rooms = roomGenerator.Generate(5).ToList();
        }

        public IEnumerable<Room> GetAll()
        {
            return _rooms;
        }



        public bool AddRoom(string roomName)
        {
            try
            {
                Room room = new Room(roomName, _rooms.Last().Id + 1);
                _rooms.Add(room);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Room? GetRoomById(int id)
        {
            try
            {
                return _rooms.Single(r => r.Id == id);
            }
            catch
            {
                return null;
            }
        }

        public bool DeleteRoom(int id)
        {
            try
            {
                return _rooms.Remove(_rooms.Single(r => r.Id == id));
            }
            catch
            {
                return false;
            }
        }

        public bool AssignedStudent(Student student, int roomId)
        {
            try
            {
                var room = GetRoomById(roomId);
                room.AddStudent(student);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
