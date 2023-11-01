using Codecool.HogwartsHouses.Model;

namespace Codecool.HogwartsHouses.Data
{
    public interface IStudentGenerator
    {
        IEnumerable<Student> Generate(int count);
    }
}
