using Codecool.HogwartsHouses.Model;

namespace Codecool.HogwartsHouses.Data
{
    public class RoomGenerator : IRoomGenerator
    {
        public IEnumerable<Room> Generate(int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return new Room($"Room{i}", i);
            }
        }
    }
}

