using Codecool.HogwartsHouses.Model;

namespace Codecool.HogwartsHouses.Services.RoomRepo;

public interface IRoomRepository
{

    IEnumerable<Room> GetAll();
    bool AddRoom(string roomName);
    Room? GetRoomById(int id);
    bool DeleteRoom(int id);
    bool AssignedStudent(Student student, int roomId);
    //...
}